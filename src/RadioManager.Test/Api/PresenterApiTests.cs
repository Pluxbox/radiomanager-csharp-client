/* 
 * RadioManager
 *
 * RadioManager
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
    ///  Class for testing PresenterApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class PresenterApiTests
    {
        private PresenterApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PresenterApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PresenterApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' PresenterApi
            //Assert.IsInstanceOfType(typeof(PresenterApi), instance, "instance is a PresenterApi");
        }

        /// <summary>
        /// Test CreatePresenter
        /// </summary>
        [Test]
        public void CreatePresenterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PresenterDataInput body = null;
            //var response = instance.CreatePresenter(body);
            //Assert.IsInstanceOf<PostSuccess> (response, "response is PostSuccess");
        }
        /// <summary>
        /// Test DeletePresenterById
        /// </summary>
        [Test]
        public void DeletePresenterByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //var response = instance.DeletePresenterById(id);
            //Assert.IsInstanceOf<Success> (response, "response is Success");
        }
        /// <summary>
        /// Test GetPresenterById
        /// </summary>
        [Test]
        public void GetPresenterByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //long? externalStationId = null;
            //var response = instance.GetPresenterById(id, externalStationId);
            //Assert.IsInstanceOf<PresenterResult> (response, "response is PresenterResult");
        }
        /// <summary>
        /// Test ListPresenters
        /// </summary>
        [Test]
        public void ListPresentersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? page = null;
            //long? programId = null;
            //long? broadcastId = null;
            //long? modelTypeId = null;
            //long? limit = null;
            //string orderBy = null;
            //string orderDirection = null;
            //long? externalStationId = null;
            //var response = instance.ListPresenters(page, programId, broadcastId, modelTypeId, limit, orderBy, orderDirection, externalStationId);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        /// <summary>
        /// Test UpdatePresenterByID
        /// </summary>
        [Test]
        public void UpdatePresenterByIDTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //PresenterDataInput body = null;
            //var response = instance.UpdatePresenterByID(id, body);
            //Assert.IsInstanceOf<Success> (response, "response is Success");
        }
    }

}
