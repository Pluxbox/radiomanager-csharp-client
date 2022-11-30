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
    ///  Class for testing ItemApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ItemApiTests
    {
        private ItemApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ItemApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ItemApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ItemApi
            //Assert.IsInstanceOfType(typeof(ItemApi), instance, "instance is a ItemApi");
        }

        /// <summary>
        /// Test CreateItem
        /// </summary>
        [Test]
        public void CreateItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ItemDataInput body = null;
            //var response = instance.CreateItem(body);
            //Assert.IsInstanceOf<InlineResponse2002> (response, "response is InlineResponse2002");
        }
        /// <summary>
        /// Test CurrentItemPostStructure
        /// </summary>
        [Test]
        public void CurrentItemPostStructureTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ImportItem body = null;
            //var response = instance.CurrentItemPostStructure(body);
            //Assert.IsInstanceOf<ItemResult> (response, "response is ItemResult");
        }
        /// <summary>
        /// Test CurrentItemPostTiming
        /// </summary>
        [Test]
        public void CurrentItemPostTimingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ImportItem body = null;
            //var response = instance.CurrentItemPostTiming(body);
            //Assert.IsInstanceOf<ItemResult> (response, "response is ItemResult");
        }
        /// <summary>
        /// Test DeleteItemById
        /// </summary>
        [Test]
        public void DeleteItemByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //instance.DeleteItemById(id);
            
        }
        /// <summary>
        /// Test GetCurrentItem
        /// </summary>
        [Test]
        public void GetCurrentItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? lastplayed = null;
            //var response = instance.GetCurrentItem(lastplayed);
            //Assert.IsInstanceOf<ItemResult> (response, "response is ItemResult");
        }
        /// <summary>
        /// Test GetItemById
        /// </summary>
        [Test]
        public void GetItemByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //long? externalStationId = null;
            //var response = instance.GetItemById(id, externalStationId);
            //Assert.IsInstanceOf<ItemResult> (response, "response is ItemResult");
        }
        /// <summary>
        /// Test ListItems
        /// </summary>
        [Test]
        public void ListItemsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? blockId = null;
            //long? broadcastId = null;
            //long? modelTypeId = null;
            //long? tagId = null;
            //long? campaignId = null;
            //long? contactId = null;
            //long? programDraftId = null;
            //long? userDraftId = null;
            //long? stationDraftId = null;
            //long? programId = null;
            //string externalId = null;
            //int? durationMin = null;
            //int? durationMax = null;
            //string status = null;
            //DateTime? startMin = null;
            //DateTime? startMax = null;
            //long? page = null;
            //long? limit = null;
            //string orderBy = null;
            //string orderDirection = null;
            //long? externalStationId = null;
            //var response = instance.ListItems(blockId, broadcastId, modelTypeId, tagId, campaignId, contactId, programDraftId, userDraftId, stationDraftId, programId, externalId, durationMin, durationMax, status, startMin, startMax, page, limit, orderBy, orderDirection, externalStationId);
            //Assert.IsInstanceOf<InlineResponse2008> (response, "response is InlineResponse2008");
        }
        /// <summary>
        /// Test PlaylistPostMerge
        /// </summary>
        [Test]
        public void PlaylistPostMergeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PlaylistMergeBody body = null;
            //var response = instance.PlaylistPostMerge(body);
            //Assert.IsInstanceOf<InlineResponse2021> (response, "response is InlineResponse2021");
        }
        /// <summary>
        /// Test PlaylistPostStructure
        /// </summary>
        [Test]
        public void PlaylistPostStructureTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PlaylistStructureBody body = null;
            //var response = instance.PlaylistPostStructure(body);
            //Assert.IsInstanceOf<InlineResponse2021> (response, "response is InlineResponse2021");
        }
        /// <summary>
        /// Test PlaylistPostTiming
        /// </summary>
        [Test]
        public void PlaylistPostTimingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PlaylistTimingBody body = null;
            //var response = instance.PlaylistPostTiming(body);
            //Assert.IsInstanceOf<InlineResponse2021> (response, "response is InlineResponse2021");
        }
        /// <summary>
        /// Test StopCurrentItem
        /// </summary>
        [Test]
        public void StopCurrentItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ItemsStopcurrentBody body = null;
            //var response = instance.StopCurrentItem(body);
            //Assert.IsInstanceOf<InlineResponse202> (response, "response is InlineResponse202");
        }
        /// <summary>
        /// Test UpdateItemById
        /// </summary>
        [Test]
        public void UpdateItemByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ItemDataInput body = null;
            //long? id = null;
            //var response = instance.UpdateItemById(body, id);
            //Assert.IsInstanceOf<InlineResponse202> (response, "response is InlineResponse202");
        }
    }

}
