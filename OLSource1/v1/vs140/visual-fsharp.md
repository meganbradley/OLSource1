---
title: "Visual F#"
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
  - "Visual F#"
  - "F#"
  - "functional programming"
  - "Visual F#, about"
ms.assetid: 66f52f8a-a034-4c32-bb83-fa5b030faa4d
caps.latest.revision: 52
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Visual F#
F# is a programming language that provides support for functional programming in addition to traditional object-oriented and imperative (procedural) programming. The Visual F# product provides support for developing F# applications and extending other .NET Framework applications by using F# code. F# is a first-class member of the .NET Framework languages and retains a strong resemblance to the ML family of functional languages.  
  
 This version of Visual F# contains the F# 3.1 version of the language.  
  
## Multiple-Paradigm Language  
 F# supports functional programming constructs such as the following:  
  
-   Functions as values, which enables flexible manipulation of functions. For more information, see [Functions as First-Class Values](../vs140/functions-as-first-class-values--fsharp-.md).  
  
-   Function composition and pipelining, which enables you to combine functions together to create new functions and to simplify the coding of successive operations on data. For more information, see [Functions (F#)](../vs140/functions--fsharp-.md).  
  
-   [Type inference](../vs140/type-inference--fsharp-.md), which reduces the requirement to explicitly call out types without sacrificing type safety.  
  
-   [Automatic generalization](../vs140/automatic-generalization--fsharp-.md), which promotes code reuse by making it easy to write code that works with a variety of different types without any additional effort.  
  
-   [Pattern matching](../vs140/match-expressions--fsharp-.md) support, which simplifies complex conditional code, and [discriminated unions](../vs140/discriminated-unions--fsharp-.md), which are optimized to be used with pattern matching.  
  
-   Collection types for working with immutable data, including [list](../vs140/lists--fsharp-.md) and [sequence](../vs140/sequences--fsharp-.md) types.  
  
-   [Lambda expressions](../vs140/lambda-expressions--the-fun-keyword--fsharp-.md), which are important to many functional programming constructs.  
  
-   Partial application of function arguments, which enables you to create new functions implicitly from existing ones. For more information, see [Functions (F#)](../vs140/functions--fsharp-.md).  
  
-   [Code Quotations](../vs140/code-quotations--fsharp-.md), a feature that enables you to manipulate F# expressions programmatically.  
  
 F# supports object-oriented programming and .NET Framework capabilities such as the following:  
  
-   The .NET Framework object model, including objects that have properties, methods, and events; polymorphism or virtual functions; inheritance; and interfaces.  
  
-   Data encapsulation, or separating the public interface of a type from the implementation.  
  
-   [Operator overloading](../vs140/operator-overloading--fsharp-.md) that works well with generics and built-in primitive types.  
  
-   [Type extensions](../vs140/type-extensions--fsharp-.md), which enable you to extend an existing type easily without the additional overhead work of creating a new derived type.  
  
-   [Object expressions](../vs140/object-expressions--fsharp-.md), which enable you to define small objects implicitly in expressions as needed, instead of declaring a new type and instantiating an object.  
  
-   Access to the .NET Framework and any managed code assembly.  
  
-   Access to native code through platform invoke.  
  
 Visual F# supports information-rich programming. This technology lets you program directly against rich spaces of data and services that often dominate enterprise and web programming today, such as databases, web services, web data feeds, and data brokers.  
  
 F# information-rich programming is code-focused and can be used in both scripts and projects. It also allows you to specify OData and SQL Server database connections directly in your code, while giving strong types with IntelliSense assistance. The mechanism is extensible, allowing you to write or reference new providers for data, code, and service technologies such as SharePoint, web ontologies, Windows Management Instrumentation (WMI), XML, and other information sources. Technically, F# information-rich programming includes the [F# Type Providers](../vs140/type-providers.md) mechanism, [F# Query Expressions](../vs140/query-expressions--fsharp-.md), and a set of built-in type providers for database, OData, and web service programming.  
  
 F# also supports all the common imperative programming constructs, such as branching and looping constructs.  
  
## F# Libraries  
 The Visual F# product also includes an [F# library](../vs140/fsharp-core-library-reference.md) that has many useful functions and types. This includes APIs for collections such as [lists](../vs140/lists--fsharp-.md), [arrays](../vs140/arrays--fsharp-.md), [maps](../vs140/collections.map--key--value--class--fsharp-.md), [sets](../vs140/collections.set--t--class--fsharp-.md), and [sequences](../vs140/sequences--fsharp-.md). The F# library also supports reflection, events, and formatted I/O.  
  
 In addition, the F# library includes support for asynchronous workflows to support parallel computations, and mechanisms for communicating among parallel workflows. For more information, see [Asynchronous Workflows](../vs140/asynchronous-workflows--fsharp-.md), [Control.Async Class (F#)](../vs140/control.async-class--fsharp-.md), and [Control.MailboxProcessor<'Msg> Class](../vs140/control.mailboxprocessor--msg--class--fsharp-.md).  
  
 The main F# library is FSharp.Core.dll. Additional libraries are available in the F# PowerPack, which is available on the [Microsoft F# Developer Center](http://go.microsoft.com/fwlink/?LinkId=145209) Web site.  
  
 Separately compiled versions of the F# Core library exist that support different versions of the .NET Framework. The 2.0 version supports the .NET Framework 2.0, 3.0 and 3.5 and the 4.0 version supports the .NET Framework 4 and later versions of the .NET Framework. In addition, versions of the F# Core Library for Silverlight are available for download.  
  
## Interactive Scripting  
 Visual F# provides an interactive window that is integrated into the Visual Studio development environment. This window enables you to enter F# code and have it immediately compiled and executed. This enables you to easily prototype code constructs and test your code while you write it. The interactive window runs the F# interactive tool, fsi.exe, which you can also run from the command line. This feature allows F# to be used as a scripting language. For more information, see [F# Interactive Reference](../vs140/fsharp-interactive--fsi.exe--reference.md).  
  
## Integration with Visual Studio  
 F# is integrated with Visual Studio, and has support for the following:  
  
-   Projects, including templates for common project types. For more information, see [Writing F# Programs with Visual Studio](../vs140/using-visual-studio-to-write-fsharp-programs.md) and [Configuring Projects](../vs140/configuring-projects--fsharp-.md).  
  
-   IntelliSense. For more information, see [Using IntelliSense](../vs140/using-intellisense.md).  
  
-   Debugging. For more information, see [Debugging in Visual Studio](../vs140/debugging-in-visual-studio.md).  
  
-   For more information, see [F# Development Environment Features](../vs140/fsharp-development-environment-features.md).  
  
## Related Topics  
  
|Title|Description|  
|-----------|-----------------|  
|[Visual F# Development Portal](../vs140/visual-fsharp-development-portal.md)|A gateway to a wide variety of information about F#.|  
|[Writing F# Programs with Visual Studio](../vs140/using-visual-studio-to-write-fsharp-programs.md)|Provides information about using F# in the Integrated Development Environment (IDE), including project settings and IntelliSense.|  
|[F# Language Reference](../vs140/fsharp-language-reference.md)|Provides reference information about the F# language, including information about keywords, symbols, and operators.|  
|[F# Core Library Reference](../vs140/fsharp-core-library-reference.md)|Provides reference information about the F# core library, FSharp.Core.dll.|  
|[F# Compiler (fsc.exe) Reference](../vs140/fsharp-compiler--fsc.exe--reference.md)|Provides information about the F# compiler, fsc.exe, including information about compiler options.|  
|[F# Interpreter (fsi.exe) Reference](../vs140/fsharp-interactive--fsi.exe--reference.md)|Provides information about F# Interactive, fsi.exe, including information about command-line options and diagnostic messages that are specific to F# Interactive.|  
|[Samples and Walkthroughs (F#)](../vs140/visual-fsharp-samples-and-walkthroughs.md)|Provides links to F# samples and walkthroughs.|  
  
## See Also  
 [Visual Studio](../vs140/welcome-to-visual-studio-2015.md)