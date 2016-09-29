---
title: "Active Patterns (F#)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "active patterns [F#]"
ms.assetid: f265ecd6-7c6b-4d83-b80f-1664ff33fb76
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Active Patterns (F#)
*Active patterns* enable you to define named partitions that subdivide input data, so that you can use these names in a pattern matching expression just as you would for a discriminated union. You can use active patterns to decompose data in a customized manner for each partition.  
  
## Syntax  
  
```  
// Complete active pattern definition.  
let (|identifer1|identifier2|...|) [ arguments ] = expression  
// Partial active pattern definition.  
let (|identifier|_|) [ arguments ] = expression  
```  
  
## Remarks  
 In the previous syntax, the identifiers are names for partitions of the input data that is represented by `arguments`, or, in other words, names for subsets of the set of all values of the arguments. There can be up to seven partitions in an active pattern definition. The `expression` describes the form into which to decompose the data. You can use an active pattern definition to define the rules for determining which of the named partitions the values given as arguments belong to. The (&#124; and &#124;) symbols are referred to as *banana clips* and the function created by this type of let binding is called an *active recognizer*.  
  
 As an example, consider the following active pattern with an argument.  
  
 [!code[FsLangRef2#5001](../vs140/codesnippet/FSharp/active-patterns--fsharp-_1.fs)]  
  
 You can use the active pattern in a pattern matching expression, as in the following example.  
  
 [!code[FsLangRef2#5002](../vs140/codesnippet/FSharp/active-patterns--fsharp-_2.fs)]  
  
 The output of this program is as follows:  
  
```  
7 is odd  
11 is odd  
32 is even  
```  
  
 Another use of active patterns is to decompose data types in multiple ways, such as when the same underlying data has various possible representations. For example, a `Color` object could be decomposed into an RGB representation or an HSB representation.  
  
 [!code[FsLangRef2#5003](../vs140/codesnippet/FSharp/active-patterns--fsharp-_3.fs)]  
  
 The output of the above program is as follows:  
  
```  
Red  
 R: 255 G: 0 B: 0  
 H: 0.000000 S: 1.000000 B: 0.500000  
Black  
 R: 0 G: 0 B: 0  
 H: 0.000000 S: 0.000000 B: 0.000000  
White  
 R: 255 G: 255 B: 255  
 H: 0.000000 S: 0.000000 B: 1.000000  
Gray  
 R: 128 G: 128 B: 128  
 H: 0.000000 S: 0.000000 B: 0.501961  
BlanchedAlmond  
 R: 255 G: 235 B: 205  
 H: 36.000000 S: 1.000000 B: 0.901961  
```  
  
 In combination, these two ways of using active patterns enable you to partition and decompose data into just the appropriate form and perform the appropriate computations on the appropriate data in the form most convenient for the computation.  
  
 The resulting pattern matching expressions enable data to be written in a convenient way that is very readable, greatly simplifying potentially complex branching and data analysis code.  
  
## Partial Active Patterns  
 Sometimes, you need to partition only part of the input space. In that case, you write a set of partial patterns each of which match some inputs but fail to match other inputs. Active patterns that do not always produce a value are called *partial active patterns*; they have a return value that is an option type. To define a partial active pattern, you use a wildcard character (_) at the end of the list of patterns inside the banana clips. The following code illustrates the use of a partial active pattern.  
  
 [!code[FsLangRef2#5004](../vs140/codesnippet/FSharp/active-patterns--fsharp-_4.fs)]  
  
 The output of the previous example is as follows:  
  
```  
1.100000 : Floating point  
0 : Integer  
0.000000 : Floating point  
10 : Integer  
Something else : Not matched.  
```  
  
 When using partial active patterns, sometimes the individual choices can be disjoint or mutually exclusive, but they need not be. In the following example, the pattern Square and the pattern Cube are not disjoint, because some numbers are both squares and cubes, such as 64. The following program prints out all integers up to 1000000 that are both squares and cubes.  
  
 [!code[FsLangRef2#5005](../vs140/codesnippet/FSharp/active-patterns--fsharp-_5.fs)]  
  
 The output is as follows:  
  
```  
1  
64  
729  
4096  
15625  
46656  
117649  
262144  
531441  
1000000  
```  
  
## Parameterized Active Patterns  
 Active patterns always take at least one argument for the item being matched, but they may take additional arguments as well, in which case the name *parameterized active pattern* applies. Additional arguments allow a general pattern to be specialized. For example, active patterns that use regular expressions to parse strings often include the regular expression as an extra parameter, as in the following code, which also uses the partial active pattern `Integer` defined in the previous code example. In this example, strings that use regular expressions for various date formats are given to customize the general ParseRegex active pattern. The Integer active pattern is used to convert the matched strings into integers that can be passed to the DateTime constructor.  
  
 [!code[FsLangRef2#5006](../vs140/codesnippet/FSharp/active-patterns--fsharp-_6.fs)]  
  
 The output of the previous code is as follows:  
  
```  
12/22/2008 12:00:00 AM 1/1/2009 12:00:00 AM 1/15/2008 12:00:00 AM 12/28/1995 12:00:00 AM  
```  
  
## See Also  
 [F# Language Reference](../vs140/fsharp-language-reference.md)   
 [Pattern Matching](../vs140/match-expressions--fsharp-.md)