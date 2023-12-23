using Microsoft.Extensions.Logging;
using System.Formats.Asn1;
using System.Globalization;
using System.Reflection.PortableExecutable;

namespace Childrens
{
    public class DataContext
    {
        public List<Children> Childrens { get; set; }

        public List<KinderGarten> KinderGartens { get; set; }

        public List<Ticher> Tichers { get; set; }
        public DataContext()
        {
            //using (var reader = new StreamReader("data.csv"))

            //using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            //{
            //    Childrens = csv.GetRecords<Children>().ToList();
            //}
            Childrens = new List<Children> { new Children { Id = 1, Name = "yosi" }, new Children { Id = 2, Name = "chaim" } };

            KinderGartens = new List<KinderGarten> { new KinderGarten { Id = 1, Name = "smallChildrens" }, new KinderGarten { Id = 2, Name = "MediumChikdrens" } };

            Tichers = new List<Ticher> { new Ticher { Id = 1, Name = "shoshi" } };

        }
    }
}
