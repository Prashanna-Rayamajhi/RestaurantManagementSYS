
public class FileManagement : IFileManagement
{
    private readonly IWebHostEnvironment environment;
    private readonly IHttpContextAccessor contextAccessor;

    //webhost environment
    public FileManagement(IWebHostEnvironment environment, IHttpContextAccessor contextAccessor)
    {
        this.environment = environment;
        this.contextAccessor = contextAccessor;
    }
    public Task DeleteFile(string route, string dirName)
    {
        if(String.IsNullOrEmpty(route)){
            return  Task.CompletedTask;
        }
        var fileName = Path.GetFileName(route);
        var directory = Path.Combine(environment.WebRootPath, dirName, fileName);
        if(File.Exists(directory)){
            File.Delete(directory);
        }
        return Task.CompletedTask;
    }

    public async Task<string> EditFile(IFormFile file, string dirName, string route)
    {
        await this.DeleteFile(route, dirName);
        var routeForDb = await this.SaveFile(file, dirName);
        return routeForDb;
    }

    public async Task<string> SaveFile(IFormFile file, string dirName)
    {
        var fileExtension = Path.GetExtension(file.FileName);
        var fileName = $"{Guid.NewGuid()}{fileExtension}";

        var directoryPath = Path.Combine(environment.WebRootPath, dirName);

        if(!Directory.Exists(directoryPath)){
            Directory.CreateDirectory(directoryPath);
        }

        var route = Path.Combine(directoryPath, fileName);

        using(var stream = new MemoryStream()){
            await file.CopyToAsync(stream);
            var content = stream.ToArray();
            await File.WriteAllBytesAsync(route, content);
        };

        var url = $"{this.contextAccessor.HttpContext.Request.Scheme}://{this.contextAccessor.HttpContext.Request.Host}";
        var routeForDb = Path.Combine(url, dirName, fileName).Replace('\\', '/');
        return routeForDb;
    }
}