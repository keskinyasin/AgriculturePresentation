using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrate;
using System;
using System.Linq;

namespace BussinessLayer.Concrete
{
    public class ImageManager : IImageService
    {
        private readonly IImageDal _imageDal;

        public ImageManager(IImageDal imageDal)
        {
            _imageDal = imageDal;
        }
        public void Delete(Image t)
        {
            _imageDal.Delete(t);
        }

        public Image Get(int id)
        {
            return _imageDal.Get(id);
        }

        public List<Image> GetAll()
        {
            return _imageDal.GetAll();
        }

        public void Insert(Image t)
        {
            _imageDal.Insert(t);
        }

        public void Update(Image t)
        {
            _imageDal.Update(t);
        }
    }
}
