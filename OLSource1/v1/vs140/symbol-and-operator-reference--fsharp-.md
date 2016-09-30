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
|<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>|[Reference Cells](../vs140/reference-cells--fsharp-.md)\<br />\<br /> [Workflows](../vs140/computation-expressions--fsharp-.md)|-   Dereferences a reference cell.\<br />-   After a keyword, indicates a modified version of the keyword's behavior as controlled by a workflow.|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Not applicable.|-   Not used in F#. Use <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> for inequality operations.|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|[Literals](../vs140/literals--fsharp-.md)\<br />\<br /> [Strings (F#)](../vs140/strings--fsharp-.md)|-   Delimits a text string.|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|[Strings (F#)](../vs140/strings--fsharp-.md)|Delimits a verbatim text string. Differs from <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> in that a you can indicate a quotation mark character by using a single quote in the string.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|[Preprocessor and Compiler Directives](../vs140/compiler-directives--fsharp-.md)\<br />\<br /> [Flexible Types](../vs140/flexible-types--fsharp-.md)|-   Prefixes a preprocessor or compiler directive, such as <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.\<br />-   When used with a type, indicates a *flexible type*, which refers to a type or any one of its derived types.|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|No more information available.|-   Used internally for certain compiler-generated variable and function names.|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|[Arithmetic Operators](../vs140/arithmetic-operators--fsharp-.md)\<br />\<br /> [Code Quotations](../vs140/code-quotations--fsharp-.md)|-   Computes the integer modulus.\<br />-   Used for splicing expressions into typed code quotations.|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|[Code Quotations](../vs140/code-quotations--fsharp-.md)|-   Used for splicing expressions into untyped code quotations.|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|[Nullable Operators](../vs140/nullable-operators--fsharp-.md)|1.  Computes the integer modulus, when the right side is a nullable type.|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|[Pattern Matching: The match .. with Expression](../vs140/match-expressions--fsharp-.md)|-   Computes the address of a mutable value, for use when interoperating with other languages.\<br />-   Used in AND patterns.|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|[Boolean Operators](../vs140/boolean-operators--fsharp-.md)|-   Computes the Boolean AND operation.|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|[Bitwise Operators](../vs140/bitwise-operators--fsharp-.md)|-   Computes the bitwise AND operation.|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|[Literals](../vs140/literals--fsharp-.md)\<br />\<br /> [Automatic Generalization and Generics](../vs140/automatic-generalization--fsharp-.md)|-   Delimits a single-character literal.\<br />-   Indicates a generic type parameter.|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|No more information available.|-   Delimits an identifier that would otherwise not be a legal identifier, such as a language keyword.|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|[Unit Type](../vs140/unit-type--fsharp-.md)|-   Represents the single value of the unit type.|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|[Tuples](../vs140/tuples--fsharp-.md)\<br />\<br /> [Operator Overloading](../vs140/operator-overloading--fsharp-.md)|-   Indicates the order in which expressions are evaluated.\<br />-   Delimits a tuple.\<br />-   Used in operator definitions.|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>||-   Delimits a comment that could span multiple lines.|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|[Active Patterns](../vs140/active-patterns--fsharp-.md)|-   Delimits an active pattern. Also called *banana clips*.|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|[Arithmetic Operators](../vs140/arithmetic-operators--fsharp-.md)\<br />\<br /> [Tuples](../vs140/tuples--fsharp-.md)\<br />\<br /> [Units of Measure](../vs140/units-of-measure--fsharp-.md)|-   When used as a binary operator, multiplies the left and right sides.\<br />-   In types, indicates pairing in a tuple.\<br />-   Used in units of measure types.|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|[Nullable Operators](../vs140/nullable-operators--fsharp-.md)|1.  Multiplies the left and right sides, when the right side is a nullable type.|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|[Arithmetic Operators](../vs140/arithmetic-operators--fsharp-.md)|-   Computes the exponentiation operation (x ** y means x to the power of y).|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|[Arithmetic Operators](../vs140/arithmetic-operators--fsharp-.md)|-   When used as a binary operator, adds the left and right sides.\<br />-   When used as a unary operator, indicates a positive quantity. (Formally, it produces the same value with the sign unchanged.)|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|[Nullable Operators](../vs140/nullable-operators--fsharp-.md)|1.  Adds the left and right sides, when the right side is a nullable type.|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|[Tuples](../vs140/tuples--fsharp-.md)|-   Separates the elements of a tuple, or type parameters.|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|[Arithmetic Operators](../vs140/arithmetic-operators--fsharp-.md)|-   When used as a binary operator, subtracts the right side from the left side.\<br />-   When used as a unary operator, performs a negation operation.|  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|[Nullable Operators](../vs140/nullable-operators--fsharp-.md)|1.  Subtracts the right side from the left side, when the right side is a nullable type.|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|[Functions](../vs140/functions--fsharp-.md)\<br />\<br /> [Pattern Matching: The match .. with Expression](../vs140/match-expressions--fsharp-.md)|-   In function types, delimits arguments and return values.\<br />-   Yields an expression (in sequence expressions); equivalent to the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> keyword.\<br />-   Used in match expressions|  
|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|[Members](../vs140/members--fsharp-.md)\<br />\<br /> [Primitive Types](../vs140/primitive-types--fsharp-.md)|-   Accesses a member, and separates individual names in a fully qualified name.\<br />-   Specifies a decimal point in floating point numbers.|  
|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|[Control Flow: The for .. in Expression](../vs140/loops--for...in-expression--fsharp-.md)|-   Specifies a range.|  
|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|[Control Flow: The for .. in Expression](../vs140/loops--for...in-expression--fsharp-.md)|-   Specifies a range together with an increment.|  
|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|[Arrays](../vs140/arrays--fsharp-.md)|-   Accesses an array element.|  
|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|[Arithmetic Operators](../vs140/arithmetic-operators--fsharp-.md)\<br />\<br /> [Units of Measure](../vs140/units-of-measure--fsharp-.md)|-   Divides the left side (numerator) by the right side (denominator).\<br />-   Used in units of measure types.|  
|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|[Nullable Operators](../vs140/nullable-operators--fsharp-.md)|1.  Divides the left side by the right side, when the right side is a nullable type.|  
|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>||-   Indicates the beginning of a single-line comment.|  
|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|[XML Documentation](../vs140/xml-documentation--fsharp-.md)|-   Indicates an XML comment.|  
|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|[Functions](../vs140/functions--fsharp-.md)|-   In a type annotation, separates a parameter or member name from its type.|  
|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|[Lists](../vs140/lists--fsharp-.md)\<br />\<br /> [Pattern Matching: The match .. with Expression](../vs140/match-expressions--fsharp-.md)|-   Creates a list. The element on the left side is appended to the list on the right side.\<br />-   Used in pattern matching to separate the parts of a list.|  
|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|[Reference Cells](../vs140/reference-cells--fsharp-.md)|-   Assigns a value to a reference cell.|  
|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|[Casting and Conversions](../vs140/casting-and-conversions--fsharp-.md)|-   Converts a type to type that is higher in the hierarchy.|  
|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|[Pattern Matching: The match .. with Expression](../vs140/match-expressions--fsharp-.md)|-   Returns <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> if the value matches the specified type; otherwise, returns <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> (type test operator).|  
|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|[Casting and Conversions](../vs140/casting-and-conversions--fsharp-.md)|-   Converts a type to a type that is lower in the hierarchy.|  
|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|[Verbose Syntax](../vs140/verbose-syntax--fsharp-.md)\<br />\<br /> [Lists](../vs140/lists--fsharp-.md)\<br />\<br /> [Records](../vs140/records--fsharp-.md)|-   Separates expressions (used mostly in verbose syntax).\<br />-   Separates elements of a list.\<br />-   Separates fields of a record.|  
|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>|[Arithmetic Operators](../vs140/arithmetic-operators--fsharp-.md)|-   Computes the less-than operation.|  
|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|[Nullable Operators](../vs140/nullable-operators--fsharp-.md)|Computes the less than operation, when the right side is a nullable type.|  
|<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>|[Functions](../vs140/functions--fsharp-.md)|-   Composes two functions in reverse order; the second one is executed first (backward composition operator).|  
|<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>|[Bitwise Operators](../vs140/bitwise-operators--fsharp-.md)|-   Shifts bits in the quantity on the left side to the left by the number of bits specified on the right side.|  
|<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>|[Values](../vs140/values--fsharp-.md)|-   Assigns a value to a variable.|  
|<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>|[Automatic Generalization and Generics](../vs140/automatic-generalization--fsharp-.md)|-   Delimits type parameters.|  
|<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>|[Arithmetic Operators](../vs140/arithmetic-operators--fsharp-.md)|-   Returns <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> if the left side is not equal to the right side; otherwise, returns false.|  
|<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>|[Nullable Operators](../vs140/nullable-operators--fsharp-.md)|1.  Computes the "not equal" operation when the right side is a nullable type.|  
|<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>|[Arithmetic Operators](../vs140/arithmetic-operators--fsharp-.md)|-   Returns <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> if the left side is less than or equal to the right side; otherwise, returns false.|  
|<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>|[Nullable Operators](../vs140/nullable-operators--fsharp-.md)|1.  Computes the "less than or equal to" operation when the right side is a nullable type.|  
|<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>|[Functions](../vs140/functions--fsharp-.md)|-   Passes the result of the expression on the right side to the function on left side (backward pipe operator).|  
|<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>|[Operators.( <&#124;&#124; )\<'T1,'T2,'U> Function (F#)](../vs140/operators.---------t1--t2--u--function--fsharp-.md)|-   Passes the tuple of two arguments on the right side to the function on left side.|  
|<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>|[Operators.( <&#124;&#124;&#124; )\<'T1,'T2,'T3,'U> Function (F#)](../vs140/operators.----------t1--t2--t3--u--function--fsharp-.md)|-   Passes the tuple of three arguments on the right side to the function on left side.|  
|<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>|[Code Quotations](../vs140/code-quotations--fsharp-.md)|-   Delimits a typed code quotation.|  
|<CodeContentPlaceHolder>64\</CodeContentPlaceHolder>|[Code Quotations](../vs140/code-quotations--fsharp-.md)|-   Delimits an untyped code quotation.|  
|<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>|[Arithmetic Operators](../vs140/arithmetic-operators--fsharp-.md)|-   Returns <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> if the left side is equal to the right side; otherwise, returns false.|  
|<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>|[Nullable Operators](../vs140/nullable-operators--fsharp-.md)|1.  Computes the "equal" operation when the right side is a nullable type.|  
|<CodeContentPlaceHolder>68\</CodeContentPlaceHolder>|Not applicable.|-   Not used in F#. Use <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> for equality operations.|  
|<CodeContentPlaceHolder>70\</CodeContentPlaceHolder>|[Arithmetic Operators](../vs140/arithmetic-operators--fsharp-.md)|-   Returns <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> if the left side is greater than the right side; otherwise, returns false.|  
|<CodeContentPlaceHolder>72\</CodeContentPlaceHolder>|[Nullable Operators](../vs140/nullable-operators--fsharp-.md)|1.  Computes the "greather than" operation when the right side is a nullable type.|  
|<CodeContentPlaceHolder>73\</CodeContentPlaceHolder>|[Functions](../vs140/functions--fsharp-.md)|-   Composes two functions (forward composition operator).|  
|<CodeContentPlaceHolder>74\</CodeContentPlaceHolder>|[Bitwise Operators](../vs140/bitwise-operators--fsharp-.md)|-   Shifts bits in the quantity on the left side to the right by the number of places specified on the right side.|  
|<CodeContentPlaceHolder>75\</CodeContentPlaceHolder>|[Arithmetic Operators](../vs140/arithmetic-operators--fsharp-.md)|-   Returns <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> if the right side is greater than or equal to the left side; otherwise, returns false.|  
|<CodeContentPlaceHolder>77\</CodeContentPlaceHolder>|[Nullable Operators](../vs140/nullable-operators--fsharp-.md)|1.  Computes the "greater than or equal" operation when the right side is a nullable type.|  
|<CodeContentPlaceHolder>78\</CodeContentPlaceHolder>|[Passing Arguments](../vs140/parameters-and-arguments--fsharp-.md)|-   Specifies an optional argument.\<br />-   Used as an operator for dynamic method and property calls. You must provide your own implementation.|  
|<CodeContentPlaceHolder>79\</CodeContentPlaceHolder>|No more information available.|-   Used as an operator for setting dynamic properties. You must provide your own implementation.|  
|<CodeContentPlaceHolder>80\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>|[Nullable Operators](../vs140/nullable-operators--fsharp-.md)|1.  Equivalent to the corresponding operators without the ? prefix, where a nullable type is on the left.|  
|<CodeContentPlaceHolder>90\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>|[Nullable Operators](../vs140/nullable-operators--fsharp-.md)|1.  Equivalent to the corresponding operators without the ? suffix, where a nullable type is on the right.|  
|<CodeContentPlaceHolder>100\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>|[Nullable Operators](../vs140/nullable-operators--fsharp-.md)|1.  Equivalent to the corresponding operators without the surrounding question marks, where both sides are nullable types.|  
|<CodeContentPlaceHolder>110\</CodeContentPlaceHolder>|[Lists](../vs140/lists--fsharp-.md)\<br />\<br /> [Strings (F#)](../vs140/strings--fsharp-.md)|-   Concatenates two lists.\<br />-   When placed before a string literal, indicates that the string is to be interpreted verbatim, with no interpretation of escape characters.|  
|<CodeContentPlaceHolder>111\</CodeContentPlaceHolder>|[Lists](../vs140/lists--fsharp-.md)|-   Delimits the elements of a list.|  
|<CodeContentPlaceHolder>112\</CodeContentPlaceHolder>|[Arrays](../vs140/arrays--fsharp-.md)|-   Delimits the elements of an array.|  
|<CodeContentPlaceHolder>113\</CodeContentPlaceHolder>|[Attributes](../vs140/attributes--fsharp-.md)|-   Delimits an attribute.|  
|<CodeContentPlaceHolder>114\</CodeContentPlaceHolder>|[Strings (F#)](../vs140/strings--fsharp-.md)|-   Escapes the next character; used in character and string literals.|  
|<CodeContentPlaceHolder>115\</CodeContentPlaceHolder>|[Statically Resolved Type Parameters](../vs140/statically-resolved-type-parameters--fsharp-.md)\<br />\<br /> [Strings](../vs140/strings--fsharp-.md)|-   Specifies type parameters that must be resolved at compile time, not at runtime.\<br />-   Concatenates strings.|  
|<CodeContentPlaceHolder>116\</CodeContentPlaceHolder>|[Bitwise Operators](../vs140/bitwise-operators--fsharp-.md)|-   Computes the bitwise exclusive OR operation.|  
|<CodeContentPlaceHolder>117\</CodeContentPlaceHolder>|[Pattern Matching: The match .. with Expression](../vs140/match-expressions--fsharp-.md)\<br />\<br /> [Generics](../vs140/generics--fsharp-.md)|-   Indicates a wildcard pattern.\<br />-   Specifies an anonymous generic parameter.|  
|<CodeContentPlaceHolder>118\</CodeContentPlaceHolder>op<CodeContentPlaceHolder>119\</CodeContentPlaceHolder>><CodeContentPlaceHolder>120\</CodeContentPlaceHolder>op<CodeContentPlaceHolder>121\</CodeContentPlaceHolder>&<CodeContentPlaceHolder>122\</CodeContentPlaceHolder>op<CodeContentPlaceHolder>123\</CodeContentPlaceHolder>*<CodeContentPlaceHolder>124\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>125\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>|Left|  
|<CodeContentPlaceHolder>127\</CodeContentPlaceHolder> <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>|Right|  
|<CodeContentPlaceHolder>129\</CodeContentPlaceHolder> (function application)|Left|  
|<CodeContentPlaceHolder>130\</CodeContentPlaceHolder> (pattern match)|Right|  
|prefix operators (+<CodeContentPlaceHolder>131\</CodeContentPlaceHolder>, -<CodeContentPlaceHolder>132\</CodeContentPlaceHolder>, %, %%, &, &&, !<CodeContentPlaceHolder>133\</CodeContentPlaceHolder>, ~<CodeContentPlaceHolder>134\</CodeContentPlaceHolder>)|Left|  
|<CodeContentPlaceHolder>135\</CodeContentPlaceHolder>|Left|  
|<CodeContentPlaceHolder>136\</CodeContentPlaceHolder>|Left|  
|<CodeContentPlaceHolder>137\</CodeContentPlaceHolder> <CodeContentPlaceHolder>138\</CodeContentPlaceHolder> <CodeContentPlaceHolder>139\</CodeContentPlaceHolder>|Left|  
  
 F# supports custom operator overloading. This means that you can define your own operators. In the previous table, <CodeContentPlaceHolder>140\</CodeContentPlaceHolder> can be any valid (possibly empty) sequence of operator characters, either built-in or user-defined. Thus, you can use this table to determine what sequence of characters to use for a custom operator to achieve the desired level of precedence. Leading <CodeContentPlaceHolder>141\</CodeContentPlaceHolder> characters are ignored when the compiler determines precedence.  
  
## See Also  
 [F# Language Reference](../vs140/fsharp-language-reference.md)   
 [Operator Overloading](../vs140/operator-overloading--fsharp-.md)