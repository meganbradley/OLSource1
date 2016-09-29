---
title: "Symbol and Operator Reference (F#)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "^_FS"
  - "=_FS"
  - "~~~_FS"
  - "?_FS"
  - "%_FS"
  - ":>_FS"
  - "@_FS"
  - "comment_FS"
  - "&_FS"
  - ":?_FS"
  - "-_FS"
  - "__FS"
  - "]_FS"
  - ".._FS"
  - "(_FS"
  - "{_FS"
  - ">=_FS"
  - "/_FS"
  - "}_FS"
  - ":_FS"
  - "->_FS"
  - "*_FS"
  - "#_FS"
  - "::_FS"
  - "|||_FS"
  - "*)_FS"
  - "^^^_FS"
  - "<_FS"
  - ", _FS"
  - "&&_FS"
  - "**_FS"
  - "|)_FS"
  - "<<_FS"
  - "@@>_FS"
  - ".[_FS"
  - "<-_FS"
  - "|_FS"
  - "(|_FS"
  - "_FS"
  - "<<<_FS"
  - ""_FS"
  - "[<_FS"
  - ">>>_FS"
  - ">]_FS"
  - "._FS"
  - "//_FS"
  - "->>_FS"
  - ":=_FS"
  - "<@_FS"
  - "<|_FS"
  - "<@@_FS"
  - "(*_FS"
  - "@>_FS"
  - "|>_FS"
  - ">_FS"
  - "|]_FS"
  - "~-_FS"
  - "~+_FS"
  - "[_FS"
  - "~~_FS"
  - "&&&_FS"
  - "<=_FS"
  - "||_FS"
  - ":?>_FS"
  - "[|_FS"
  - "$_FS"
  - "!_FS"
  - ">>_FS"
  - ")_FS"
  - "\_FS"
  - "'_FS"
  - "<>_FS"
  - "///_FS"
  - "+_FS"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "operator precedence [F#]"
  - "precedence, operators [F#]"
  - "operators [F#]"
  - "operators [F#], precedence"
ms.assetid: 9a956d8d-ff42-4bfa-93d7-427db2febdaa
caps.latest.revision: 55
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Symbol and Operator Reference (F#)
This topic includes a table of symbols and operators that are used in the F# language.  
  
## Table of Symbols and Operators  
 The following table describes symbols used in the F# language, provides links to topics that provide more information, and provides a brief description of some of the uses of the symbol. Symbols are ordered according to the ASCII character set ordering.  
  
|Symbol or operator|Links|Description|  
|------------------------|-----------|-----------------|  
|`!`|[Reference Cells](../VS_csharp/reference-cells--fsharp-.md)<br /><br /> [Workflows](../VS_csharp/computation-expressions--fsharp-.md)|-   Dereferences a reference cell.<br />-   After a keyword, indicates a modified version of the keyword's behavior as controlled by a workflow.|  
|`!=`|Not applicable.|-   Not used in F#. Use `<>` for inequality operations.|  
|`"`|[Literals](../VS_csharp/literals--fsharp-.md)<br /><br /> [Strings (F#)](../VS_csharp/strings--fsharp-.md)|-   Delimits a text string.|  
|`"""`|[Strings (F#)](../VS_csharp/strings--fsharp-.md)|Delimits a verbatim text string. Differs from `@"..."` in that a you can indicate a quotation mark character by using a single quote in the string.|  
|`#`|[Preprocessor and Compiler Directives](../VS_csharp/compiler-directives--fsharp-.md)<br /><br /> [Flexible Types](../VS_csharp/flexible-types--fsharp-.md)|-   Prefixes a preprocessor or compiler directive, such as `#light`.<br />-   When used with a type, indicates a *flexible type*, which refers to a type or any one of its derived types.|  
|`$`|No more information available.|-   Used internally for certain compiler-generated variable and function names.|  
|`%`|[Arithmetic Operators](../VS_csharp/arithmetic-operators--fsharp-.md)<br /><br /> [Code Quotations](../VS_csharp/code-quotations--fsharp-.md)|-   Computes the integer modulus.<br />-   Used for splicing expressions into typed code quotations.|  
|`%%`|[Code Quotations](../VS_csharp/code-quotations--fsharp-.md)|-   Used for splicing expressions into untyped code quotations.|  
|`%?`|[Nullable Operators](../VS_csharp/nullable-operators--fsharp-.md)|1.  Computes the integer modulus, when the right side is a nullable type.|  
|`&`|[Pattern Matching: The match .. with Expression](../VS_csharp/match-expressions--fsharp-.md)|-   Computes the address of a mutable value, for use when interoperating with other languages.<br />-   Used in AND patterns.|  
|`&&`|[Boolean Operators](../VS_csharp/boolean-operators--fsharp-.md)|-   Computes the Boolean AND operation.|  
|`&&&`|[Bitwise Operators](../VS_csharp/bitwise-operators--fsharp-.md)|-   Computes the bitwise AND operation.|  
|`'`|[Literals](../VS_csharp/literals--fsharp-.md)<br /><br /> [Automatic Generalization and Generics](../VS_csharp/automatic-generalization--fsharp-.md)|-   Delimits a single-character literal.<br />-   Indicates a generic type parameter.|  
|```...```|No more information available.|-   Delimits an identifier that would otherwise not be a legal identifier, such as a language keyword.|  
|`( )`|[Unit Type](../VS_csharp/unit-type--fsharp-.md)|-   Represents the single value of the unit type.|  
|`(...)`|[Tuples](../VS_csharp/tuples--fsharp-.md)<br /><br /> [Operator Overloading](../VS_csharp/operator-overloading--fsharp-.md)|-   Indicates the order in which expressions are evaluated.<br />-   Delimits a tuple.<br />-   Used in operator definitions.|  
|`(*...*)`||-   Delimits a comment that could span multiple lines.|  
|`(&#124;...&#124;)`|[Active Patterns](../VS_csharp/active-patterns--fsharp-.md)|-   Delimits an active pattern. Also called *banana clips*.|  
|`*`|[Arithmetic Operators](../VS_csharp/arithmetic-operators--fsharp-.md)<br /><br /> [Tuples](../VS_csharp/tuples--fsharp-.md)<br /><br /> [Units of Measure](../VS_csharp/units-of-measure--fsharp-.md)|-   When used as a binary operator, multiplies the left and right sides.<br />-   In types, indicates pairing in a tuple.<br />-   Used in units of measure types.|  
|`*?`|[Nullable Operators](../VS_csharp/nullable-operators--fsharp-.md)|1.  Multiplies the left and right sides, when the right side is a nullable type.|  
|`**`|[Arithmetic Operators](../VS_csharp/arithmetic-operators--fsharp-.md)|-   Computes the exponentiation operation (x ** y means x to the power of y).|  
|`+`|[Arithmetic Operators](../VS_csharp/arithmetic-operators--fsharp-.md)|-   When used as a binary operator, adds the left and right sides.<br />-   When used as a unary operator, indicates a positive quantity. (Formally, it produces the same value with the sign unchanged.)|  
|`+?`|[Nullable Operators](../VS_csharp/nullable-operators--fsharp-.md)|1.  Adds the left and right sides, when the right side is a nullable type.|  
|`,`|[Tuples](../VS_csharp/tuples--fsharp-.md)|-   Separates the elements of a tuple, or type parameters.|  
|`-`|[Arithmetic Operators](../VS_csharp/arithmetic-operators--fsharp-.md)|-   When used as a binary operator, subtracts the right side from the left side.<br />-   When used as a unary operator, performs a negation operation.|  
|`-`|[Nullable Operators](../VS_csharp/nullable-operators--fsharp-.md)|1.  Subtracts the right side from the left side, when the right side is a nullable type.|  
|`->`|[Functions](../VS_csharp/functions--fsharp-.md)<br /><br /> [Pattern Matching: The match .. with Expression](../VS_csharp/match-expressions--fsharp-.md)|-   In function types, delimits arguments and return values.<br />-   Yields an expression (in sequence expressions); equivalent to the `yield` keyword.<br />-   Used in match expressions|  
|`.`|[Members](../VS_csharp/members--fsharp-.md)<br /><br /> [Primitive Types](../VS_csharp/primitive-types--fsharp-.md)|-   Accesses a member, and separates individual names in a fully qualified name.<br />-   Specifies a decimal point in floating point numbers.|  
|`..`|[Control Flow: The for .. in Expression](../VS_csharp/loops--for...in-expression--fsharp-.md)|-   Specifies a range.|  
|`.. ..`|[Control Flow: The for .. in Expression](../VS_csharp/loops--for...in-expression--fsharp-.md)|-   Specifies a range together with an increment.|  
|`.[...]`|[Arrays](../VS_csharp/arrays--fsharp-.md)|-   Accesses an array element.|  
|`/`|[Arithmetic Operators](../VS_csharp/arithmetic-operators--fsharp-.md)<br /><br /> [Units of Measure](../VS_csharp/units-of-measure--fsharp-.md)|-   Divides the left side (numerator) by the right side (denominator).<br />-   Used in units of measure types.|  
|`/?`|[Nullable Operators](../VS_csharp/nullable-operators--fsharp-.md)|1.  Divides the left side by the right side, when the right side is a nullable type.|  
|`//`||-   Indicates the beginning of a single-line comment.|  
|`///`|[XML Documentation](../VS_csharp/xml-documentation--fsharp-.md)|-   Indicates an XML comment.|  
|`:`|[Functions](../VS_csharp/functions--fsharp-.md)|-   In a type annotation, separates a parameter or member name from its type.|  
|`::`|[Lists](../VS_csharp/lists--fsharp-.md)<br /><br /> [Pattern Matching: The match .. with Expression](../VS_csharp/match-expressions--fsharp-.md)|-   Creates a list. The element on the left side is appended to the list on the right side.<br />-   Used in pattern matching to separate the parts of a list.|  
|`:=`|[Reference Cells](../VS_csharp/reference-cells--fsharp-.md)|-   Assigns a value to a reference cell.|  
|`:>`|[Casting and Conversions](../VS_csharp/casting-and-conversions--fsharp-.md)|-   Converts a type to type that is higher in the hierarchy.|  
|`:?`|[Pattern Matching: The match .. with Expression](../VS_csharp/match-expressions--fsharp-.md)|-   Returns `true` if the value matches the specified type; otherwise, returns `false` (type test operator).|  
|`:?>`|[Casting and Conversions](../VS_csharp/casting-and-conversions--fsharp-.md)|-   Converts a type to a type that is lower in the hierarchy.|  
|`;`|[Verbose Syntax](../VS_csharp/verbose-syntax--fsharp-.md)<br /><br /> [Lists](../VS_csharp/lists--fsharp-.md)<br /><br /> [Records](../VS_csharp/records--fsharp-.md)|-   Separates expressions (used mostly in verbose syntax).<br />-   Separates elements of a list.<br />-   Separates fields of a record.|  
|`<`|[Arithmetic Operators](../VS_csharp/arithmetic-operators--fsharp-.md)|-   Computes the less-than operation.|  
|`<?`|[Nullable Operators](../VS_csharp/nullable-operators--fsharp-.md)|Computes the less than operation, when the right side is a nullable type.|  
|`<<`|[Functions](../VS_csharp/functions--fsharp-.md)|-   Composes two functions in reverse order; the second one is executed first (backward composition operator).|  
|`<<<`|[Bitwise Operators](../VS_csharp/bitwise-operators--fsharp-.md)|-   Shifts bits in the quantity on the left side to the left by the number of bits specified on the right side.|  
|`<-`|[Values](../VS_csharp/values--fsharp-.md)|-   Assigns a value to a variable.|  
|`<...>`|[Automatic Generalization and Generics](../VS_csharp/automatic-generalization--fsharp-.md)|-   Delimits type parameters.|  
|`<>`|[Arithmetic Operators](../VS_csharp/arithmetic-operators--fsharp-.md)|-   Returns `true` if the left side is not equal to the right side; otherwise, returns false.|  
|`<>?`|[Nullable Operators](../VS_csharp/nullable-operators--fsharp-.md)|1.  Computes the "not equal" operation when the right side is a nullable type.|  
|`<=`|[Arithmetic Operators](../VS_csharp/arithmetic-operators--fsharp-.md)|-   Returns `true` if the left side is less than or equal to the right side; otherwise, returns false.|  
|`<=?`|[Nullable Operators](../VS_csharp/nullable-operators--fsharp-.md)|1.  Computes the "less than or equal to" operation when the right side is a nullable type.|  
|`<&#124;`|[Functions](../VS_csharp/functions--fsharp-.md)|-   Passes the result of the expression on the right side to the function on left side (backward pipe operator).|  
|`<&#124;&#124;`|[Operators.( <&#124;&#124; )<'T1,'T2,'U> Function (F#)](../VS_csharp/operators.---------t1--t2--u--function--fsharp-.md)|-   Passes the tuple of two arguments on the right side to the function on left side.|  
|`<&#124;&#124;&#124;`|[Operators.( <&#124;&#124;&#124; )<'T1,'T2,'T3,'U> Function (F#)](../VS_csharp/operators.----------t1--t2--t3--u--function--fsharp-.md)|-   Passes the tuple of three arguments on the right side to the function on left side.|  
|`<@...@>`|[Code Quotations](../VS_csharp/code-quotations--fsharp-.md)|-   Delimits a typed code quotation.|  
|`<@@...@@>`|[Code Quotations](../VS_csharp/code-quotations--fsharp-.md)|-   Delimits an untyped code quotation.|  
|`=`|[Arithmetic Operators](../VS_csharp/arithmetic-operators--fsharp-.md)|-   Returns `true` if the left side is equal to the right side; otherwise, returns false.|  
|`=?`|[Nullable Operators](../VS_csharp/nullable-operators--fsharp-.md)|1.  Computes the "equal" operation when the right side is a nullable type.|  
|`==`|Not applicable.|-   Not used in F#. Use `=` for equality operations.|  
|`>`|[Arithmetic Operators](../VS_csharp/arithmetic-operators--fsharp-.md)|-   Returns `true` if the left side is greater than the right side; otherwise, returns false.|  
|`>?`|[Nullable Operators](../VS_csharp/nullable-operators--fsharp-.md)|1.  Computes the "greather than" operation when the right side is a nullable type.|  
|`>>`|[Functions](../VS_csharp/functions--fsharp-.md)|-   Composes two functions (forward composition operator).|  
|`>>>`|[Bitwise Operators](../VS_csharp/bitwise-operators--fsharp-.md)|-   Shifts bits in the quantity on the left side to the right by the number of places specified on the right side.|  
|`>=`|[Arithmetic Operators](../VS_csharp/arithmetic-operators--fsharp-.md)|-   Returns `true` if the right side is greater than or equal to the left side; otherwise, returns false.|  
|`>=?`|[Nullable Operators](../VS_csharp/nullable-operators--fsharp-.md)|1.  Computes the "greater than or equal" operation when the right side is a nullable type.|  
|`?`|[Passing Arguments](../VS_csharp/parameters-and-arguments--fsharp-.md)|-   Specifies an optional argument.<br />-   Used as an operator for dynamic method and property calls. You must provide your own implementation.|  
|`? ... <- ...`|No more information available.|-   Used as an operator for setting dynamic properties. You must provide your own implementation.|  
|`?>=`, `?>`, `?<=`, `?<`, `?=`, `?<>`, `?+`, `?-`, `?*`, `?/`|[Nullable Operators](../VS_csharp/nullable-operators--fsharp-.md)|1.  Equivalent to the corresponding operators without the ? prefix, where a nullable type is on the left.|  
|`>=?`, `>?`, `<=?`, `<?`, `=?`, `<>?`, `+?`, `-?`, `*?`, `/?`|[Nullable Operators](../VS_csharp/nullable-operators--fsharp-.md)|1.  Equivalent to the corresponding operators without the ? suffix, where a nullable type is on the right.|  
|`?>=?`, `?>?`, `?<=?`, `?<?`, `?=?`, `?<>?`, `?+?`, `?-?`, `?*?`, `?/?`|[Nullable Operators](../VS_csharp/nullable-operators--fsharp-.md)|1.  Equivalent to the corresponding operators without the surrounding question marks, where both sides are nullable types.|  
|`@`|[Lists](../VS_csharp/lists--fsharp-.md)<br /><br /> [Strings (F#)](../VS_csharp/strings--fsharp-.md)|-   Concatenates two lists.<br />-   When placed before a string literal, indicates that the string is to be interpreted verbatim, with no interpretation of escape characters.|  
|`[...]`|[Lists](../VS_csharp/lists--fsharp-.md)|-   Delimits the elements of a list.|  
|`[&#124;...&#124;]`|[Arrays](../VS_csharp/arrays--fsharp-.md)|-   Delimits the elements of an array.|  
|`[<...>]`|[Attributes](../VS_csharp/attributes--fsharp-.md)|-   Delimits an attribute.|  
|`\`|[Strings (F#)](../VS_csharp/strings--fsharp-.md)|-   Escapes the next character; used in character and string literals.|  
|`^`|[Statically Resolved Type Parameters](../VS_csharp/statically-resolved-type-parameters--fsharp-.md)<br /><br /> [Strings](../VS_csharp/strings--fsharp-.md)|-   Specifies type parameters that must be resolved at compile time, not at runtime.<br />-   Concatenates strings.|  
|`^^^`|[Bitwise Operators](../VS_csharp/bitwise-operators--fsharp-.md)|-   Computes the bitwise exclusive OR operation.|  
|`_`|[Pattern Matching: The match .. with Expression](../VS_csharp/match-expressions--fsharp-.md)<br /><br /> [Generics](../VS_csharp/generics--fsharp-.md)|-   Indicates a wildcard pattern.<br />-   Specifies an anonymous generic parameter.|  
|```|[Automatic Generalization and Generics](../VS_csharp/automatic-generalization--fsharp-.md)|-   Used internally to indicate a generic type parameter.|  
|`{...}`|[Sequences](../VS_csharp/sequences--fsharp-.md)<br /><br /> [Records](../VS_csharp/records--fsharp-.md)|-   Delimits sequence expressions and computation expressions.<br />-   Used in record definitions.|  
|`&#124;`|[Pattern Matching: The match .. with Expression](../VS_csharp/match-expressions--fsharp-.md)|-   Delimits individual match cases, individual discriminated union cases, and enumeration values.|  
|`&#124;&#124;`|[Boolean Operators](../VS_csharp/boolean-operators--fsharp-.md)|-   Computes the Boolean OR operation.|  
|`&#124;&#124;&#124;`|[Bitwise Operators](../VS_csharp/bitwise-operators--fsharp-.md)|-   Computes the bitwise OR operation.|  
|`&#124;>`|[Functions](../VS_csharp/functions--fsharp-.md)|-   Passes the result of the left side to the function on the right side (forward pipe operator).|  
|`&#124;&#124;>`|[Operators.( &#124;&#124;> )<'T1,'T2,'U> Function (F#)](../VS_csharp/operators.---------t1--t2--u--function--fsharp-.md)|-   Passes the tuple of two arguments on the left side to the function on the right side.|  
|`&#124;&#124;&#124;>`|[Operators.( &#124;&#124;&#124;> )<'T1,'T2,'T3,'U> Function (F#)](../VS_csharp/operators.----------t1--t2--t3--u--function--fsharp-.md)|1.  Passes the tuple of three arguments on the left side to the function on the right side.|  
|`~~`|[Operator Overloading](../VS_csharp/operator-overloading--fsharp-.md)|-   Used to declare an overload for the unary negation operator.|  
|`~~~`|[Bitwise Operators](../VS_csharp/bitwise-operators--fsharp-.md)|-   Computes the bitwise NOT operation.|  
|`~-`|[Operator Overloading](../VS_csharp/operator-overloading--fsharp-.md)|-   Used to declare an overload for the unary minus operator.|  
|`~+`|[Operator Overloading](../VS_csharp/operator-overloading--fsharp-.md)|-   Used to declare an overload for the unary plus operator.|  
  
## Operator Precedence  
 The following table shows the order of precedence of operators and other expression keywords in the F# language, in order from lowest precedence to the highest precedence. Also listed is the associativity, if applicable.  
  
|Operator|Associativity|  
|--------------|-------------------|  
|`as`|Right|  
|`when`|Right|  
|`&#124;` (pipe)|Left|  
|`;`|Right|  
|`let`|Nonassociative|  
|`function`, `fun`, `match`, `try`|Nonassociative|  
|`if`|Nonassociative|  
|`->`|Right|  
|`:=`|Right|  
|`,`|Nonassociative|  
|`or`, `&#124;&#124;`|Left|  
|`&`, `&&`|Left|  
|`:>`, `:?>`|Right|  
|`!=` `op`, `<``op`, `>``op`, `=`, `&#124;``op`, `&``op`, `&`<br /><br /> (including `<<<`, `>>>`, `&#124;&#124;&#124;`, `&&&`)|Left|  
|`^` `op`<br /><br /> (including `^^^`)|Right|  
|`::`|Right|  
|`:?`|Not associative|  
|`-` `op`, `+``op`|Applies to infix uses of these symbols|  
|`*` `op`, `/``op`, `%``op`|Left|  
|`**` `op`|Right|  
|`f x` (function application)|Left|  
|`&#124;` (pattern match)|Right|  
|prefix operators (+`op`, -`op`, %, %%, &, &&, !`op`, ~`op`)|Left|  
|`.`|Left|  
|`f(x)`|Left|  
|`f<` `types` `>`|Left|  
  
 F# supports custom operator overloading. This means that you can define your own operators. In the previous table, `op` can be any valid (possibly empty) sequence of operator characters, either built-in or user-defined. Thus, you can use this table to determine what sequence of characters to use for a custom operator to achieve the desired level of precedence. Leading `.` characters are ignored when the compiler determines precedence.  
  
## See Also  
 [F# Language Reference](../VS_csharp/fsharp-language-reference.md)   
 [Operator Overloading](../VS_csharp/operator-overloading--fsharp-.md)