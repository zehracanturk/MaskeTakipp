using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ForeignerManager : IApplicantService
    {
        public bool CheckPerson(Person person)
        {
            throw new NotImplementedException(); //yabancının kodu buraya, Türkün kodu diğer tarafa.
        }

        public List<Person> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
