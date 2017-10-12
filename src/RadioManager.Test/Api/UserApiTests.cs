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
    ///  Class for testing UserApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class UserApiTests
    {
        private UserApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new UserApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of UserApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' UserApi
            //Assert.IsInstanceOfType(typeof(UserApi), instance, "instance is a UserApi");
        }

        
        /// <summary>
        /// Test DeleteUserById
        /// </summary>
        [Test]
        public void DeleteUserByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //var response = instance.DeleteUserById(id);
            //Assert.IsInstanceOf<Success> (response, "response is Success");
        }
        
        /// <summary>
        /// Test GetUserById
        /// </summary>
        [Test]
        public void GetUserByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //var response = instance.GetUserById(id);
            //Assert.IsInstanceOf<UserResult> (response, "response is UserResult");
        }
        
        /// <summary>
        /// Test InviteUserByMail
        /// </summary>
        [Test]
        public void InviteUserByMailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //InviteUserData data = null;
            //var response = instance.InviteUserByMail(data);
            //Assert.IsInstanceOf<InviteUserSuccess> (response, "response is InviteUserSuccess");
        }
        
        /// <summary>
        /// Test ListUsers
        /// </summary>
        [Test]
        public void ListUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? page = null;
            //long? roleId = null;
            //long? limit = null;
            //string orderBy = null;
            //string orderDirection = null;
            //var response = instance.ListUsers(page, roleId, limit, orderBy, orderDirection);
            //Assert.IsInstanceOf<UserResults> (response, "response is UserResults");
        }
        
    }

}
