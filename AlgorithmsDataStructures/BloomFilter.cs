using System.Collections;
using System;
using System.IO;

namespace AlgorithmsDataStructures
{
    public class BloomFilter
    {
        public int filter_len;
        public BitArray bits;

        public BloomFilter(int f_len)
        {
            filter_len = f_len;
            bits = new BitArray(filter_len);
            // создаём битовый массив длиной f_len ...
        }

        // хэш-функции
        public int Hash1(string str1)
        {
            // 17
            int result = 0;
            for (int i = 0; i < str1.Length; i++)
            {
                int code = (int)str1[i];
                code += result * 17;
                result = code;
            }
            if (result < 0) result *= -1;
            return result % filter_len;
            // реализация ...
            return 0;
        }
        public int Hash2(string str1)
        {
            // 223
            int result = 0;
            for (int i = 0; i < str1.Length; i++)
            {
                int code = (int)str1[i];
                code += result * 223;
                result = code;
            }
            if (result < 0) result *= -1;
            return result % filter_len;
            // реализация ...
            return 0;
        }

        public void Add(string str1)
        {
            bits.Set(Hash1(str1), true);
            bits.Set(Hash2(str1), true);
            // добавляем строку str1 в фильтр
        }

        public bool IsValue(string str1)
        {
            if (bits.Get(Hash1(str1)) && bits.Get(Hash2(str1))) return true;
            // проверка, имеется ли строка str1 в фильтре
            return false;
        }
    }
}