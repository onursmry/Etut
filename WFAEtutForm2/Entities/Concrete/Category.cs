using WFAEtutForm2.Entities.Abstract;

namespace WFAEtutForm2.Entities.Concrete
{
    public class Category:BaseEntity
    {
        public override int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}