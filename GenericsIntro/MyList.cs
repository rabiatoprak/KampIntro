using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //ctor
        //constructor classla aynı isimle açılır
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            //geçici dizinin referansı items ın referansı
            T[] tempArray = items;

            //mevcutta eleman sayın kaçsa 1 artır
            items = new T[items.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            //dizi 0 dan başladığı için length komutunda 1 den saymaya başladığı için -1 yaparız.
            items[items.Length - 1] = item;
        }
    }
}
