namespace GymManagement.Domain.Admins.Repositories;

public interface IAdminsRepository
{
    Task<Admin?> GetByIdAsync(Guid adminId);
    Task UpdateAsync(Admin admin);
}
