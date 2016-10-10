---
title: "Structure of a Visual Basic Program"
ms.custom: na
ms.date: "10/10/2016"
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
caps.latest.revision: 17
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Structure of a Visual Basic Program
A [!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)] program is built up from standard building blocks. A *solution* comprises one or more projects. A *project* in turn can contain one or more assemblies. Each *assembly* is compiled from one or more source files. A *source file* provides the definition and implementation of classes, structures, modules, and interfaces, which ultimately contain all your code.  
  
 For more information about these building blocks of a [!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)] program, see [Solutions and Projects](../Topic/Solutions%20and%20Projects%20in%20Visual%20Studio.md) and [Assemblies and the Global Assembly Cache](../Topic/Assemblies%20and%20the%20Global%20Assembly%20Cache%20\(C%23%20and%20Visual%20Basic\).md).  
  
## File-Level Programming Elements  
 When you start a project or file and open the code editor, you see some code already in place and in the correct order. Any code that you write should follow the following sequence:  
  
1.  `Option` statements  
  
2.  `Imports` statements  
  
3.  `Namespace` statements and namespace-level elements  
  
 If you enter statements in a different order, compilation errors can result.  
  
 A program can also contain conditional compilation statements. You can intersperse these in the source file among the statements of the preceding sequence.  
  
### Option Statements  
 `Option` statements establish ground rules for subsequent code, helping prevent syntax and logic errors. The [Option Explicit Statement](../VS_visualbasic/option-explicit-statement--visual-basic-.md) ensures that all variables are declared and spelled correctly, which reduces debugging time. The [Option Strict Statement](../VS_visualbasic/option-strict-statement.md) helps to minimize logic errors and data loss that can occur when you work between variables of different data types. The [Option Compare Statement](../VS_visualbasic/option-compare-statement.md) specifies the way strings are compared to each other, based on either their `Binary` or `Text` values.  
  
### Imports Statements  
 You can include an [Imports Statement (.NET Namespace and Type)](../VS_visualbasic/imports-statement--.net-namespace-and-type-.md) to import names defined outside your project. An `Imports` statement allows your code to refer to classes and other types defined within the imported namespace, without having to qualify them. You can use as many `Imports` statements as appropriate. For more information, see [References and the Imports Statement](../VS_visualbasic/references-and-the-imports-statement--visual-basic-.md).  
  
### Namespace Statements  
 Namespaces help you organize and classify your programming elements for ease of grouping and accessing. You use the [Namespace Statement](../VS_visualbasic/namespace-statement.md) to classify the following statements within a particular namespace. For more information, see [Namespaces in Visual Basic](../VS_visualbasic/namespaces-in-visual-basic.md).  
  
### Conditional Compilation Statements  
 Conditional compilation statements can appear almost anywhere in your source file. They cause parts of your code to be included or excluded at compile time depending on certain conditions. You can also use them for debugging your application, because conditional code runs in debugging mode only. For more information, see [Conditional Compilation](../VS_visualbasic/conditional-compilation-in-visual-basic.md).  
  
## Namespace-Level Programming Elements  
 Classes, structures, and modules contain all the code in your source file. They are *namespace-level* elements, which can appear within a namespace or at the source file level. They hold the declarations of all other programming elements. Interfaces, which define element signatures but provide no implementation, also appear at module level. For more information on the module-level elements, see the following:  
  
-   [Class Statement](../VS_visualbasic/class-statement--visual-basic-.md)  
  
-   [Structure Statement](../VS_visualbasic/structure-statement.md)  
  
-   [Module Statement](../VS_visualbasic/module-statement.md)  
  
-   [Interface Statement](../VS_visualbasic/interface-statement--visual-basic-.md)  
  
 Data elements at namespace level are enumerations and delegates.  
  
## Module-Level Programming Elements  
 Procedures, operators, properties, and events are the only programming elements that can hold executable code (statements that perform actions at run time). They are the *module-level* elements of your program. For more information on the procedure-level elements, see the following:  
  
-   [Function Statement](../VS_visualbasic/function-statement--visual-basic-.md)  
  
-   [Sub Statement](../VS_visualbasic/sub-statement--visual-basic-.md)  
  
-   [Declare Statement](../VS_visualbasic/declare-statement.md)  
  
-   [Operator Statement](../VS_visualbasic/operator-statement.md)  
  
-   [Property Statement](../VS_visualbasic/property-statement.md)  
  
-   [Event Statement](../VS_visualbasic/event-statement.md)  
  
 Data elements at module level are variables, constants, enumerations, and delegates.  
  
## Procedure-Level Programming Elements  
 Most of the contents of *procedure-level* elements are executable statements, which constitute the run-time code of your program. All executable code must be in some procedure (`Function`, `Sub`, `Operator`, `Get`, `Set`, `AddHandler`, `RemoveHandler`, `RaiseEvent`). For more information, see [Statements](../VS_visualbasic/statements-in-visual-basic.md).  
  
 Data elements at procedure level are limited to local variables and constants.  
  
## The Main Procedure  
 The `Main` procedure is the first code to run when your application has been loaded. `Main` serves as the starting point and overall control for your application. There are four varieties of `Main`:  
  
-   `Sub Main()`  
  
-   `Sub Main(ByVal cmdArgs() As String)`  
  
-   `Function Main() As Integer`  
  
-   `Function Main(ByVal cmdArgs() As String) As Integer`  
  
 The most common variety of this procedure is `Sub Main()`. For more information, see [Main Procedure in Visual Basic](../VS_visualbasic/main-procedure-in-visual-basic.md).  
  
## See Also  
 [NIB: Visual Basic Version of Hello, World](assetId:///9d030b60-e148-4366-a462-69532f02294c)   
 [Main Procedure in Visual Basic](../VS_visualbasic/main-procedure-in-visual-basic.md)   
 [Visual Basic Naming Conventions](../VS_visualbasic/visual-basic-naming-conventions.md)   
 [Visual Basic Limitations](../VS_visualbasic/visual-basic-limitations.md)