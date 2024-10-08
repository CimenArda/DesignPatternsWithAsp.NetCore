﻿using DesignPattern.Mediator.Mediator.Commands;
using DesignPattern.Mediator.Mediator.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Mediator.Controllers
{
    public class ProductController : Controller
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _mediator.Send(new GetAllProductQuery());
            
            return View(values);
        }

        public IActionResult AddProduct()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(AddProductCommand command)
        {
           await _mediator.Send(command);
            return RedirectToAction("Index");

        }

        [HttpGet]
        public async Task<IActionResult> UpdateProduct(int id)
        {
            var values = await _mediator.Send(new GetProductByIdQuery(id));
            return View(values);    
        }
        [HttpPost]
        public async Task<IActionResult> UpdateProduct(UpdateProductCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction("Index");
        }

        public async Task<ActionResult> DeleteProduct(int id)
        {
            await _mediator.Send(new DeleteProductCommand(id));
            return RedirectToAction("Index");   
        }



    }
}
