using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager :ISupplierService
    {
         //ptt managerin bağımlı olduğu sınıf yerine o sınıfların interfacesini yazıyorum.
        private IApplicantService _applicantService;

        public PttManager(IApplicantService applicantService) // Constructer=oluşturucu new yapıldığında çalışır
        {
            _applicantService = applicantService;
        }
        
        
        public void GiveMask(Person person) //maskeyi verebilmek için buna ihtiyaç var
        {
            //PersonManager personManager = new PersonManager();// bir iş sınıfı(entities hariç) başka bir iş sınıfını kullanırken newliyorsa ileriye dönük,
            // bu yazılımda değişiklik talebi geldiğinde bu uygulama direnç gösterir. yani personManagere bağımlıyız demek. Bu bağımlılık olmamalı. (Abstract, interface ekledik.)
            //eğer sen burada personManagerı bir sınıfı direk newleyip başka bir yerde kullanıyorsan
            // sen bir BAĞIMLISIN.
           
            if(_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " için maske verildi ");
            }
            else
            {
                Console.WriteLine(person.FirstName + " için maske VERİLEMEDİ ");
            }
        }
        
    }
}
