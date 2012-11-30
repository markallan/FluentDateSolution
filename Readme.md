#What is FluentDate?

FluentDate is a nano size library that is meant to make date comparisons more readable in a business domain.

##Why would I want to use it?
Let's say you are trying to validate the following business rule.
>The AssessmentDate must not be more that 10 days ago.

How might we test for a validation without using FluentDate?

```C#
if (AssessmentDate.AddDays(10) < DateTime.Today)) throw new ValidationException();
if (AssessmentDate < DateTime.Today.AddDays(-10)) throw new ValidationException();
if (!AssessmentDate.AddDays(10) >= DateTime.Today)) throw new ValidationException();
if (!AssessmentDate >= DateTime.Today.AddDays(-10)) throw new ValidationException();
```
Not very intuitive!

What if you could write?
```C#
if (AssessmentDate.IsMoreThan(10).Days.Ago) throw new ValidationException();
```
#How do I get started?



#Where do I get it?

