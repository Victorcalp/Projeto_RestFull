using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_RestFull.Model.Base
{
    public class BaseEntity
    {
        [Column("id")]
        public long Id { get; set; }
    }
}
