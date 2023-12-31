export function toBase64(file : File): Promise<string>  {
    return new Promise((resolve, reject)=>{
        const fileReader: FileReader = new FileReader();
        fileReader.readAsDataURL(file);
        fileReader.onload= ()=>{resolve(<string>fileReader.result)};
        fileReader.onerror = (error)=>{reject(error)};
    });
};