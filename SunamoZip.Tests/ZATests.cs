﻿using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using sunamo.Essential;

namespace SunamoZip.Tests
{
    [TestClass]
    public class ZATests
    {
        [TestMethod]
        public void CreateArchiveTest()
        {
            //ThisApp.Name = "sunamo.Tests";
            //ThisApp.Project = "SunamoYaml.Tests";

            //string folder = @"c:\Program Files (x86)\Microsoft Visual Studio\";

            //var z = ZA.zip;
            //var files = FS.GetFiles(folder, "Class.cs", SearchOption.AllDirectories);
            //string saveTo = @"d:\_Test\sunamo\SunamoZip\1.zip";
            //FS.CreateUpfoldersPsysicallyUnlessThere(saveTo);
            //z.CreateArchive(folder, files, saveTo);
        }

        [TestMethod]
        public void CreateArchiveTest()
        {
            var folder = @"d:\_Test\sunamoWithoutDepSunamoZip\SunamoZip\ToZip\";

            var z = ZA.zip;
            var files = FS.GetFiles(folder, "*.txt", SearchOption.AllDirectories);
            z.CreateArchive(folder, files, @"d:\_Test\sunamoWithoutDepSunamoZip\1.zip");
        }
    }
}