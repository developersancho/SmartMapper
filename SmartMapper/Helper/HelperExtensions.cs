using SmartMapper.Models.Transport;
using SmartMapperCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartMapper.Helper
{
    public class HelperExtensions
    {
        public static List<TransportViewModel> convertJsonToSqliteTransports(List<TransportJsonModel> transportJsonModels)
        {
            if (transportJsonModels != null)
            {
                List<TransportViewModel> result = new List<TransportViewModel>(transportJsonModels.Count());

                foreach (TransportJsonModel jsonTransport in transportJsonModels)
                {
                    result.Add(new TransportViewModel
                    {
                        Code = jsonTransport.code,
                        Name = jsonTransport.name,
                        Neighborhood = jsonTransport.neighborhood,
                        PostCode = jsonTransport.postcode,
                        Address = jsonTransport.address,
                        Town = jsonTransport.town,
                        City = jsonTransport.city,
                        Xcoor = jsonTransport.xCoor,
                        Ycoor = jsonTransport.yCoor,
                        Brand = jsonTransport.type,
                        Type = jsonTransport.type
                    });
                }
                return result;
            }
            else
            {
                return new List<TransportViewModel>();
            }
        }
    }
}
