public interface IFileManagement{
    Task DeleteFile(string route, string dirName);
    Task<string> SaveFile(IFormFile file, string dirName);

    Task<string> EditFile(IFormFile file, string dirName, string route);
}