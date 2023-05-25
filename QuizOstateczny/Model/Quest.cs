namespace QuizOstateczny.Model
{
    class Quest
    {
        public int Id_quest { get; set; }

        public string Tresc { get; set; }

        public string Odp1 { get; set; }

        public string Odp2 { get; set; }

        public string Odp3 { get; set; }

        public string Odp4 { get; set; }

        public int Poprawna_odp { get; set; }

        public int Nr_zadania { get; set; }

        public int Grupa { get; set; }

        public int Autor { get; set; }
    }
}
