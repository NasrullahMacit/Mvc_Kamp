
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrate.Repositories;
using EntityLayer.Concrate;

namespace DataAccessLayer.EntityFramework
{
    public class EfHeadingDal: GenericRepository<Heading>,IHeadingDal
    {
    }
}
