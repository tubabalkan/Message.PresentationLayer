using Message.DataAccessLayer.Abstract;
using Message.DataAccessLayer.Repositories;
using Message.DateAccessLayer.Concrete;
using Message.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Message.DataAccessLayer.EntityFramework
{
    public class EfMessageBoxDal : GenericRepository<MessageBox>, IMessageBoxDal
    {
        
    }
}
