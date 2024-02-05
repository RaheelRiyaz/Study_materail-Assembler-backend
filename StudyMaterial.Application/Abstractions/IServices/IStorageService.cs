using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyMaterial.Application.Abstractions.IServices
{
    public interface IStorageService
    {
        Task<string> SaveFileAsync(IFormFile file);
        Task DeleteFileAsync(string filePath);
        Task DeleteFilesAsync(List<string> filePaths);
        Task SaveFilesAsync(IFormFileCollection files);
    }
}
