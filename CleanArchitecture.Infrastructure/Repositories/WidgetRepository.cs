using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Core.Contracts;
using CleanArchitecture.Core.Models;

namespace CleanArchitecture.Infrastructure.Repositories
{
    public class WidgetRepository : IWidgetRepository
    {
        public Widget GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(Widget widget)
        {
            throw new NotImplementedException();
        }
    }
}
