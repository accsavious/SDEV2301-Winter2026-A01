# Forms and Data Binding Exercises

These exercises require you to create models and implement forms with the required fields and data binding. For each of the models, create a new razor page and update the NavMenu so that it can be navigated to through the UI.

Refer to the Valid and Invalid screenshots of each model for sample output.

Note: With data time objects and string interpolation, append the `:d` suffix to make the date appear in a friendly format, for example:  

`{myDateVariable:d}`

## Task Item

1. Create a new model called `TaskItem` with the following properties:
    - `Title`
        - string
        - Required
        - Initialized to an empty string
    - `DueDate`
        - Nullable datetime (use the ? operator)
        - Required
    - `IsComplete`
        - boolean
        - Not required
2. Create a new page with an `EditForm` component to enter the data for a `TaskItem`.
3. Use the following input components for each field:
    - Title: `InputText`
    - Due Date: `InputDate`
    - IsComplete: `InputCheckbox`
4. Bind the fields to the appropriate properties of a `TaskItem` object.
5. Provide a validation summary and a validation for each field.
6. Include a submit button.
7. When the submit button is clicked and the data is valid, display the following message to the user on the page:

Task '{title}' due on {due date} has been submitted. Completed: {is complete}

Make the due date present in a user friendly way.

## Vote Form

Note: Use the following link for a guide on how to implement the radio buttons: https://stackoverflow.com/questions/66416971/blazor-inputradio

1. Create a new model called `Poll` with the following properties:
    - `Name`
        - string
        - Required
        - Initialized to an empty string
        - The voter's name
    - `City`
        - string
        - Required
        - Initialized to an empty string
        - The voter's city
    - `Candidate`
        - Nullable string
        - The candidate
    - `ConfidenceLevel`
        - int
        - The candidates competency on a number from 0-100.

2. Create a new page with an `EditForm` component to enter the data for a `Poll`.
3. Use the following input components for each field:
    - Name: `InputText`
    - City: `InputText`
    - Candidate: `InputRadioGroup`
        - There should be a `InputRadio` component for each candidate in the `Candidates` list (described below).
        - Add the following list to the `@code` block in the page:
            ```
            private List<string> Candidates = new List<string>
            {
                "Dancing Dan",
                "Roller Blading Guitar Guy",
                "The Current Mayor",
                "A rock with googley eyes glued to it"
            };
            ```
        - Use the `Candidates` list when creating the `InputRadioGroup`
    - ConfidenceLevel: `InputNumber`
4. Bind the fields to the appropriate properties of a `Poll` object.
5. Provide a validation summary and a validation for each field.
6. Include a submit button.
7. When the submit button is clicked and the data is valid, display the following message to the user on the page:

{name} is {confidenceLevel}% confident that {candidate} would be the best leader of {city}


