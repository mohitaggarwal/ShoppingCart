using ShoppingCartLib;
using ShoppingCartLib.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace eCommerceWebAPI.Controllers
{
    [RoutePrefix("api/ShoppingCart")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ShoppingCartServiceController : ApiController
    {
        [HttpGet]
        [Route("{id:int}")]
        public IHttpActionResult Get(int id)
		{
            IProductRepository productRepository = new MockProductRepository();
            var product = productRepository.GetShoppingCartProducts(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [Route("{id:int}/Receipt")]
        [HttpGet]
        public IHttpActionResult GetReciept(int id)
        {
            IProductRepository productRepository = new MockProductRepository();
            IReceiptGenerator receiptGenerator = new ReceiptGenerator(productRepository);
            var reciept = receiptGenerator.GetReceipt(id);
            if (reciept.CartItems == null || reciept.CartItems.Count == 0)
            {
                return NotFound();
            }
            return Ok(reciept);
        }
    }
}
