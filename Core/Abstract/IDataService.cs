using System.Collections.Generic;
using Core.Models;

namespace Core.Abstract
{
    public interface IDataService
    {
        List<WorkerViewModel> GetWorkers();
    }
}