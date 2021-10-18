using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCore5.factory
{
    public interface ICashAdapter
    {
        void Add<T>(T input);
        void Get<T>(string key);
    }
    public class InDistributedCash : ICashAdapter
    {
        public void Add<T>(T input)
        {
            throw new NotImplementedException();
        }

        public void Get<T>(string key)
        {
            throw new NotImplementedException();
        }
    }
    public class InMemoryCach : ICashAdapter
    {
        public void Add<T>(T input)
        {
            throw new NotImplementedException();
        }

        public void Get<T>(string key)
        {
            throw new NotImplementedException();
        }
    }
}
