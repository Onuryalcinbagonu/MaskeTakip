using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    //bir class ÇIPLAK kalmamalı interface i olmalıdır.
    public class PttManager : ISupplierService
        //Yeni bir özellik geldiğin kodlara dokunmayacaksın.
        //Yeni bir class oluştur mesela Eczane oda maske dağıtıyor 
    {
        private IApplicantService _applicantService;
        //Burada bir tasarım deseni oluşturulur.
        //PttManager sınıfı başka bir sınıfa ihtiyaç duyar.
        //Fakat ihtiyaç duyulan sınıfı newlemek yerine onun interfaceni çağırıyoruz.
       
        public PttManager(IApplicantService applicantService)  //Consturcotr new yapıldığında çalışır.
        { 
            _applicantService = applicantService;
        }
        public void GiveMask(Person person)
        {
            //PersonManager personManager = new PersonManager();
            //new diyerek bağımlılık oluşturduk bu çok YANLIŞ vatandaş olmayanlar ne olacak? Bağımlılık olmamalı.
            //Bunun için interface kullanılır.
            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + "için maske verildi");
            }
            else
            {
                Console.WriteLine(person.FirstName + " için maske verilemedi");

            }
        }
    }
}
