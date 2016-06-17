//----------------------------------------------------------------
// product class
function product(sku, name, description, price, tax, details) {
    this.sku = sku; // codigo de producto (SKU = stock keeping unit)
    this.name = name;
    this.description = description;
    this.price = price;
    this.pricetax = price*tax;
    this.details = details;
}
