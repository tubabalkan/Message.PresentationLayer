using Message.BusinessLayer.Abstract;
using Message.DataAccessLayer.Abstract;
using Message.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Message.BusinessLayer.Concrete
{
    public class MessageBoxManager : IMessageBoxService
    {
        private readonly IMessageBoxDal _messageBoxDal;
        public void TDelete(int id)
        {
            _messageBoxDal.Delete(id);
        }

        public MessageBox TGetById(int id)
        {
          return  _messageBoxDal.GetById(id);
        }

        public List<MessageBox> TGetListAll()
        {
            return _messageBoxDal.GetListAll();
        }

        public void TInsert(MessageBox entity)
        {
            _messageBoxDal.Insert(entity);
        }

        public void TUpdate(MessageBox entity)
        {
            _messageBoxDal.Update(entity);
        }
    }
}
