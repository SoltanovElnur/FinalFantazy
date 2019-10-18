using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem.HRM.Entity.Extantions
{
    public static class IFormFileEx
    {
        public async static Task<string> SaveFile(this IFormFile file, string fileUrl)
        {
            string filename = Path.Combine(Guid.NewGuid().ToString() + "_" + Path.GetFileName(file.FileName));
            string filepath = Path.Combine(fileUrl, "images", filename);
            using (var stream = new FileStream(filepath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            return filename;

        }
        
    }
}
