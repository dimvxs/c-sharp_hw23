// See https://aka.ms/new-console-template for more information
// Задание 1 
// Создайте класс Океанариум. Он должен содержать информацию 
// о жителях Океанариума. Создайте классы для каждого жителя 
// Океанариума. Они должны содержать информацию о конкретном 
// морском существе. Реализуйте поддержку итератора для класса
// Океанариум. Протестируйте возможность использования foreach для
// Океанариума.


using hw;

Oceanarium<Fish> oceanarium = new Oceanarium<Fish>(new Fish(), new Fish(), new Fish());
    foreach (var fish in oceanarium)
            {
                 Console.WriteLine($"Name: {fish.Name}, Size: {fish.Size}m, Weight: {fish.Weight}kg, Predator: {fish.Predator}");
            }



            FootballClub<Player> club = new FootballClub<Player>(new Player(), new Player(), new Player());
                foreach (var player in club)
            {
                 Console.WriteLine($"Name: {player.Name}, Surname: {player.Surname}, Number: {player.Number}, Description: {player.Description},  Salary: {player.Salary}");
            }



              Cafe<Worker> cafe = new Cafe<Worker>(new Worker(), new Worker(), new Worker());
                foreach (var worker in cafe)
            {
                 Console.WriteLine($"Name: {worker.Name}, Surname: {worker.Surname}, Description: {worker.Description}, Salary: {worker.Salary}");
            }