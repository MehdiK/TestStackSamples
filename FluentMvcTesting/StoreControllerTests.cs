using System.Collections.Generic;
using System.Linq;
using MvcMusicStore.Controllers;
using MvcMusicStore.Models;
using NSubstitute;
using NUnit.Framework;
using TestStack.FluentMVCTesting;

namespace FluentMvcTesting
{
    public class StoreControllerTests
    {
        readonly IMusicStoreEntities _musicStoreEntities = Substitute.For<IMusicStoreEntities>();
        readonly List<Genre> _genres = new List<Genre> {new Genre {Name = "Genre 1"}};
        private readonly StoreController _controller;

        public StoreControllerTests()
        {
            _musicStoreEntities.Genres.Returns(_genres.AsQueryable());
            _controller = new StoreController(_musicStoreEntities);
        }

        bool ModelIsCorrect(IEnumerable<Genre> model)
        {
            var m = model.ToList();
            return m.Count() == 1 && m.First().Name == _genres[0].Name;
        }

        [Test]
        public void Index()
        {
            _controller
                .WithCallTo(c => c.Index())
                .ShouldRenderDefaultView()
                .WithModel<IEnumerable<Genre>>(g => ModelIsCorrect(g));
        }

        [Test]
        public void GenreMenu()
        {
            _controller
                .WithCallToChild(c => c.GenreMenu())
                .ShouldRenderDefaultPartialView()
                .WithModel<IEnumerable<Genre>>(g => ModelIsCorrect(g));

        }
    }
}
