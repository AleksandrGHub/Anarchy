namespace Anarchy
{
    class Catalog
    {
        private Random _random = new Random();
        private List<Patient> _patients = new List<Patient>();

        public Catalog()
        {
            AddPatients();
        }

        public void ShowInfo()
        {
            foreach (var patient in _patients)
            {
                patient.ShowInfo();
            }

            Console.WriteLine();
        }

        public void SortByFullName()
        {
            _patients = (_patients.OrderBy(patient => patient.Surname).ThenBy(patient => patient.Name).ThenBy(patient => patient.Patronymic)).ToList();
        }

        public void SortByAge()
        {
            _patients = (_patients.OrderBy(patient => patient.Age)).ToList();
        }

        public void ShowByDisease()
        {
            Console.Write("Введите заболевание: ");

            string userInput = Console.ReadLine();

            Console.Clear();

            var patients = _patients.Where(patient => patient.Disease == userInput);

            ShowInfo(patients);

            if (patients.Count() == 0)
            {
                Console.WriteLine("Такого заболевания нет в списке.");
            }

            Console.ReadKey();
        }

        private void ShowInfo(IEnumerable<Patient> patients)
        {
            foreach (var patient in patients)
            {
                patient.ShowInfo();
            }

            Console.WriteLine();
        }

        private void AddPatients()
        {
            int numberPatients = 20;
            int minAge = 40;
            int maxAge = 70;

            List<string> surnames = new List<string>() { "Иванов", "Смирнов", "Кузнецов", "Попов", "Васильев", "Петров", "Соколов", "Михайлов", "Новиков", "Федоров" };
            List<string> names = new List<string>() { "Сергей", "Дмитрий", "Андрей", "Алексей", "Максим", "Иван", "Роман", "Евгений", "Михаил", "Артем" };
            List<string> patronymics = new List<string>() { "Васильевич", "Викторович", "Витальевич", "Кириллович", "Константинович", "Леонидович", "Тимофеевич", "Федорович", "Николаевич", "Олегович" };
            List<string> diseases = new List<string>() { "Авитаминоз", "Аллергия", "Амнезия", "Ангина", "Вывих", "Гастрит", "Гипертония", "Радикулит", "Тахикардия", "Фарингит" };

            for (int i = 0; i < numberPatients; i++)
            {
                _patients.Add(new Patient(surnames[_random.Next(surnames.Count)], names[_random.Next(names.Count)], patronymics[_random.Next(patronymics.Count)], _random.Next(minAge, maxAge), diseases[_random.Next(diseases.Count)]));
            }
        }
    }
}