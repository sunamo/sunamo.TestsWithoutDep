using System;
using Xunit;

namespace SunamoVcf.Tests
{
    public class VcfHelperTests
    {
        [Fact]
        public void VcfHelperParseTest()
        {
            var l = VcfHelper.Parse(@"d:\_Test\sunamo\SunamoVcf\contacts.vcf");

            int i = 0;
        }
    }
}
