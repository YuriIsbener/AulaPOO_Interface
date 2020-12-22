namespace POO_Interfaces.Classes
{
    public interface ICarrinho
    {
        //CRUD

        //Create
        void Cadastrar(Produto produto);

        //Read
        void Listar();

        //Update
        void Alterar(int cod, Produto produto);

        //Delete
        void Deletar(Produto produto);
    }
}