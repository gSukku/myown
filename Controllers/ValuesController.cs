using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Sample.Models;
//using System.Linq;
using System.Text.Json;
 using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Sample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<Values> Get()
        {            
            return new Values(){ti_type=12, ti_bu_code="ss"};
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
      //  [HttpPost]
       // public void Post([FromBody] string value)
        //{
          //  string s = "gg";
        //}

         [HttpPost]
        public ActionResult Post([FromBody] object value)
        {
             var myJObject = JObject.Parse(value.ToString());
           // var validator =new ValuesValidator();
          // var str= Newtonsoft.Json.JsonConvert.SerializeObject(value);
           //Type t = typeof(value.ti_id_generic); 
           var json = JToken.Parse("{ ti_type : \"1\",   ti_id_type_generic: \"\",    ti_id_generic: \"\",    ti_id_type_specific: \"\",    ti_id_specific: \"\",    ti_bu_code: \"\",    ti_bu_type: \"\",    ti_api_call_time: [{        suku:\"0\",        vijaya:\"9\"    },{        bala:\"0\",        raju:\"7\"    }]}");
           
           var fieldsCollector = new JsonFieldsCollector(json);
           var fields = fieldsCollector.GetAllFields();
           IList<string> keylist= new List<string>();
           foreach (var field in fields)
           keylist.Add(field.Key.Contains('.')==true? field.Key.Split('.')[1]:field.Key);
           
var a= keylist;
            //  var S =value.FindTokens("AA");
            //  var S1 =value.FindTokens("ti_id_specific");
            //  var S2=value.FindTokens("vijaya");

        //     IList<string> keys = value.Properties().Select(p => p.Name).ToList();
        //  //   Dictionary<string, string> dictObj = value.ToObject<Dictionary<string, string>>();
        //    var myDictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>("{ ti_type : \"1\",   ti_id_type_generic: \"\",    ti_id_generic: \"\",    ti_id_type_specific: \"\",    ti_id_specific: \"\",    ti_bu_code: \"\",    ti_bu_type: \"\",    ti_api_call_time: [{        suku:\"0\",        vijaya:\"9\"    }]}");
        //      foreach(var a in value.Properties())
        //      {
        //       string ss= a.Name;
        //      }
            
            // foreach (PropertyInfo prop in typeof(value).GetProperties())
            // {
            //     Console.WriteLine(prop.Name);
            // }
           
           
            
           // var fields = fieldsCollector.GetAllFields();

            //var results =  validator.Validate(value);
            //return !results.IsValid  
            //   ? Ok(new { code = -1, data = new List<string>(), msg = results.Errors.FirstOrDefault().ErrorMessage })  
              // : Ok(new { code = 0, data = new List<string> { "v1", "v2" }, msg = "" });
           return null;
        }


        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
