using System;

using Xunit;
using static Utf8Json.JsonSerializer;

namespace SunamoJson.Tests
{
    public class JavaScriptSerializationTests
    {
        //[Fact]
        //public void SystemTextJsonTest()
        //{
        //    JavascriptSerialization js = new JavascriptSerialization(SerializationLibrary.SystemTextJson);

        //    dynamic d = js.Deserialize<ExternalLoginResult>(TestData.flatJson);
        //    Assert.Equal(TestData.flatJsonSc, d.Sc);
        //    var serialized = js.Serialize(d);
        //    Assert.Equal(TestData.flatJson, serialized);
        //}

        [Fact]
        public void Utf8JsonTest()
        {
            var js = new JavascriptSerialization(SerializationLibrary.Utf8Json);

            /*
            Deserialize without define type is not possible in Utf8Json
            Fortunately there are many tool to help with it:
            https://json2csharp.com/
            https://app.quicktype.io/
            https://www.google.com/search?q=c%23+type+from+json etc

                        */
            var input = "{\"price\":\"450000\", \"position\":\"0\", \"id\": \"18787720\", \"stitky\":\"servisní knížka, bluetooth, satelitní navigace\"}";
            var o = js.Deserialize<Root>(input);
        }

        //[Fact]
        //public void JsonDanielCrennaTest()
        //{
        //    JavascriptSerialization js = new JavascriptSerialization(SerializationLibrary.JsonDanielCrenna);

        //    dynamic d = js.Deserialize<ExternalLoginResult>(TestData.flatJson);
        //    Assert.Equal(TestData.flatJsonSc, d.Sc);
        //    var d2 = new ExternalLoginResult { IdUser = 1, Sc = "au1skm2qhjbwhmu4z0qwcpiv" };

        //    var serialized = string.Empty;

        //    // Must use type parameter, otherwise return empty element
        //    serialized = js.Serialize<ExternalLoginResult>(d2);
        //     //serialized = JsonParser.Serialize(d2);
        //    Assert.Equal(TestData.flatJson, serialized);
        //}
    }

    /// <summary>
    /// Must be public, otherwise 
    /// 'Type 'Utf8Json.Formatters.JsonDataDotFormatter2' from assembly 'Utf8Json.Resolvers.DynamicObjectResolverAllowPrivateFalseExcludeNullFalseNameMutateOriginal, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null' is attempting to implement an inaccessible interface.'
    /// </summary>
    public class Root
    {
        /// <summary>
        /// is working also with public variables
        /// </summary>
        public string price = string.Empty;
        public string position { get; set; }
        public string id { get; set; }
        public string stitky { get; set; }

    }

}
