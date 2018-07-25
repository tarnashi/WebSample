using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Core.Abstract;
using Core.Models;
using Data.DataAccess;

namespace Core.Services
{
    public class DataService : IDataService
    {
        private readonly DataContext _ctx;
        private readonly IMapper _mapper;

        public DataService(IMapper mapper)
        {
            _ctx = new DataContext();
            _mapper = mapper;
        }

        public List<WorkerViewModel> GetWorkers()
        {
            return _ctx.Workers.ProjectTo<WorkerViewModel>(_mapper.ConfigurationProvider).ToList();
        }
    }
}
