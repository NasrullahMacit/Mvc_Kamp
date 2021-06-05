using DataAccessLayer.Concrate.Repositories;
using DataAccessLayer.Abstract;
using EntityLayer.Concrate;

namespace DataAccessLayer.EntityFramework
{
    public class EfWriterDal: GenericRepository<Writer>, IWriterDal
    {
    }
}
