namespace Hetanca.classes
{
    //Com : seguido do nome da superclasse, uilizamos a heranca
    public class PessoaJuridica : Pessoa
    {
        public string cnpj;

        public string inscricaoEstadual;

        public bool ValidarCNPJ(string documento){

            if(documento != ""){
                return true;
            }

            return false;
        }
    }
}