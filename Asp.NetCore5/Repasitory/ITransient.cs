using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCore5.Repasitory
{
    public interface ITransient
    {
        Guid GetId();
    }

    public class Transient : ITransient
    {
        private Guid _Id;
        public Transient()
        {
            _Id = Guid.NewGuid();
        }
        public Guid GetId()
        {
            return _Id;
        }
    }
}
