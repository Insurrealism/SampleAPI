using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Pertamina.PRIME.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pertamina.PRIME.Repositories.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class, new()
    {
        protected readonly IMapper _mapper;
        protected readonly ApplicationContext _context;
        protected readonly DbSet<T> _entity;

        public BaseRepository(ApplicationContext context, IMapper mapper)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _entity = _context.Set<T>();
        }
    }
}
