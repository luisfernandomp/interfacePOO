namespace interfaces
{
    public interface ICarrinho
    {
         // Tem somente Métodos
         // C - Create, R - Read, U - Update, D - Delete

         void Ler ();
         void Adicionar (Produto _produto);
         void Remover (Produto _produto);
         void Alterar (int _codigo, Produto _produtoAlterado);

    }
}