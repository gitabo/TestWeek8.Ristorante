using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWeek8.Ristorante.Core.Models;
using static TestWeek8.Ristorante.Core.Interfaces.IRepository;

namespace TestWeek8.Ristorante.Core.Interfaces
{
    public interface IRepositoryPiatto : IRepository<Piatto>
    {
    }
}
