using PricingTool.BLL.DTO;
using PricingTool.DAL.Context;
using PricingTool.DAL.Model;
using PricingTool.DAL.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace PricingTool.BLL
{
    public class Class1
    {
        private UnitOfWork mDb { get; set; }
        public Class1(UnitOfWork db = null)
        {
            mDb = db == null ? new UnitOfWork() : db;
        }
        public List<ClassifierDTO> GetAllClassifier()
        {
           // var list = db.Classifier.GetAll().ToList();
            var list = mDb.ClassifierType.GetAll();
            var list1 = list.ToList();
            List<ClassifierDTO> classifierDTOs = new List<ClassifierDTO>();
            for (int i = 0; i < list1.Count(); i++)
            {
                classifierDTOs.Add(new ClassifierDTO { Id = list1[i].Id, Name = list1[i].Name });
            }
            return classifierDTOs;
        }
    }
}
