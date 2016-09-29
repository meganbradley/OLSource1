---
title: "F# Language Reference"
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
  - "Visual F#, language"
  - "F# language"
ms.assetid: 16b706f8-b5f2-4ff7-b2c1-64df33cd6adf
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# F# Language Reference
This section is a reference to the F# language, a multi-paradigm programming language targeting the .NET platform. The F# language supports functional, object-oriented and imperative programming models.  
  
## F# Tokens  
 The following table shows reference topics that provide tables of keywords, symbols and literals used as tokens in F#.  
  
|Title|Description|  
|-----------|-----------------|  
|[Keyword Reference](../vs140/keyword-reference--fsharp-.md)|Contains links to information about all F# language keywords.|  
|[Symbol and Operator Reference](../vs140/symbol-and-operator-reference--fsharp-.md)|Contains a table of symbols and operators that are used in the F# language.|  
|[Literals](../vs140/literals--fsharp-.md)|Describes the syntax for literal values in F# and how to specify type information for F# literals.|  
  
## F# Language Concepts  
 The following table shows reference topics available that describe language concepts.  
  
|Title|Description|  
|-----------|-----------------|  
|[Functions](../vs140/functions--fsharp-.md)|Functions are the fundamental unit of program execution in any programming language. As in other languages, an F# function has a name, can have parameters and take arguments, and has a body. F# also supports functional programming constructs such as treating functions as values, using unnamed functions in expressions, composition of functions to form new functions, curried functions, and the implicit definition of functions by way of the partial application of function arguments.|  
|[Type System](../vs140/fsharp-types.md)|Describes the types that are used in F# and how F# types are named and described.|  
|[Type Inference](../vs140/type-inference--fsharp-.md)|Describes how the F# compiler infers the types of values, variables, parameters and return values.|  
|[Generics](../vs140/automatic-generalization--fsharp-.md)|Describes generic constructs in F#.|  
|[Inheritance](../vs140/inheritance--fsharp-.md)|Describes inheritance, which is used to model the "is-a" relationship, or subtyping, in object-oriented programming.|  
|[Members](../vs140/members--fsharp-.md)|Describes members of F# object types.|  
|[Parameters and Arguments](../vs140/parameters-and-arguments--fsharp-.md)|Describes language support for defining parameters and passing arguments to functions, methods, and properties. It includes information about how to pass by reference.|  
|[Operator Overloading](../vs140/operator-overloading--fsharp-.md)|Describes how to overload arithmetic operators in a class or record type, and at the global level.|  
|[Casting and Conversions](../vs140/casting-and-conversions--fsharp-.md)|Describes support for type conversions in F#.|  
|[Access Control](../vs140/access-control--fsharp-.md)|Describes access control in F#. Access control means declaring what clients are able to use certain program elements, such as types, methods, functions and so on.|  
|[Patterns](../vs140/pattern-matching--fsharp-.md)|Describes patterns, which are rules for transforming input data that are used throughout the F# language to extract compare data with a pattern, decompose data into constituent parts, or extract information from data in various ways.|  
|[Active Patterns](../vs140/active-patterns--fsharp-.md)|Describes active patterns. Active patterns enable you to define named partitions that subdivide input data. You can use active patterns to decompose data in a customized manner for each partition.|  
|[Assertions](../vs140/assertions--fsharp-.md)|Describes the `assert` expression, which is a debugging feature that you can use to test an expression. Upon failure in Debug mode, an assertion generates a system error dialog box.|  
|[Exception Handling](../vs140/exception-handling--fsharp-.md)|Contains information about exception handling support in the F# language.|  
|[Attributes](../vs140/attributes--fsharp-.md)|Describes attributes, which enable metadata to be applied to a programming construct.|  
|[Resource Management](../vs140/resource-management--the-use-keyword--fsharp-.md)|Describes the keywords `use` and `using`, which can control the initialization and release of resources|  
|[Namespaces](../vs140/namespaces--fsharp-.md)|Describes namespace support in F#. A namespace lets you organize code into areas of related functionality by enabling you to attach a name to a grouping of program elements.|  
|[Modules](../vs140/modules--fsharp-.md)|Describes modules. An F# module is a grouping of F# code, such as values, types, and function values, in an F# program. Grouping code in modules helps keep related code together and helps avoid name conflicts in your program.|  
|[Import Declarations: open Keyword](../vs140/import-declarations--the-open-keyword--fsharp-.md)|Describes how `open` works. An import declaration specifies a module or namespace whose elements you can reference without using a fully qualified name.|  
|[Signatures](../vs140/signatures--fsharp-.md)|Describes signatures and signature files. A signature file contains information about the public signatures of a set of F# program elements, such as types, namespaces, and modules. It can be used to specify the accessibility of these program elements.|  
|[XML Documentation](../vs140/xml-documentation--fsharp-.md)|Describes support for generating documentation files for XML doc comments, also known as triple slash comments. You can produce documentation from code comments in F# just as in other .NET languages.|  
|[Verbose Syntax](../vs140/verbose-syntax--fsharp-.md)|Describes the syntax for F# constructs when lightweight syntax is not enabled. Verbose syntax is indicated by the `#light "off"` directive at the top of the code file.|  
  
## F# Types  
 The following table shows reference topics available that describe types supported by the F# language.  
  
|Title|Description|  
|-----------|-----------------|  
|[Values](../vs140/values--fsharp-.md)|Describes values, which are immutable quantities that have a specific type; values can be integral or floating point numbers, characters or text, lists, sequences, arrays, tuples, discriminated unions, records, class types, or function values.|  
|[Primitive Types](../vs140/primitive-types--fsharp-.md)|Describes the fundamental primitive types that are used in the F# language. It also provides the corresponding .NET types and the minimum and maximum values for each type.|  
|[Unit Type](../vs140/unit-type--fsharp-.md)|Describes the `unit` type, which is a type that indicates the absence of a specific value; the `unit` type has only a single value, which acts as a placeholder when no other value exists or is needed.|  
|[Strings](../vs140/strings--fsharp-.md)|Describes strings in F#. The `string` type represents immutable text, as a sequence of Unicode characters. `string` is an alias for <xref:System.String*> in the .NET Framework.|  
|[Tuples](../vs140/tuples--fsharp-.md)|Describes tuples, which are groupings of unnamed but ordered values of possibly different types.|  
|[F# Collection Types](../vs140/fsharp-collection-types.md)|An overview of the F# functional collection types, including types for arrays, lists, sequences (seq), maps, and sets.|  
|[Lists](../vs140/lists--fsharp-.md)|Describes lists. A list in F# is an ordered, immutable series of elements all of the same type.|  
|[Options](../vs140/options--fsharp-.md)|Describes the option type. An option in F# is used when a value may or may not exist. An option has an underlying type and may either hold a value of that type or it may not have a value.|  
|[Sequences](../vs140/sequences--fsharp-.md)|Describes sequences. A sequence is a logical series of elements all of one type. Individual sequence elements are only computed if required, so the representation may be smaller than a literal element count indicates.|  
|[Arrays](../vs140/arrays--fsharp-.md)|Describes arrays. Arrays are fixed-size, zero-based, mutable sequences of consecutive data elements, all of the same type.|  
|[Records](../vs140/records--fsharp-.md)|Describes records. Records represent simple aggregates of named values, optionally with members.|  
|[Discriminated Unions](../vs140/discriminated-unions--fsharp-.md)|Describes discriminated unions, which provides support for values which may be one of a variety of named cases, each with possibly different values and types.|  
|[Enumerations](../vs140/enumerations--fsharp-.md)|Describes enumerations are types that have a defined set of named values. You can use them in place of literals to make code more readable and maintainable.|  
|[Reference Cells](../vs140/reference-cells--fsharp-.md)|Describes reference cells, which are storage locations that enable you to create mutable variables with reference semantics.|  
|[Type Abbreviations](../vs140/type-abbreviations--fsharp-.md)|Describes type abbreviations, which are alternate names for types.|  
|[Classes](../vs140/classes--fsharp-.md)|Describes classes, which are types that represent objects that can have properties, methods, and events.|  
|[Structures](../vs140/structures--fsharp-.md)|Describes structures, which are compact object types that can be more efficient than a class for types that have a small amount of data and simple behavior.|  
|[Interfaces](../vs140/interfaces--fsharp-.md)|Describes interfaces, which specify sets of related members that other classes implement.|  
|[Abstract Classes](../vs140/abstract-classes--fsharp-.md)|Describes abstract classes, which are classes that leave some or all members unimplemented, so that implementations can be provided by derived classes.|  
|[Type Extensions](../vs140/type-extensions--fsharp-.md)|Describes type extensions, which let you add new members to a previously defined object type.|  
|[Flexible Types](../vs140/flexible-types--fsharp-.md)|Describes flexible types. A flexible type annotation is an indication that a parameter, variable or value has a type that is compatible with type specified, where compatibility is determined by position in an object-oriented hierarchy of classes or interfaces.|  
|[Delegates](../vs140/delegates--fsharp-.md)|Describes delegates, which represent a function call as an object.|  
|[Units of Measure](../vs140/units-of-measure--fsharp-.md)|Describes units of measure. Floating point values in F# can have associated units of measure, which are typically used to indicate length, volume, mass, and so on.|  
|[Type Providers](../vs140/type-providers.md)|Describes type provides and provides links to walkthroughs on using the built-in type providers to access databases and web services.|  
  
## F# Expressions  
 The following table lists topics that describe F# expressions.  
  
|Title|Description|  
|-----------|-----------------|  
|[Conditional Expressions](../vs140/conditional-expressions--if...-then...else--fsharp-.md)|Describes the `if...then...else` expression, which runs different branches of code and also evaluates to a different value depending on the Boolean expression given.|  
|[Match Expression](../vs140/match-expressions--fsharp-.md)|Describes the `match` expression, which provides branching control that is based on the comparison of an expression with a set of patterns.|  
|[Loops: for .. to Expression](../vs140/loops--for...to-expression--fsharp-.md)|Describes the `for...to` expression, which is used to iterate in a loop over a range of values of a loop variable.|  
|[Loops: for .. in Expression](../vs140/loops--for...in-expression--fsharp-.md)|Describes the `for...in` expression, a looping construct that is used to iterate over the matches of a pattern in an enumerable collection such as a range expression, sequence, list, array, or other construct that supports enumeration.|  
|[Loops: while .. do Expression](../vs140/loops--while...do-expression--fsharp-.md)|Describes the `while...do` expression, which is used to perform iterative execution (looping) while a specified test condition is true.|  
|[Object Expressions](../vs140/object-expressions--fsharp-.md)|Describes object expressions, which are expressions that create new instances of a dynamically created, anonymous object type that is based on an existing base type, interface, or set of interfaces.|  
|[Lazy Computations](../vs140/lazy-computations--fsharp-.md)|Describes lazy computations, which are computations that are not evaluated immediately, but are instead evaluated when the result is actually needed.|  
|[Computation Expressions](../vs140/computation-expressions--fsharp-.md)|Describes computation expressions in F#, which provide a convenient syntax for writing computations that can be sequenced and combined using control flow constructs and bindings. They can be used to provide a convenient syntax for *monads*, a functional programming feature that can be used to manage data, control and side effects in functional programs. One type of computation expression, the asynchronous workflow, provides support for asynchronous and parallel computations. For more information, see [Asynchronous Workflows](../vs140/asynchronous-workflows--fsharp-.md).|  
|[Asynchronous Workflows](../vs140/asynchronous-workflows--fsharp-.md)|Describes asynchronous workflows, a language feature that lets you write asynchronous code in a way that is very close to the way you would naturally write synchronous code.|  
|[Code Quotations](../vs140/code-quotations--fsharp-.md)|Describes code quotations, a language feature that enables you to generate and work with F# code expressions programmatically.|  
|[Query Expressions (F#)](../vs140/query-expressions--fsharp-.md)|Describes query expressions, a language feature that implements LINQ for F# and enables you to write queries against a data source or enumerable collection.|  
  
## Compiler-supported Constructs  
 The following table lists topics that describe special compiler-supported constructs.  
  
|Topic|Description|  
|-----------|-----------------|  
|[Compiler Directives](../vs140/compiler-directives--fsharp-.md)|Describes processor directives and compiler directives.|  
|[Source Line, File, and Path Identifiers (F#)](../vs140/source-line--file--and-path-identifiers--fsharp-.md)|Describes the identifiers `__LINE__`, `__SOURCE_DIRECTORY__` and `__SOURCE_FILE__`, which are built-in values that enable you to access the source line number, directory and file name in your code.|  
  
## See Also  
 [Visual F#](../vs140/visual-fsharp.md)   
 [F# Compiler (fsc.exe) Reference](../vs140/fsharp-compiler--fsc.exe--reference.md)