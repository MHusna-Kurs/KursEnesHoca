using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.Concrete;
using EntityLayer;

namespace BusinessLayer
{
    class FirmaManager : IFirmaServis
    {
        GenericRepository<Firma> genericRepository;

        public FirmaManager(GenericRepository<Firma> genericRepository)
        {
            this.genericRepository = genericRepository;
        }

        public void firmaEkle(Firma firma)
        {
            genericRepository.insert(firma);
        }

        public void firmaGuncelle(Firma firma)
        {
            genericRepository.update(firma);
        }

        public List<Firma> firmaListele()
        {
            return genericRepository.list();
        }

        public void firmaSil(Firma firma)
        {
            genericRepository.delete(firma);
        }
    }
}
