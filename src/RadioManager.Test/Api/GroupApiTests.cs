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
    ///  Class for testing GroupApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class GroupApiTests
    {
        private GroupApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new GroupApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of GroupApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' GroupApi
            //Assert.IsInstanceOfType(typeof(GroupApi), instance, "instance is a GroupApi");
        }

        /// <summary>
        /// Test GetGroupById
        /// </summary>
        [Test]
        public void GetGroupByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //long? externalStationId = null;
            //var response = instance.GetGroupById(id, externalStationId);
            //Assert.IsInstanceOf<GroupResult> (response, "response is GroupResult");
        }
        /// <summary>
        /// Test ListGroups
        /// </summary>
        [Test]
        public void ListGroupsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? broadcastId = null;
            //long? programId = null;
            //long? userId = null;
            //long? page = null;
            //long? limit = null;
            //string orderBy = null;
            //string orderDirection = null;
            //long? externalStationId = null;
            //var response = instance.ListGroups(broadcastId, programId, userId, page, limit, orderBy, orderDirection, externalStationId);
            //Assert.IsInstanceOf<InlineResponse2007> (response, "response is InlineResponse2007");
        }
    }

}
