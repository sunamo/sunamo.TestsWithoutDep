using SunamoExceptions;
using System;
using System.IO;
using Xunit;

namespace SunamoMime.Tests
{
    public class SunamoMimeHelperTests
    {
        [Fact]
        public void FileTypeTests()
        {
            

            var f = @"d:\_Test\sunamo\win\Helpers\MImeHelper\GetMimeFromFile\Real";
            //application/octet-stream>
            //Assert.Equal(string.Empty, SunamoMimeHelper.FileType(File.ReadAllBytes(f + AllExtensions.jpg)));
            Assert.Equal(string.Empty, SunamoMimeHelper.FileType(File.ReadAllBytes( f + AllExtensions.webp)));
            // 
            
        }
    }
}
