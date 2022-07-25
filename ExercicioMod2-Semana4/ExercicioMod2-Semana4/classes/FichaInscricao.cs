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
            this.Idade = Idade;
            this.Escolaridade = Escolaridade;
            this.DataDeNascimento = DataDeNascimento;
            this.ValorDoCurso = ValorDoCurso;
            this.ValorDesconto = ValorDesconto;
            this.ValorMulta = ValorMulta;
        }

        /*Criar método privado CalculdarIdade na FichaInscricao
        Método deve ser privado e deve calcular a idade da pessoa.
Método deve ser executado no construtor ao receber a Data Nascimento*/
        CalculdarIdade() { }
    }
}

