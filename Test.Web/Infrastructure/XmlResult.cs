using System;
using System.IO;
using System.Web.Mvc;
using System.Xml.Serialization;

namespace Test.Web.Infrastructure
{
    /// <summary>
    /// Взято с http://www.dotnetcurry.com/showarticle.aspx?ID=682
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class XmlResult<T> : ActionResult
    {
        private readonly T _data;

        public XmlResult(T data)
        {
            _data = data;
        }

        public override void ExecuteResult(ControllerContext context)
        {
            var httpContext = context.HttpContext;
            httpContext.Response.Buffer = true;
            httpContext.Response.Clear();

            var fileName = DateTime.Now.ToString("ddmmyyyyhhss") + ".xml";
            httpContext.Response.AddHeader("content-disposition", "attachment; filename=" + fileName);
            httpContext.Response.ContentType = "text/xml";

            using (var writer = new StringWriter())
            {
                var xml = new XmlSerializer(typeof(T));
                xml.Serialize(writer, _data);
                httpContext.Response.Write(writer);
            }
        }
    }
}