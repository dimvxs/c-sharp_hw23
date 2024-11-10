// Задание 3 Создайте класс Кафе. Он должен содержать информацию о работниках кафе.
// Реализуйте поддержку итератора для класса Кафе. Протестируйте возможность использования foreach для Кафе.





using System.Collections;

namespace hw{

    public class Cafe<T>: IEnumerable<T> where T: class
    {
       public T[] Workers {get; set;}
       int curpos = -1;
    

    public Cafe(params T[] array){
        Workers = array;
    }


    public IEnumerator<T> GetEnumerator()
        {
            foreach (var worker in Workers)
            {
                yield return worker;
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
            return Workers[curpos];
        }
    }

    public bool MoveNext()
    {
        if (curpos < Workers.Length - 1)
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

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
        #endregion enumerator

    }
}