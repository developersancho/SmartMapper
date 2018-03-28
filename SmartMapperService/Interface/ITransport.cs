using SmartMapperData.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartMapperService.Interface
{
   public interface ITransport
    {
        IEnumerable<Transport> GetAll();
    }
}
