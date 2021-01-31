using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items; //Generic yapılar arka planda bir dizi barındırırlar. Eğer biz bir generik yapı oluşturuyorsak arka planda oluşturacağı bir dizi tanımlamamız gerekiyor. Bu dizi de onun için tanımlandı.
        //constructor
        public MyList()
        {
            items = new T[0]; //Bunu yapmak zorundayız ki new lendiğinde sıfır elemanlı olarak oluştursun. Yoksa NullReferanceException hatası alırız.
        }
        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length+1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;

        }

        public int Length
        {
            get { return items.Length; }
        }

        public T[] Items
        {
            get { return items; }
        }


    }
}
