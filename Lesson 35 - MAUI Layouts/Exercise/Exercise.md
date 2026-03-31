# Lesson 35 - Layouts and Controls - Exercise

You will build a Blazor page with multiple cells that will generate a random color on each when clicked. There will be a button at the top that will reset the colors of all of the cells.

This exercise will be broken into several parts. Create a new .NET MAUI Blazor Hybrid solution.

View the screenshots for UI example.

## MAUI Side

1. Create a new button in MainPage.xaml so that it appears horizontally at the top of the application.
2. When this button is clicked it should execute the `OnResetColorClicked` method that exists in the code-behind file.
3. `OnResetColorClicked` will invoke the `ResetColors` method in the special Bridge class (see below).

## ColorBridge class
1. Create a new class called `ColorBridge` that will connect the Xaml app to the Razor pages.
2. It contains the following:
    - A `static` instance of itself to create a singleton pattern.
    - A nullable `Action` property called `ColorChanged`.
    - A void method called `ResetColors` that invokes the `ColorChanged` action.

## ColorCards page
1. Create a new razor page called `ColorCards.razor`. Add this page to the NavMenu so it can be routed.
2. Create a div that can act as a grid display that will render multiple pieces of content. This grid should have 3 columns.
3. Add at least 4 `Card` components (see below).

## Card component
1. Create a new component called `Card`.
2. The `Card` will appear as a square with text in it. Use the `RenderFragment` parameter to be able to pass content from the parent to this component.
3. The `background-color` css property will be set by a variable declared in the `code` block

### Card Styling
1. In a `<div>` tag:
    - Set a black border
    - Set the `background-color` to be the value of a `color` variable.
    - When the div is clicked, called the method `GenColor` (see below)
2. Add the `ChildContent` inside the div as a `<p>` tag.

### Card Code
1. Add the following Properties:
    - `ChildContent`
        - Type `RenderFragment`
        - Set as `Parameter`
        - Has a getter/setter
    - `color`
        - Type `string`
        - Initialized to `"rgb(255, 255 , 255)"`
    - `random`
        - Type `Random`
        - Initialized to a new `Random` object
2. Add the following methods:
    - `GenColor`
        - Generates a random int from 0-255 for red, green, and blue.
        - updates the `color` property to have these new colors (includ the 'rgb()')
    - `OnResetColor`
        - resets the `color` property to `"rgb(255, 255 , 255)"`
        - Triggers a refresh
    - override `OnInitialized()`
        - Subscribes `OnResetColor` to the `ColorChanged` event on the `ColorBridge` class
    - `Dispose`
        - Void method
        - Unsubscribes `OnResetColor` from the `ColorChanged` event on the `ColorBridge` class