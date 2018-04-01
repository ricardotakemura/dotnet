using System;
using System.Collections.Generic;
using Questao1.Models;

namespace Questao1.Business
{
    public class BusinessFactory
    {

        private static BusinessFactory instance;

        public static BusinessFactory GetInstance() 
        {
            if (instance == null) {
                instance = new BusinessFactory();
            }
            return instance;
        }
        
        public T CreateBusiness<T>() where T: IBusiness, new()
        {
            return new T();
        }
    }
}
