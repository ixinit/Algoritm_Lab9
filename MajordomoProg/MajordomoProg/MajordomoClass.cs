using System;

namespace MajordomoProg
{
   

    class MajordomoClass
    {
        int Knights;
        //Проверка данных
        public bool Put(string _Knights)  
        {
            bool tmp;
            tmp = Int32.TryParse(_Knights, out Knights);
            return tmp & (Knights > 0);
        }
        //Формула счёта числа возможной рассадки без врагов
        private int A(int k) 
        {
            if (k > 2)//если число больше 2 тогда
            {
                k = k - 1;//k-1
                return 2 * (2 * k - 1) * (k * A(k) + B(k)) + 2 * C(k);//данная формула  вызывает саму себя пока условие выполняется т.к если условие не выполняется даётся конечное значение
            }
            else
                return 2;// верни двойку (данное число минимальное условие выполнения формулы)    
        }
        //число способо прои которой кол-во врагов = 1
        private int B(int k)
        {
            if (k > 2)//если число больше 2 тогда
            {
                k = k - 1;//k-1
                return 2 * (k + 1) * (2 * k * A(k) + B(k));// тоже самое что и A только считаем B
            }
            else
                return 0;
        }
        //число способов при котором есть 2 пары враждущих соседей 
        private int C(int k)
        {
            if (k > 2)//если число больше 2 тогда
            {
                k = k - 1;//k-1
                return 2 * (k + 1) * (k * A(k) + B(k));// тоже самое что и A только считаем C
            }
            else
                return 4;
        }
        //функция возврата числа А
        public string Get()
        {
            return A(Knights).ToString();//верни а в строку
        }
    }
}