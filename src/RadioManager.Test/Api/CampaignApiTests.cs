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
    ///  Class for testing CampaignApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CampaignApiTests
    {
        private CampaignApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CampaignApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CampaignApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' CampaignApi
            //Assert.IsInstanceOfType(typeof(CampaignApi), instance, "instance is a CampaignApi");
        }

        
        /// <summary>
        /// Test CreateCampaign
        /// </summary>
        [Test]
        public void CreateCampaignTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CampaignDataInput data = null;
            //var response = instance.CreateCampaign(data);
            //Assert.IsInstanceOf<PostSuccess> (response, "response is PostSuccess");
        }
        
        /// <summary>
        /// Test DeleteCampaignById
        /// </summary>
        [Test]
        public void DeleteCampaignByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //var response = instance.DeleteCampaignById(id);
            //Assert.IsInstanceOf<Success> (response, "response is Success");
        }
        
        /// <summary>
        /// Test GetCampaignById
        /// </summary>
        [Test]
        public void GetCampaignByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //long? externalStationId = null;
            //var response = instance.GetCampaignById(id, externalStationId);
            //Assert.IsInstanceOf<CampaignResult> (response, "response is CampaignResult");
        }
        
        /// <summary>
        /// Test ListCampaigns
        /// </summary>
        [Test]
        public void ListCampaignsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? page = null;
            //long? modelTypeId = null;
            //long? itemId = null;
            //DateTime? startMin = null;
            //DateTime? startMax = null;
            //long? externalStationId = null;
            //var response = instance.ListCampaigns(page, modelTypeId, itemId, startMin, startMax, externalStationId);
            //Assert.IsInstanceOf<CampaignResults> (response, "response is CampaignResults");
        }
        
        /// <summary>
        /// Test UpdateCampaignByID
        /// </summary>
        [Test]
        public void UpdateCampaignByIDTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //CampaignDataInput data = null;
            //var response = instance.UpdateCampaignByID(id, data);
            //Assert.IsInstanceOf<Success> (response, "response is Success");
        }
        
    }

}
