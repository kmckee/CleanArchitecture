using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Core.Models;

namespace CleanArchitecture.Core.Contracts
{
    public interface IWidgetRepository
    {
        Widget GetById(int id);
        void Save(Widget widget);
    }
}
