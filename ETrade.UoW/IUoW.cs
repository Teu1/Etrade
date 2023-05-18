using ETrade.Rep.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.UoW
{
    public interface IUoW
    {
        public IFoodRepos foodRepos { get; }
        public ICatRepos catRepos { get; }
        public IOrderDetailRepos orderDetailRepos { get; }
        public IOrderRepos orderRepos { get; }
        public IUserRepos userRepos { get; }
        public IPropertiesRepos propertiesRepos { get; }
        void Commit();

    }
}