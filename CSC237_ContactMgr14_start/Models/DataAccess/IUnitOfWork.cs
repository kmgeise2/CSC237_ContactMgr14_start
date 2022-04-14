
namespace CSC237_ContactMgr14_start.Models
{
    public interface IUnitOfWork
    {
        IRepository<Contact> Contacts { get; }
        IRepository<Category> Categories { get; }

        void Save();
    }
}
