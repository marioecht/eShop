namespace eShop.Basket.API.Model;

public class BasketItem : IValidatableObject
/// <summary>
/// Represents an item in the basket, including product details and quantity.
/// </summary>
/// <remarks>
/// Provides validation for the quantity of the basket item.
/// </remarks>
/// <property name="Id">Gets or sets the unique identifier for the basket item.</property>
/// <property name="ProductId">Gets or sets the identifier of the product.</property>
/// <property name="ProductName">Gets or sets the name of the product.</property>
/// <property name="UnitPrice">Gets or sets the current unit price of the product.</property>
/// <property name="OldUnitPrice">Gets or sets the previous unit price of the product.</property>
/// <property name="Quantity">Gets or sets the quantity of the product in the basket.</property>
/// <property name="PictureUrl">Gets or sets the URL of the product's picture.</property>
/// <method name="Validate">
/// Validates the basket item, ensuring the quantity is at least 1.
/// </method>
{
    public string Id { get; set; }
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal OldUnitPrice { get; set; }
    public int Quantity { get; set; }
    public string PictureUrl { get; set; }


    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        var results = new List<ValidationResult>();

        if (Quantity < 1)
        {
            results.Add(new ValidationResult("Invalid number of units", new[] { "Quantity" }));
        }

        return results;
    }
}
