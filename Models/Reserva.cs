
namespace DesafioProjetoHospedagem.Models

{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Reserva(Suite suite) 
        {
            this.Suite = suite;
   
        }
                public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
    
            if (hospedes.Count<=Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("Número de hospedes acima da capacidade do quarto");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes(List<Pessoa> hospedes)
        {
            int quant = hospedes.Count;
            return quant;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = DiasReservados*Suite.ValorDiaria;
            
            if (DiasReservados >= 10)
            {
                valor = valor - (valor * 10/100);
            }

            return valor;
        }
    }
}
