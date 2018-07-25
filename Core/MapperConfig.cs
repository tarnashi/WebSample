using AutoMapper;
using Data;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Models;
using Data.Entities;

namespace Core
{
    public class MapperConfig
    {
        public static MapperConfiguration CreateConfiguration()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Worker, WorkerViewModel>().ReverseMap();
            });

            return config;
        }
    }
}
