﻿using MediatR;

namespace DesignPattern.Mediator.Mediator.Commands
{
    public class UpdateProductCommand :IRequest
    {

        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int ProductStock { get; set; }
        public string ProductStockType { get; set; }

        public int ProductPrice { get; set; }

        public string ProductCategory { get; set; }
    }
}
