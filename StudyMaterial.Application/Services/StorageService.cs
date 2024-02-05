using Microsoft.AspNetCore.Http;
using StudyMaterial.Application.Abstractions.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoultryFarming.Application.Services
{
    public class StorageService:IStorageService
    {
        private readonly string webrootPath;

        public StorageService(string webrootPath)
        {
            this.webrootPath = webrootPath;
        }

        public Task DeleteFileAsync(string filePath)
        {
            throw new NotImplementedException();
        }

        public Task DeleteFilesAsync(List<string> filePaths)
        {
            throw new NotImplementedException();
        }

        public async Task<string> SaveFileAsync(IFormFile file)
        {
            string fileName = string.Concat(Guid.NewGuid(), file.FileName);
            string fullPath = string.Concat(GetPhysicalAddress(), fileName);
            FileStream fs = new FileStream(fullPath, FileMode.Create);
             
            await  file.CopyToAsync(fs);
            return GetVirtualAddress() + fileName;
        }

        public Task SaveFilesAsync(IFormFileCollection files)
        {
            throw new NotImplementedException();
        }


        #region Address Retreivers
        private string GetVirtualAddress()
        {
            return  "/Files/";
        }

        private string GetPhysicalAddress()
        {
            return webrootPath + GetVirtualAddress();
        }

        #endregion Address Retreivers
    }
}
