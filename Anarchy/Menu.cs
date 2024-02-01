namespace Anarchy
{
    class Menu
    {
        private const string SortByFullNameCommand = "ФИО";
        private const string SortByAgeCommand = "Возраст";
        private const string ShowByDiseaseCommand = "Заболевание";
        private const string ExitCommand = "Выход";

        private Catalog _catalog = new Catalog();

        public void Work()
        {
            string userInput;

            do
            {
                Console.Clear();
                ShowInfo();
                _catalog.ShowInfo();

                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case SortByFullNameCommand:
                        _catalog.SortByFullName();
                        break;

                    case SortByAgeCommand:
                        _catalog.SortByAge();
                        break;

                    case ShowByDiseaseCommand:
                        _catalog.ShowByDisease();
                        break;
                }
            }
            while (ExitCommand == userInput == false);
        }

        private void ShowInfo()
        {
            Console.WriteLine($"******************* Команды меню *******************\nСортировать каталог по ФИО, команда: {SortByFullNameCommand}" +
                $"\nСортировать каталог по возрасту, команда: {SortByAgeCommand}\nВывести каталог по заболеванию, команда: {ShowByDiseaseCommand}\nДля выхода введите команду: {ExitCommand}\n");
        }
    }
}