using MuazzamMusicStore.BLL.Abstract;
using MuazzamMusicStore.BLL.Concrete;
using MuazzamMusicStore.UI.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MuazzamMusicStore.UI.MVC.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        IAlbumService albumService;
        public CartController(IAlbumService AlbumService)
        {
            albumService = AlbumService;
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult _CartButton()
        {
            return PartialView();
        }

        public ActionResult _CartList()
        {
            return PartialView();
        }
        public ActionResult AddToMyCart(int id)
        {
            // MyCart mycart = new MyCart();   bu kullanım her sepete ekle için yeni sepet oluşturur yani her ürün farklı sepette olur
            MyCart cart = Session["cart"] as MyCart;

            CartItemDTO cartItem = new CartItemDTO();
            var eklenenAlbum = albumService.Get(id);
            cartItem.ID = eklenenAlbum.ID;
            cartItem.Name = eklenenAlbum.Title;
            //cartItem.Price = eklenenAlbum.Price;
            //price eklerken indirim olsun,%10 indirim olsun
            cartItem.Price = eklenenAlbum.Discounted ? eklenenAlbum.Price * 0.9m : eklenenAlbum.Price;
            cartItem.Amount = 1;

            cart.Add(cartItem);
            Session["cart"] = cart;
            return PartialView("_CartButton");
            
        }
        public ActionResult UpdateCart(short amount,int id)
        {
            MyCart guncellenenSepet = Session["cart"] as MyCart;
            guncellenenSepet.Update(id, amount);
            Session["cart"] = guncellenenSepet;
            return RedirectToAction("_CardList","Cart");
        }
        public ActionResult DeleteItemCart(int id)
        {
            MyCart silinecekSepet= Session["cart"] as MyCart;
            silinecekSepet.Delete(id);

            Session["cart"] = silinecekSepet;
            return RedirectToAction("_CardList", "Cart"); 
        }

        }
}