using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;

namespace hw
{


// Задание 1 
// Создайте класс Океанариум. Он должен содержать информацию 
// о жителях Океанариума. Создайте классы для каждого жителя 
// Океанариума. Они должны содержать информацию о конкретном 
// морском существе. Реализуйте поддержку итератора для класса
// Океанариум. Протестируйте возможность использования foreach для
// Океанариума.

// Задание 2
// Создайте класс Футбольная Команда. Он должен 
// содержать информацию о игроках футбольной команды. Реализуйте 
// поддержку итератора для класса Футбольная Команда. Протестируйте 
// возможность использования
// foreach для Футбольной Команды.

    public class Oceanarium<T>: IEnumerable<T> where T: class, IWater
    {
       public T[] Array {get; set;}
       int curpos = -1;
    

    public Oceanarium(params T[] array){
        Array = array;
    }


    public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in Array)
            {
                yield return item;
            }
        }

      #region enumerator

    public void Reset()
    {
        curpos = -1;
    }
    public T Current 
    {
        get
        {
            return Array[curpos];
        }
    }

    public bool MoveNext()
    {
        if (curpos < Array.Length - 1)
        {
            curpos++;
            return true;
        }
        else
        {
            Reset();
            return false;
        }

    }
    #endregion enumerator

       // Необобщенная версия GetEnumerator для IEnumerable (для совместимости)
       IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}