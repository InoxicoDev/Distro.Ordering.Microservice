using Distro.Ordering.Domain.Entities;
using System;

namespace Distro.Ordering.Tests.Builders
{
    public class ProductBuilder : Product
    {
        public ProductBuilder(Guid? id = null)
        {
            this.Id = id ?? Guid.NewGuid();
        }

        public ProductBuilder BicPen()
        {
            this.Name = "Bic Pen Classic";
            this.ProductCode = "PEN-BIC-001";
            this.Supplier = "CNA";

            return this;
        }

        public ProductBuilder A4Paper()
        {
            this.Name = "Typek A4 Standard";
            this.ProductCode = "P-TYPEK-001";
            this.Supplier = "CNA";

            return this;
        }

        public Product Build()
        {
            return this;
        }
    }
}
