using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoPoco.Engine;
using FluentAssertions;
using NUnit.Framework;

namespace AutoPoco.Extensions.Tests
{
    [TestFixture]
    public class ConversationTests

    {
        [Test]
        public void ExampleTest()
        {
            var factory = AutoPocoContainer.Configure(x =>
            {
                x.Conventions(c =>
                {
                    c.UseExtendedConventions();
                    c.UseDefaultConventions();
                });
                x.AddFromAssemblyContainingType<SampleData>();
            });

            var session = factory.CreateSession();

            var sampleData = session.Single<SampleData>().Get();
            
            sampleData.AddressLine1.Should().NotBeNullOrEmpty();
            sampleData.City.Should().NotBeNullOrEmpty();
            sampleData.StateProvidence.Should().NotBeNullOrEmpty();
            sampleData.PostalCode.Should().NotBeNullOrEmpty();
            sampleData.WebSite.Should().NotBeNullOrEmpty();
            sampleData.CompanyName.Should().NotBeNullOrEmpty();
            sampleData.EmailAddress.Should().NotBeNullOrEmpty();
            sampleData.BusinessPhone.Should().NotBeNullOrEmpty();
            sampleData.BusinessFax.Should().NotBeNullOrEmpty();
            sampleData.OtherPhone.Should().NotBeNullOrEmpty();

            sampleData.CreateDate.Should().NotBe(DateTime.MinValue);
            sampleData.UpdateDate.Should().NotBe(DateTime.MinValue);

        }
    }
}
