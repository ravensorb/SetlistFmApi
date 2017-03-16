﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SetlistFmApi.SearchOptions.Location;
using Xunit;

namespace SetlistFmApi.IntegrationTests
{
    public abstract class LocationTestsBase : IntegrationTestBase
    {
        [Fact]
        public void FindCity_ById_CanFindCity()
        {
            string id = "5392171";

            var city = _client.FindCity(id);

            Assert.Equal("San Jose", city.Name);
        }

        [Fact]
        public void FindCountries_CanFindCountries()
        {
            var results = _client.FindCountries();

            Assert.NotEqual(0, results.Countries.Count);
        }

        [Fact]
        public void FindVenue_ById_CanFindVenue()
        {
            var id = "4bd63782";

            var venue = _client.FindVenue(id);

            Assert.NotNull(venue);
            Assert.Equal(venue.Name, "Wachovia Center");
        }

        [Fact]
        public void FindVenues_CanFindVenues()
        {
            var options = new VenueSearchOptions() { Name = "Terminal 5" };

            var results = _client.FindVenues(options);

            Assert.NotNull(results);
            Assert.NotEmpty(results.Venues);
        }

        [Fact]
        public void FindSetlistsByVenue_CanFindSetlists()
        {
            var options = new SetlistByVenueSearchOptions() { VenueId = "4bd63782" };

            var results = _client.FindSetlistsByVenue(options);

            Assert.NotNull(results);
            Assert.NotEmpty(results.Setlists);
        }
    }
}
