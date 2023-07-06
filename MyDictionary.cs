using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GenericsTraining
{
    public class MyDictionary<T1,T2>
    {
        T1[] items;
        T2[] keys;
        public MyDictionary()
        {
            items = new T1[0];
            keys = new T2[0];
        }

        public void Add(T1 item,T2 key)
        {
            T1[] tempItems = items;
            T2[] tempKeys = keys;
            items = new T1[items.Length+1];
            keys = new T2[keys.Length+1];
            for (int i = 0; i < tempItems.Length; i++)
            {
                items[i] = tempItems[i];
                keys[i] = tempKeys[i];
            }
            items[items.Length - 1] = item;
            keys[keys.Length-1] = key;

        }
        public void getIndexAt(int index)
        {
            Console.WriteLine("Value: " + items[index]+"\n"+"Key: " + keys[index]);
        }
        public void setIndexAt(int index,T1 item,T2 key) 
        {
            items[index] = item;
            keys[index] = key;
        
        }
        public void getWholeDict()
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine("Value: " + items[i] + "\n" + "Key: " + keys[i]+"\n"+"---------------------");
            }
        }



    }
}
