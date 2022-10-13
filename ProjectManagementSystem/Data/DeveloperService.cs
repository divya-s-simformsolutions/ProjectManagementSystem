using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace ProjectManagementSystem.Data
{
    public class DeveloperService
    {
        #region Property
        private readonly ApplicationDbContext _appDBContext;
        #endregion

        
        public DeveloperService(ApplicationDbContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        public async Task<List<Developer>> GetAllDeveloperAsync()
        {
            return await _appDBContext.Developer.ToListAsync();
        }
        #region Insert Developer
        public async Task<bool> InsertDeveloperAsync(Developer developer)
        {
            await _appDBContext.Developer.AddAsync(developer);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion
        #region Get Developer by Id
        public async Task<Developer> GetDeveloperAsync(int Id)
        {
            Developer developer = await _appDBContext.Developer.FirstOrDefaultAsync(c => c.Id.Equals(Id));
            return developer;
        }
        #endregion

        #region Update Developer
        public async Task<bool> UpdateDeveloperAsync(Developer developer)
        {
            _appDBContext.Developer.Update(developer);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Developer
        public async Task<bool> DeleteDeveloperAsync(Developer developer)
        {
            _appDBContext.Remove(developer);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion
    }
}
