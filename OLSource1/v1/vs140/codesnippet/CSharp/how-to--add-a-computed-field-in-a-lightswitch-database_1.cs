        partial void Subtotal_Compute(ref decimal result)
        {
            result = this.Quantity * this.UnitPrice;
        }