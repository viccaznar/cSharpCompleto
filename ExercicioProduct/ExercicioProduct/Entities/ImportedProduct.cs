namespace Course.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct() 
        { 
        }

        public ImportedProduct(double customsFee)
        {
            CustomsFee = customsFee;
        }
    }
}
