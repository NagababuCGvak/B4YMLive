using Tar.Model;

namespace Tar.Tests.Model
{
    public class Product:IEntity
    {
        public virtual int Id { get; set; }
        public virtual string Name{ get; set; }
    }
}
