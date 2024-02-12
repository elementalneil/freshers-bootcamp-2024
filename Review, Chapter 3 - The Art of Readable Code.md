# Review: Chapter 3, The Art of Readable Code

## Names that cannot be misconstrued

This is a follow up on the chapter **Packing Information into Names**. The previous chapter explained the importance of having descriptive names. For example, naming a Dictionary `itemCodeToPriceMap` is much more understandable than just naming it `dict`.

This chapter is a continuation of the previous chapter. This chapter states the importance of having names which are unambiguous, which cannot be interpreted in any other way than what the programmer intends. 

Some further guidelines are provided in the chapter:

### 1. Look at the name from a different perspectives and think about how it could be misunderstood

To quote an example from the book, consider the following statement 
```
studentDataRows.filter('Age' < 18)
```
It is unclear whether the intention is to select only students who are under 18, or to filter out students who are under 18. A much clearer name for `filter()` would be `select()` or `exclude()`.

### 2. Use the following conventions for limits
- Use `Min` and `Max` for Inclusive Limits. For example, `maxNameLength = 50` is a much clearer identifier than `NameSizeLimit = 50`. In the latter example it is not clear whether the size is up to 50, or up to and including 50.
- Use `first` and `last` for inclusive ranges. For example, consider `substring(string input, int start, int stop)`. Here it is not clear whether `stop` is inclusive or exclusive. Therefore, a better function signature would be `substring(string input, int first, int last)`.
- Use `begin` and `end` for inclusive/exclusive ranges. For example, `GetLogsWithinInterval(begin = "FEB 1 12am", end = "FEB 1 12pm")`.

### 3. When naming a boolean, use words like `is` and `has` to make it clear that it’s a boolean

Quoting the example from the book, consider the statement `bool readPassword = true`. This could mean 
- We need to read the password
- The password has always been read.

A better way to name this variable would be `IsAuthenticated` or `NeedsAuthentication`. Adding words like `is`, `has`, `can` or `should` help making boolean statements clearer.

Additionally, it is better to avoid using negated terms in variable names. For example, `bool notAuthenticated = false` requires more effort to interpret than `bool isAuthenticated = true`.

### 4. Make sure to meet users' expectations about certain identifiers.

For example, the name `linkedList.getSize()` would cause most programmers to think that this function simply returns the value of a private member of the `linkedList` object.

On the other hand, the name `linkedList.calculateSize()` would convey that the function iterates through the list and counts the number of elements in it. If we were to name the same function as `getSize()`, developers may make repeated calls to it thinking of it as a lightweight function.