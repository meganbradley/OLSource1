---
title: "Structure of a Visual Basic Program"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "conditional compilation, Visual Basic"
  - "program structure, Visual Basic"
  - "procedures, structure"
  - "Visual Basic code, program structure"
ms.assetid: ad0c6531-d762-4c77-a700-de16b07b6119
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Structure of a Visual Basic Program
A [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] program is built up from standard building blocks. A *solution* comprises one or more projects. A *project* in turn can contain one or more assemblies. Each *assembly* is compiled from one or more source files. A *source file* provides the definition and implementation of classes, structures, modules, and interfaces, which ultimately contain all your code.  
  
 For more information about these building blocks of a [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] program, see [Introduction to Solutions, Projects, and Items](../vs140/solutions-and-projects-in-visual-studio.md) and [Assemblies and the Global Assembly Cache (C# and Visual Basic)](../vs140/assemblies-and-the-global-assembly-cache--csharp-and-visual-basic-.md).  
  
## File-Level Programming Elements  
 When you start a project or file and open the code editor, you see some code already in place and in the correct order. Any code that you write should follow the following sequence:  
  
1.  `Option` statements  
  
2.  `Imports` statements  
  
3.  `Namespace` statements and namespace-level elements  
  
 If you enter statements in a different order, compilation errors can result.  
  
 A program can also contain conditional compilation statements. You can intersperse these in the source file among the statements of the preceding sequence.  
  
### Option Statements  
 `Option` statements establish ground rules for subsequent code, helping prevent syntax and logic errors. The [Option Explicit Statement](../vs140/option-explicit-statement--visual-basic-.md) ensures that all variables are declared and spelled correctly, which reduces debugging time. The [Option Strict Statement](../vs140/option-strict-statement.md) helps to minimize logic errors and data loss that can occur when you work between variables of different data types. The [Option Compare Statement](../vs140/option-compare-statement.md) specifies the way strings are compared to each other, based on either their `Binary` or `Text` values.  
  
### Imports Statements  
 You can include an [Imports Statement (.NET Namespace and Type)](../vs140/imports-statement--.net-namespace-and-type-.md) to import names defined outside your project. An `Imports` statement allows your code to refer to classes and other types defined within the imported namespace, without having to qualify them. You can use as many `Imports` statements as appropriate. For more information, see [References and the Imports Statement](../vs140/references-and-the-imports-statement--visual-basic-.md).  
  
### Namespace Statements  
 Namespaces help you organize and classify your programming elements for ease of grouping and accessing. You use the [Namespace Statement](../vs140/namespace-statement.md) to classify the following statements within a particular namespace. For more information, see [Namespaces in Visual Basic](../vs140/namespaces-in-visual-basic.md).  
  
### Conditional Compilation Statements  
 Conditional compilation statements can appear almost anywhere in your source file. They cause parts of your code to be included or excluded at compile time depending on certain conditions. You can also use them for debugging your application, because conditional code runs in debugging mode only. For more information, see [Conditional Compilation](../vs140/conditional-compilation-in-visual-basic.md).  
  
## Namespace-Level Programming Elements  
 Classes, structures, and modules contain all the code in your source file. They are *namespace-level* elements, which can appear within a namespace or at the source file level. They hold the declarations of all other programming elements. Interfaces, which define element signatures but provide no implementation, also appear at module level. For more information on the module-level elements, see the following:  
  
-   [Class Statement](../vs140/class-statement--visual-basic-.md)  
  
-   [Structure Statement](../vs140/structure-statement.md)  
  
-   [Module Statement](../vs140/module-statement.md)  
  
-   [Interface Statement (Visual Basic)](../vs140/interface-statement--visual-basic-.md)  
  
 Data elements at namespace level are enumerations and delegates.  
  
## Module-Level Programming Elements  
 Procedures, operators, properties, and events are the only programming elements that can hold executable code (statements that perform actions at run time). They are the *module-level* elements of your program. For more information on the procedure-level elements, see the following:  
  
-   [Function Statement (Visual Basic)](../vs140/function-statement--visual-basic-.md)  
  
-   [Sub Statement](../vs140/sub-statement--visual-basic-.md)  
  
-   [Declare Statement](../vs140/declare-statement.md)  
  
-   [Operator Statement](../vs140/operator-statement.md)  
  
-   [Property Statement](../vs140/property-statement.md)  
  
-   [Event Statement](../vs140/event-statement.md)  
  
 Data elements at module level are variables, constants, enumerations, and delegates.  
  
## Procedure-Level Programming Elements  
 Most of the contents of *procedure-level* elements are executable statements, which constitute the run-time code of your program. All executable code must be in some procedure (`Function`, `Sub`, `Operator`, `Get`, `Set`, `AddHandler`, `RemoveHandler`, `RaiseEvent`). For more information, see [Statements in Visual Basic](../vs140/statements-in-visual-basic.md).  
  
 Data elements at procedure level are limited to local variables and constants.  
  
## The Main Procedure  
 The `Main` procedure is the first code to run when your application has been loaded. `Main` serves as the starting point and overall control for your application. There are four varieties of `Main`:  
  
-   `Sub Main()`  
  
-   `Sub Main(ByVal cmdArgs() As String)`  
  
-   `Function Main() As Integer`  
  
-   `Function Main(ByVal cmdArgs() As String) As Integer`  
  
 The most common variety of this procedure is `Sub Main()`. For more information, see [Main Procedure in Visual Basic](../vs140/main-procedure-in-visual-basic.md).  
  
## See Also  
 [NIB: Visual Basic Version of Hello, World](assetId:///9d030b60-e148-4366-a462-69532f02294c)   
 [Main Procedure in Visual Basic](../vs140/main-procedure-in-visual-basic.md)   
 [Visual Basic Naming Conventions](../vs140/visual-basic-naming-conventions.md)   
 [Visual Basic Limitations](../vs140/visual-basic-limitations.md)