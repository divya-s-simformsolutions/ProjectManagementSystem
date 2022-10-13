using Microsoft.EntityFrameworkCore;

namespace ProjectManagementSystem.Data
{
    public class ProjectsService
    {

        private readonly ApplicationDbContext _appDBContext;



        public ProjectsService(ApplicationDbContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        public async Task<List<Project>> GetAllProjectAsync()
        {
            return await _appDBContext.Project.ToListAsync();
        }
        #region Insert Project
        public async Task<bool> InsertProjectAsync(Project project)
        {
            await _appDBContext.Project.AddAsync(project);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion
        #region Get Project by Id
        public async Task<Project> GetProjectAsync(int Id)
        {
            Project project = await _appDBContext.Project.FirstOrDefaultAsync(c => c.Id.Equals(Id));
            return project;
        }
        #endregion

        #region Update Project
        public async Task<bool> UpdateProjectAsync(Project project)
        {
            _appDBContext.Project.Update(project);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Project Developer
        public async Task<bool> DeleteProjectAsync(Project project)
        {
            _appDBContext.Remove(project);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion
    }
}
