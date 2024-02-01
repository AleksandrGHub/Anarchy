namespace Anarchy
{
    class Patient
    {
        public Patient(string surname, string name, string patronymic, int age, string disease)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            Age = age;
            Disease = disease;
        }

        public int Age { get; private set; }
        public string Surname { get; private set; }
        public string Name { get; private set; }
        public string Patronymic { get; private set; }
        public string Disease { get; private set; }

        public void ShowInfo()
        {
            Console.WriteLine($"{Surname} {Name} {Patronymic} \tвозраст: {Age}\tзаболевание: {Disease}");
        }
    }
}