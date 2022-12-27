using System.Collections.Generic;

namespace Projeto_RestFull.Data.Converter.Contract
{
    public interface IParser<O, D>
    {
        // "O" de Origem
        //"D" de Destino

        //Vai Receber Origim e vai retornar Destino
        D Parse(O origin);

        List<D> Parse(List<O> origin);
    }
}
