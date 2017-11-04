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
        private readonly Context _context;

        public WidgetRepository(Context context)
        {
            _context = context;
        }

        public Widget GetById(int id)
        {
            return _context.Widgets.Single(w => w.WidgetId == id);
        }

        public void Save(Widget widget)
        {
            throw new NotImplementedException();
        }
    }
}
