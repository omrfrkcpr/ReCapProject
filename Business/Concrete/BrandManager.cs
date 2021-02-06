using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFrameWork;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public BrandManager(EfBrandDal efBrandDal)
        {
        }

        public void Add(Brand brand)
        {
            if (brand.BrandName.Length > 2)
            {
                _brandDal.Add(brand);
                Console.WriteLine(brand.BrandName + "sisteme eklendi");
            }
            else
            {
                Console.WriteLine("[Hata] Araba marka ismi minimum ik(2) karakterden oluşmalıdır. Lütfen tekrar marka ismi giriniz. Girdiğiniz marka:" + brand.BrandName );
            }
        }

        public void Delete(Brand brand)
        {
            _brandDal.Delete();
            Console.WriteLine("Marka sistemden silinmiştir");
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public Brand GetById(int id)
        {
            return _brandDal.Get(c => c.BrandId == id);
        }

        public void Update(Brand brand)
        {
            if (brand.BrandName.Length >= 2)
            {
                _brandDal.Update(brand);
                Console.WriteLine("Marka başarıyla Güncellendi.");
            }
            else
            {
                Console.WriteLine("[HATA] Lütfen marka isminin uzunluğunu 1 karakterden fazla giriniz. Girdiğiniz marka ismi :" + brand.BrandName);
            }
        }
    }
}
