/* 
 * RadioManager
 *
 * This OpenAPI 3 Document describes the functionality of the API v2 of RadioManager. Note that no rights can be derived from this Document and the true functionality of the API might differ.
 *
 * OpenAPI spec version: 2.0
 * Contact: support@pluxbox.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using RadioManager.Client;
using RadioManager.Api;
using RadioManager.Model;

namespace RadioManager.Test
{
    /// <summary>
    ///  Class for testing VisualSlideApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class VisualSlideApiTests
    {
        private VisualSlideApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new VisualSlideApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of VisualSlideApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' VisualSlideApi
            //Assert.IsInstanceOfType(typeof(VisualSlideApi), instance, "instance is a VisualSlideApi");
        }

        /// <summary>
        /// Test GetVisualSlide
        /// </summary>
        [Test]
        public void GetVisualSlideTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetVisualSlide();
            //Assert.IsInstanceOf<VisualResult> (response, "response is VisualResult");
        }
    }

}
