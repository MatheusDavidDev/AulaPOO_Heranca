namespace Hetanca.classes
{
    public class PessoaFisica : Pessoa // 2 pontos criar a heranca
    {
        public string cpf;
        
        public string rg;

        public bool ValidarCPF(string documento){

            if(documento != ""){
                return true;
            }

            return false;
        }
    }
}