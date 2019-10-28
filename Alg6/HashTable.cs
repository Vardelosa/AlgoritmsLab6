using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alg6
{
    class HashTable<T>
    {
        public HashTable()
        {
            values = new T[20];
        }
        public HashTable(int size)
        {
            values = new T[size];
            for(int i = 0; i<size;i++)
            {
                values[i] = default(T);
            }
        }
        public int size = 0;
        private T[] values;
        private int key;
        public bool Count()
        {
            double refer = 0;
            refer = (size / values.Length) * 100;
            if(refer>70.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void Resize(int max)
        {
            T[] temp = new T[max];
            for (int i = 0; i < values.Length; i++)
                temp[i] = values[i];
            values = temp;
        }
        public void Add(string key, T value)
        {
            if(Count())
            {
                Resize(10);
            }
            int index = hash(key) % values.Length;
            values[index] = value;
            size++;
        }
        public void Delete(string key)
        {
            int index = hash(key) % values.Length;
            values[index] = default;
        }
        public T Search(string key)
        {
           int index = hash(key) % values.Length;
            if (values[index].Equals(default(T)))
            {
                Console.WriteLine("There is no such element.\n");
                return default;
            }
            else
            {
                Console.WriteLine($"Here is your element: {values[index].ToString()}");
                return values[index];
            }
        }
        public int hash(string key)
        {
            int number = 1311;
            int sum = 0;
            char[] key_ar = key.ToCharArray();
            for (int i = 0; i < key_ar.Length; i++)
            {
                sum +=(number^i)*key_ar[i];
            }
            return sum;
            
        }
    }
}
