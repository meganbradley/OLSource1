---
title: "Options (F#)"
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
  - "options [F#]"
  - "None [F#]"
  - "Some [F#]"
ms.assetid: eac1901d-9a03-475d-8479-73f5797c6694
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Options (F#)
The option type in F# is used when an actual value might not exist for a named value or variable. An option has an underlying type and can hold a value of that type, or it might not have a value.  
  
## Remarks  
 The following code illustrates the use of the option type.  
  
 [!code[FsLangRef1#1404](../VS_csharp/codesnippet/FSharp/options--fsharp-_1.fs)]  
  
 The value `None` is used when an option does not have an actual value. Otherwise, the expression `Some( ... )` gives the option a value. The values `Some` and `None` are useful in pattern matching, as in the following function `exists`, which returns `true` if the option has a value and `false` if it does not.  
  
 [!code[FsLangRef1#1401](../VS_csharp/codesnippet/FSharp/options--fsharp-_2.fs)]  
  
## Using Options  
 Options are commonly used when a search does not return a matching result, as shown in the following code.  
  
 [!code[FsLangRef1#1403](../VS_csharp/codesnippet/FSharp/options--fsharp-_3.fs)]  
  
 In the previous code, a list is searched recursively. The function `tryFindMatch` takes a predicate function `pred` that returns a Boolean value, and a list to search. If an element that satisfies the predicate is found, the recursion ends and the function returns the value as an option in the expression `Some(head)`. The recursion ends when the empty list is matched. At that point the value `head` has not been found, and `None` is returned.  
  
 Many F# library functions that search a collection for a value that may or may not exist return the `option` type. By convention, these functions begin with the `try` prefix, for example, [Seq.tryFindIndex](../VS_csharp/seq.tryfindindex--t--function--fsharp-.md).  
  
 Options can also be useful when a value might not exist, for example if it is possible that an exception will be thrown when you try to construct a value. The following code example illustrates this.  
  
 [!code[FsLangRef1#1402](../VS_csharp/codesnippet/FSharp/options--fsharp-_4.fs)]  
  
 The `openFile` function in the previous example has type `string -> File option` because it returns a `File` object if the file opens successfully and `None` if an exception occurs. Depending on the situation, it may not be an appropriate design choice to catch an exception rather than allowing it to propagate.  
  
## Option Properties and Methods  
 The option type supports the following properties and methods.  
  
|Property or method|Type|Description|  
|------------------------|----------|-----------------|  
|[None](../VS_csharp/option.none--t--property--fsharp-.md)|`'T option`|A static property that enables you to create an option value that has the `None` value.|  
|[IsNone](../VS_csharp/option.isnone--t--property--fsharp-.md)|`bool`|Returns `true` if the option has the `None` value.|  
|[IsSome](../VS_csharp/option.issome--t--property--fsharp-.md)|`bool`|Returns `true` if the option has a value that is not `None`.|  
|[Some](../VS_csharp/option.some--t--method--fsharp-.md)|`'T option`|A static member that creates an option that has a value that is not `None`.|  
|[Value](../VS_csharp/option.value--t--property--fsharp-.md)|`'T`|Returns the underlying value, or throws a <xref:System.NullReferenceException*> if the value is `None`.|  
  
## Option Module  
 There is a module, [Option](../VS_csharp/core.option-module--fsharp-.md), that contains useful functions that perform operations on options. Some functions repeat the functionality of the properties but are useful in contexts where a function is needed. [Option.isSome](../VS_csharp/option.issome--t--function--fsharp-.md) and [Option.isNone](../VS_csharp/option.isnone--t--function--fsharp-.md) are both module functions that test whether an option holds a value. [Option.get](../VS_csharp/option.get--t--function--fsharp-.md) obtains the value, if there is one. If there is no value, it throws <xref:System.ArgumentException*>.  
  
 The [Option.bind](../VS_csharp/option.bind--t--u--function--fsharp-.md) function executes a function on the value, if there is a value. The function must take exactly one argument, and its parameter type must be the option type. The return value of the function is another option type.  
  
 The option module also includes functions that correspond to the functions that are available for lists, arrays, sequences, and other collection types. These functions include [Option.map](../VS_csharp/option.map--t--u--function--fsharp-.md), [Option.iter](../VS_csharp/option.iter--t--function--fsharp-.md), [Option.forall](../VS_csharp/option.forall--t--function--fsharp-.md), [Option.exists](../VS_csharp/option.exists--t--function--fsharp-.md), [Option.foldBack](../VS_csharp/option.foldback--t--state--function--fsharp-.md), [Option.fold](../VS_csharp/option.fold--t--state--function--fsharp-.md), and [Option.count](../VS_csharp/option.count--t--function--fsharp-.md). These functions enable options to be used like a collection of zero or one elements. For more information and examples, see the discussion of collection functions in [Lists](../VS_csharp/lists--fsharp-.md).  
  
## Converting to Other Types  
 Options can be converted to lists or arrays. When an option is converted into either of these data structures, the resulting data structure has zero or one element. To convert an option to an array, use [Option.toArray](../VS_csharp/option.toarray--t--function--fsharp-.md). To convert an option to a list, use [Option.toList](../VS_csharp/option.tolist--t--function--fsharp-.md).  
  
## See Also  
 [F# Language Reference](../VS_csharp/fsharp-language-reference.md)   
 [F# Types](../VS_csharp/fsharp-types.md)