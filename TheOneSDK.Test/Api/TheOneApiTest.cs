using NUnit.Framework;
using System;
using System.Web;
using System.IO;
using TheOneSDK.Api;
using TheOneSDK.Client;
using TheOneSDK.Model;

namespace TheOneSDK.Test.Api
{
    [TestFixture]
    public class AllApiTest
    {
        private MovieApi movieApi;

        [SetUp]
        public void Init()
        {
            movieApi = new MovieApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
            movieApi = null;
        }

        // <summary>
        /// Test an instance of MovieApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<MovieApi>(movieApi, "instance is a MovieApi");
        }

        [Test]
        public void TestMovieGet()
        {
            try
            {
                var response = movieApi.Get();
            }            
            catch (Exception ex)
            {
                Assert.AreEqual(((ApiException)ex).ErrorCode, 401);
                return;
            }
            Assert.Fail("Call should fail");
        }

        [Test]
        [TestCase("5cd95395de30eff6ebccde57")]
        public void TestMovieId(string movieId)
        {            
            try
            {                
                Id response = movieApi.Id(movieId);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(((ApiException)ex).ErrorCode, 401);
                return;
            }
            Assert.Fail("Call should fail");
        }

        [Test]
        [TestCase("5cd95395de30eff6ebccde57")]
        public void TestMovieQuote(string movieId)
        {
            try
            {
                Quote response = movieApi.Quote(movieId);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(((ApiException)ex).ErrorCode, 401);
                return;
            }
            Assert.Fail("Call should fail");
        }
    }
}
