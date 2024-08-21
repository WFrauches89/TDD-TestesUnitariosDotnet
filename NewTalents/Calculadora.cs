using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewTalents
{
    public class Calculadora
    {
        private List<string> memoryList;
        private DateTime data;

        public Calculadora(DateTime data)
        {
            memoryList = new List<string>();
            this.data = data;
        }
        public int somar(int num1, int num2)
        {
            var result = num1 + num2;
            memoryListInsert(result);
            return result;
        }

        public int subtrair(int num1, int num2)
        {
            var result = num1 - num2;
            memoryListInsert(result);
            return result;
        }
        public int multiplicar(int num1, int num2)
        {
            var result = num1 * num2;
            memoryListInsert(result);
            return result;
        }
        public int dividir(int num1, int num2)
        {
            var result = num1 / num2;
            memoryListInsert(result);
            return result;
        }
        public List<string> memory()
        {
            memoryList.RemoveRange(3, memoryList.Count - 3);
            return memoryList;
        }

        private void memoryListInsert(int result)
        {
            memoryList.Insert(0, "Resultado: " + result + " - Data: " + data);
        }
    }
}