using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace XmlBuildDLL.Transversal
{
    class HelperObjConverter<T>
    {
        public static String ToJson(T o)
        {
            return JsonConvert.SerializeObject(o).Replace(":null", ":\"\"");
        }

        public static T FromJson(String json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }

        public static String ObjToJson(T o)
        {
            //return json = new System.Web.JavaScriptSerializer().Serialize(obj);

            return JsonConvert.SerializeObject(o);
        }
    }
}
