using System;
using System.Collections.Generic;
using Questao2.Models;

namespace Questao2.Business
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
