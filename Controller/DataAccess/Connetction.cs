using BeautyBrows.Model.ADO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyBrows.Controller.DataAccess
{
    internal static class Connetction
    {
        public static BeautyBrowsEntities BrowsEntities = new BeautyBrowsEntities();
    }
}
