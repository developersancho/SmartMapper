using SmartMapperData.Context;
using SmartMapperData.Model;
using SmartMapperService.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartMapperService.Service
{
    public class TransportService : ITransport
    {
        private DatabaseContext _context;

        public TransportService(DatabaseContext context)
        {
            _context = context;
        }

        public IEnumerable<Transport> GetAll()
        {
            return _context.Transport;
        }
    }
}
