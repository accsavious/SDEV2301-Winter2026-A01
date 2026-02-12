# Blazor Components - Shopping Cart

Create a new Blazor app and add a new razor page called `Cart.razor`. This page will display a list of items that a user can have. The user will be able to add items to the shopping cart and have them appear in the list.

The user must be able to navigate to this page with the NavMenu.

This exercise will make use of Blazor components and parameters.

A POCO class called `Item` is included. It has the following properties:
- Name (string)
- Description (string)
- Price (double)

See cartpage.png for sample image.

Include the `Item.cs` file in your solution.

## Cart Page

### Code

1. Add the following public properties:
    - `Items`
        - List of `Item` objects
        - contains the items in our shopping cart
        - Initiliaze the cart with these values:

        ```
        public List<Item> Items { get; set; } = new()
        {
            new Item {Name = "Furby", Description = "Annoying Monster", Price = 799.99},
            new Item {Name = "Machine Gun", Description = "Awesome", Price = 1699.99},
            new Item {Name = "Schrödinger's Cat", Description = "Dead and Alive", Price = 50.44},
            new Item {Name = "Empty Box", Description = "Full of possibilities", Price = 0.49},
            new Item {Name = "AI Subscription", Description = "Nothing to see here...", Price = 280.00}
        };
        ```
    - `PriceMessage`
        - string
        - initialized to empty string
        - contains the message that will displayed with the price.
2. Add the following methods:
    - `ShowPriceMessage(Item item)`
        - accepts an Item parameter
        - Shows the price of the item when it is clicked on.
        - Implement the following logic:
            - if the item's price is less than 100, the Price message should be "That's an affordable" followed by the item name.
            - if the item's price is 100-999, the Price message should be "That's a bit pricey for a " followed by the item name.
            - if the price is >= 1000, the Price message should be "Wow that's an expensive for a " followed by the item name.
    
### UI
1. Display a <h3> that says Shopping Cart at the top of the page
2. Create a table with the class of "table"
3. print the Name, Description, and Price as header rows.
4. For every item in the List<Item>, create a new ItemRow component.
5. When the user clicks on an item, the PriceMessage must be displayed as an <h3> below the table.

## ItemRow Component

Create a new razor page called `ItemRow.razor`

### Code
1. Add the following public properties
    - `Item`
        - `Item` object
        - Represents an individual item in the shopping cart
        - This property must be marked as a `Parameter`
    - `OnShowPrice`
        - `EventCallback<Item>` object
        - Represents an method that will update the message in the parent component
        - This property must be marked as a `Parameter`
2. Add the following method:
    - `HandleClick()`
        - `private async Task` method definition
        - Invokes the `OnShowPrice` EventCallback property and send the `Item` back to the parent
### UI
1. The component should be a single <tr> with three <td> tags that contain the Item Name, Description, and Price.
2. The <tr> implements the @onclick directive and calls the HandleClick method.
3. Use the attribute `style="cursor: pointer;"` to turn the cursor into a hand when the user overs over the row.
