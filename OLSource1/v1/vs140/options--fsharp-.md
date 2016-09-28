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
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Options (F#)
The option type in F# is used when an actual value might not exist for a named value or variable. An option has an underlying type and can hold a value of that type, or it might not have a value.  
  
## Remarks  
 The following code illustrates the use of the option type.  
  
 [!code[FsLangRef1#1404](../vs140/codesnippet/FSharp/options--fsharp-_1.fs)]  
  
 The value `None` is used when an option does not have an actual value. Otherwise, the expression `Some( ... )` gives the option a value. The values `Some` and `None` are useful in pattern matching, as in the following function `exists`, which returns `true` if the option has a value and `false` if it does not.  
  
 [!code[FsLangRef1#1401](../vs140/codesnippet/FSharp/options--fsharp-_2.fs)]  
  
## Using Options  
 Options are commonly used when a search does not return a matching result, as shown in the following code.  
  
 [!code[FsLangRef1#1403](../vs140/codesnippet/FSharp/options--fsharp-_3.fs)]  
  
 In the previous code, a list is searched recursively. The function `tryFindMatch` takes a predicate function `pred` that returns a Boolean value, and a list to search. If an element that satisfies the predicate is found, the recursion ends and the function returns the value as an option in the expression `Some(head)`. The recursion ends when the empty list is matched. At that point the value `head` has not been found, and `None` is returned.  
  
 Many F# library functions that search a collection for a value that may or may not exist return the `option` type. By convention, these functions begin with the `try` prefix, for example, [Seq.tryFindIndex](../vs140/seq.tryfindindex--t--function--fsharp-.md).  
  
 Options can also be useful when a value might not exist, for example if it is possible that an exception will be thrown when you try to construct a value. The following code example illustrates this.  
  
 [!code[FsLangRef1#1402](../vs140/codesnippet/FSharp/options--fsharp-_4.fs)]  
  
 The `openFile` function in the previous example has type `string -> File option` because it returns a `File` object if the file opens successfully and `None` if an exception occurs. Depending on the situation, it may not be an appropriate design choice to catch an exception rather than allowing it to propagate.  
  
## Option Properties and Methods  
 The option type supports the following properties and methods.  
  
|Property or method|Type|Description|  
|------------------------|----------|-----------------|  
|[None](../vs140/option.none--t--property--fsharp-.md)|`'T option`|A static property that enables you to create an option value that has the `None` value.|  
|[IsNone](../vs140/option.isnone--t--property--fsharp-.md)|`bool`|Returns `true` if the option has the `None` value.|  
|[IsSome](../vs140/option.issome--t--property--fsharp-.md)|`bool`|Returns `true` if the option has a value that is not `None`.|  
|[Some](../vs140/option.some--t--method--fsharp-.md)|`'T option`|A static member that creates an option that has a value that is not `None`.|  
|[Value](../vs140/option.value--t--property--fsharp-.md)|`'T`|Returns the underlying value, or throws a <xref:System.NullReferenceException*> if the value is `None`.|  
  
## Option Module  
 There is a module, [Option](../vs140/core.option-module--fsharp-.md), that contains useful functions that perform operations on options. Some functions repeat the functionality of the properties but are useful in contexts where a function is needed. [Option.isSome](../vs140/option.issome--t--function--fsharp-.md) and [Option.isNone](../vs140/option.isnone--t--function--fsharp-.md) are both module functions that test whether an option holds a value. [Option.get](../vs140/option.get--t--function--fsharp-.md) obtains the value, if there is one. If there is no value, it throws <xref:System.ArgumentException*>.  
  
 The [Option.bind](../vs140/option.bind--t--u--function--fsharp-.md) function executes a function on the value, if there is a value. The function must take exactly one argument, and its parameter type must be the option type. The return value of the function is another option type.  
  
 The option module also includes functions that correspond to the functions that are available for lists, arrays, sequences, and other collection types. These functions include [Option.map](../vs140/option.map--t--u--function--fsharp-.md), [Option.iter](../vs140/option.iter--t--function--fsharp-.md), [Option.forall](../vs140/option.forall--t--function--fsharp-.md), [Option.exists](../vs140/option.exists--t--function--fsharp-.md), [Option.foldBack](../vs140/option.foldback--t--state--function--fsharp-.md), [Option.fold](../vs140/option.fold--t--state--function--fsharp-.md), and [Option.count](../vs140/option.count--t--function--fsharp-.md). These functions enable options to be used like a collection of zero or one elements. For more information and examples, see the discussion of collection functions in [Lists](../vs140/lists--fsharp-.md).  
  
## Converting to Other Types  
 Options can be converted to lists or arrays. When an option is converted into either of these data structures, the resulting data structure has zero or one element. To convert an option to an array, use [Option.toArray](../vs140/option.toarray--t--function--fsharp-.md). To convert an option to a list, use [Option.toList](../vs140/option.tolist--t--function--fsharp-.md).  
  
## See Also  
 [F# Language Reference](../vs140/fsharp-language-reference.md)   
 [F# Types](../vs140/fsharp-types.md)