/* 
 * The One Api
 *
 * API for the-one-api.dev
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using TheOneApi.Api;
using TheOneApi.Model;
using TheOneApi.Client;
using System.Reflection;

namespace TheOneApi.Test
{
    /// <summary>
    ///  Class for testing Id
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class IdTests
    {
        private Id instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Id();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Id
        /// </summary>
        [Test]
        public void IdInstanceTest()
        {
            Assert.IsInstanceOf<Id> (instance, "instance is a Id");
        }

        /// <summary>
        /// Test the property 'Docs'
        /// </summary>
        [Test]
        public void DocsTest()
        {
            // TODO: unit test for the property 'Docs'
        }
        /// <summary>
        /// Test the property 'Limit'
        /// </summary>
        [Test]
        public void LimitTest()
        {
            // TODO: unit test for the property 'Limit'
        }
        /// <summary>
        /// Test the property 'Offset'
        /// </summary>
        [Test]
        public void OffsetTest()
        {
            // TODO: unit test for the property 'Offset'
        }
        /// <summary>
        /// Test the property 'Page'
        /// </summary>
        [Test]
        public void PageTest()
        {
            // TODO: unit test for the property 'Page'
        }
        /// <summary>
        /// Test the property 'Pages'
        /// </summary>
        [Test]
        public void PagesTest()
        {
            // TODO: unit test for the property 'Pages'
        }
        /// <summary>
        /// Test the property 'Total'
        /// </summary>
        [Test]
        public void TotalTest()
        {
            // TODO: unit test for the property 'Total'
        }

    }

}
