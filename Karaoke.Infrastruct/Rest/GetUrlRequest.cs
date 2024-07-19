using AutoMapper;
using Karaoke.Domain.Enums;
using Karaoke.Domain.Interfaces;
using Karaoke.Domain.Models.Object;
using Karaoke.Domain.Models.Settings;
using Karaoke.Infrastruct.Factory;
using System.Reflection;


namespace Karaoke.Infrastruct.Rest
{
    public class GetUrlRequest : IGetUrlRequest
    {
        private readonly AplicationSettings _settings;
        private readonly IMapper _mapper;
        private ObjectFactory objectFactory;
        public string _url;
        public GetUrlRequest(AplicationSettings settings, IMapper mapper)
        {
            _settings = settings;
            _mapper = mapper;
            objectFactory = new ObjectFactory();
        }

        public string GetUrl(Youtube youtube, string search = "")
        {
            var objectQuery =  objectFactory.GetObjectQuery(youtube, _settings.parametersQuery, search);
            string url = $"{GetUrlHeader(youtube)}{GetUrlBody(objectQuery)}";
            return url;
        }

      
        private string GetUrlHeader(Youtube youtube)
        {
            return $"{_settings.youtubeApi}/{Enum.GetName(youtube)}?";
        }

        private string GetUrlBody(ObjectQuery query) 
        {
            List<string> valores = new List<string>();
            
            foreach (var pi in query.GetType().GetProperties())
            {
                string Prop = pi.Name;

                MethodInfo ac = query.GetType().GetMethod("get_" + Prop);
                ParameterInfo[] pai = query.GetType().GetMethod("get_" + Prop).GetParameters();

                string Valor = ac.Invoke(query, pai).ToString();

                valores.Add($"{Prop}={Valor}");
            }

            return String.Join("&",valores);
        }

    }

 
}
