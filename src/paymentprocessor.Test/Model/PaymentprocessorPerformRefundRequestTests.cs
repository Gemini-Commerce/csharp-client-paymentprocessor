/*
 * Payment Processor Service
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
 * Contact: info@gemini-commerce.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using paymentprocessor.Model;
using paymentprocessor.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace paymentprocessor.Test.Model
{
    /// <summary>
    ///  Class for testing PaymentprocessorPerformRefundRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class PaymentprocessorPerformRefundRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for PaymentprocessorPerformRefundRequest
        //private PaymentprocessorPerformRefundRequest instance;

        public PaymentprocessorPerformRefundRequestTests()
        {
            // TODO uncomment below to create an instance of PaymentprocessorPerformRefundRequest
            //instance = new PaymentprocessorPerformRefundRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PaymentprocessorPerformRefundRequest
        /// </summary>
        [Fact]
        public void PaymentprocessorPerformRefundRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" PaymentprocessorPerformRefundRequest
            //Assert.IsType<PaymentprocessorPerformRefundRequest>(instance);
        }

        /// <summary>
        /// Test the property 'TenantId'
        /// </summary>
        [Fact]
        public void TenantIdTest()
        {
            // TODO unit test for the property 'TenantId'
        }

        /// <summary>
        /// Test the property 'RefundId'
        /// </summary>
        [Fact]
        public void RefundIdTest()
        {
            // TODO unit test for the property 'RefundId'
        }

        /// <summary>
        /// Test the property 'Payment'
        /// </summary>
        [Fact]
        public void PaymentTest()
        {
            // TODO unit test for the property 'Payment'
        }

        /// <summary>
        /// Test the property 'Amount'
        /// </summary>
        [Fact]
        public void AmountTest()
        {
            // TODO unit test for the property 'Amount'
        }

        /// <summary>
        /// Test the property 'Currency'
        /// </summary>
        [Fact]
        public void CurrencyTest()
        {
            // TODO unit test for the property 'Currency'
        }
    }
}