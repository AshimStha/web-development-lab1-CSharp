# Web Development Lab 1 - CSharp

A repository to store all the course content files for **'Web Development Lab 1 C#'**. It includes files like class notes, assignments, labs, etc.

---

## Instructor

- Christine Bittle ([Email](christine.bittle@humber.ca))

---

## What We Learn

This class is about learning to create Web APIs using C# programming language. It also covers several topics involved in object oriented programming.[^1]

![The Rock](./_readme/CodeJoke.jpg)

_A programming meme taken from the movie "Journey to the center of the Earth"_

> :memo: **Note:** This class is a little difficult but Christine is super helpful and goes through every details.

[^note]: This class takes place online every Tuesday from 3:20 PM - 6:00 PM.

## Code Sample - Markdown

```csharp
public string SpecialDay(int month, int day)
        {
            // variable to store the output
            String output;

            // checking for invalid inputs
            if (month < 1 || month > 12 || day < 1 || day > 31)
            {
                // output for invalid input
                output = "Invalid month or day.";
            }
            // checking if the provided date is before Feb 18
            else if (month < 2 || (month == 2 && day < 18))
            {
                // storing the output in the variable
                output = "Before";
            }
            // checking if the provided date is Feb 18
            else if (month == 2 && day == 18)
            {
                // output for the special date
                output = "Special";
            }
            // else statement for the dates after Feb 18
            else
            {
                // output for the date after
                output = "After";
            }
            // returning the variable with the result text
            return output;
        }
```

- Creating a project in Visual Code
- Controllers
- Methods and HTTP requests
- Routes and wildcards
- Conditional statements / Loops
- Views

[^1]: We have learned the above topics by now:
