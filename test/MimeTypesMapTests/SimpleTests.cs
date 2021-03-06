﻿using HeyRed.Mime;
using Xunit;

namespace MimeTypesMapTests
{
    public class SimpleTests
    {
        [Fact]
        public void GetMimeTypeByFileName()
        {
            var mime = MimeTypesMap.GetMimeType("test.jpeg");
            Assert.Equal("image/jpeg", mime);
        }

        [Fact]
        public void GetMimeTypeByExtension()
        {
            var mime = MimeTypesMap.GetMimeType("jpeg");
            Assert.Equal("image/jpeg", mime);
        }

        [Fact]
        public void GetExtension()
        {
            var ext = MimeTypesMap.GetExtension("image/jpeg");
            Assert.Equal("jpeg", ext);
        }
        
        [Fact]
        public void AddOrUpdate()
        {
            var ext = "ext";
            var mimeToAdd = "test/ext";

            MimeTypesMap.AddOrUpdate(mimeToAdd, ext);
            var mimeResult = MimeTypesMap.GetMimeType("file.ext");

            Assert.Equal(mimeToAdd, mimeResult);
        }
    }
}
