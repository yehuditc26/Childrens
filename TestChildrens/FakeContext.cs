using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestChildrens
{
    internal class FakeContext
    {
        public List<Children> Childrens { get; set; }

        public List<KinderGarten> KinderGartens { get; set; }

        public List<Ticher> Tichers { get; set; }
        public DataContext()
        {
            Childrens = new List<Children> { new Children { Id = 1, Name = "yosi" }, new Children { Id = 2, Name = "chaim" } };

            KinderGartens = new List<KinderGarten> { new KinderGarten { Id = 1, Name = "smallChildrens" }, new KinderGarten { Id = 2, Name = "MediumChikdrens" } };

            Tichers = new List<Ticher> { new Ticher { Id = 1, Name = "shoshi" } };

        }
    }
}
