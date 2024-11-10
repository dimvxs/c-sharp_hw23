// Задание 2
// Создайте класс Футбольная Команда. Он должен 
// содержать информацию о игроках футбольной команды. Реализуйте 
// поддержку итератора для класса Футбольная Команда. Протестируйте 
// возможность использования
// foreach для Футбольной Команды.



using System.Collections;

namespace hw{

    public class FootballClub<T>: IEnumerable<T> where T: class
    {
       public T[] Players {get; set;}
       int curpos = -1;
    

    public FootballClub(params T[] array){
        Players = array;
    }


    public IEnumerator<T> GetEnumerator()
        {
            foreach (var player in Players)
            {
                yield return player;
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
            return Players[curpos];
        }
    }

    public bool MoveNext()
    {
        if (curpos < Players.Length - 1)
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