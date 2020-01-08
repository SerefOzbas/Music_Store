using MuazzamMusicStore.BLL.Abstract;
using MuazzamMusicStore.Model;
using MuazzamMusicStore.UI.MVC.CustomFilter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MuazzamMusicStore.UI.MVC.Controllers
{
    public class HomeController : Controller
    {
        IAlbumService albumService;
        IGenreService genreService;

        public HomeController(IAlbumService album,IGenreService genre)
        {
            albumService = album;
            genreService = genre;
        }
        public ActionResult Index()  //TÜM ALBÜMLER
        {
            var albums = albumService.GetAll();
            return View(albums);
        }

        public ActionResult _GenreMenu()
        {
            return PartialView(genreService.GetAll());
        }
        public ActionResult _GenreOfAlbums(int? id)
        {
            if (id!=null)
            {
                return PartialView(albumService.GetAlbumOfGenre(id.Value).ToList());
            }
            return PartialView(albumService.GetAll());
        }

        public ActionResult _DiscountedOfAlbums()
        {
            var indirimdekiUrunler = albumService.GetDiscountedAlbums().ToList();
            if (indirimdekiUrunler.Count==0)
            {
                ViewBag.Error = "İndirimde ürün bulunmamaktadır!";
            }
            return PartialView(indirimdekiUrunler);
        }
        public ActionResult _LastFiveAlbums()
        {
            return PartialView(albumService.GetLastFiveAlbumlers().ToList());
        }

        [CustomFilter]
        public ActionResult Detay(int id)
        {
            Albumler album = albumService.Get(id);
            return View(album);
        }
    }
}