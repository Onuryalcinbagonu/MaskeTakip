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
    public class PersonManager : IApplicantService
    {
        //encapsulation Person person işlemi önemlidir.
       public void ApplyForMask(Person person) 
        //Maske için başvuru 
        // Bu yapıya fonksiyon,metot,prosedür denilmektedir.
        {

        }

        public List<Person> GetList()
        {
            return null;
        }

        public bool CheckPerson(Person person)
        //Vatandaş mı, değil mi ?
        {

            KPSPublicSoapClient client=new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync
            (new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(person.NationalIdentity,person.FirstName,person.LastName,person.DateOfBirthYear))).Result.Body.TCKimlikNoDogrulaResult; 

            //Adapter Design Pater bakılmalı!!!. Başka yerde kullanmak için...
        }
    }
}
//Abstract soyut işlemler Concrete somut işlemler içindir.
//Business veya Servis iş kuralları işlemleri için oluşturulan projelerdir.