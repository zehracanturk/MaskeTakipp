using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
   //çıplak class kalmasın
   //bir clası (entities hariç) oluşturduğun zaman onun interfacesini oluşturduğumuzdan emin oluyoruz.
    
    public class PersonManager: IApplicantService
    {
        //bir sınıf sadece özellik tutabilir veya bir sınıf sadece operasyon tutabilir
       //encapsulation
       public void ApplyForMask(Person person)
        {

        }

       public List<Person> GetList()
        {
            return null;
        }

        public bool CheckPerson(Person person) //mernise bağlanıp doğru adam mı diye kontrol edecek
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(
                new TCKimlikNoDogrulaRequest
                (new TCKimlikNoDogrulaRequestBody(person.NationalIdentity,Ad:person.FirstName ,Soyad:person.LastName,DogumYili:person.DateOfBirthYear)))
                .Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
