namespace ExercicioMod2_Semana4.classes
{
    public class FichaInscrição
    {
        public string Nome { get; set; }
        public string Curso { get; set; }
        public int Idade { get; set; }
        public string Escolaridade { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public decimal ValorDoCurso { get; set; }
        public decimal ValorDesconto { get; set; }
        public decimal ValorMulta { get; set; }

        public FichaInscrição(string Nome, string Curso, int Idade, string Escolaridade, DateTime DataNascimento, decimal ValorCurso, decimal ValorDesconto, decimal ValorMulta)
        {
            this.Nome = Nome;
            this.Curso = Curso;
            this.Idade = CalculdarIdade();
            this.Escolaridade = Escolaridade;
            this.DataDeNascimento = DataDeNascimento;
            this.ValorDoCurso = ValorDoCurso;
            this.ValorDesconto = ValorDesconto;
            this.ValorMulta = ValorMulta;
        }


        private CalculdarIdade(DateTime DataDeNascimento)
        {
            int idade = 0;
            idade = DateTime.Today.year - DataDeNascimento.Year;
            if (DateTime.Today.DayofYear < DataDeNascimento.DayofYear)
            {
                idade -= 1;
            }
            return idade;
        }
    }
}

