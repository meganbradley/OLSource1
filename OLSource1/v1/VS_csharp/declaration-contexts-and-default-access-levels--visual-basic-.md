---
title: "Declaration Contexts and Default Access Levels (Visual Basic)"
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
  - "module level, defined"
  - "declaration contexts, Visual Basic"
  - "procedure level, defined"
  - "namespace level, defined"
  - "access levels, Visual Basic"
  - "access levels, default levels"
ms.assetid: bf63b96e-e825-4745-88c8-5dae222728db
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Declaration Contexts and Default Access Levels (Visual Basic)
This topic describes which Visual Basic types can be declared within which other types, and what their access levels default to if not specified.  
  
## Declaration Context Levels  
 The *declaration context* of a programming element is the region of code in which it is declared. This is often another programming element, which is then called the *containing element*.  
  
 The levels for declaration contexts are the following:  
  
-   *Namespace level* — within a source file or namespace but not within a class, structure, module, or interface  
  
-   *Module level* — within a class, structure, module, or interface but not within a procedure or block  
  
-   *Procedure level* — within a procedure or block (such as `If` or `For`)  
  
 The following table shows the default access levels for various declared programming elements, depending on their declaration contexts.  
  
|Declared element|Namespace level|Module level|Procedure level|  
|----------------------|---------------------|------------------|---------------------|  
|Variable ([Dim Statement](../VS_csharp/dim-statement--visual-basic-.md))|Not allowed|`Private` (`Public` in `Structure`, not allowed in `Interface`)|`Public`|  
|Constant ([Const Statement (Visual Basic)](../VS_csharp/const-statement--visual-basic-.md))|Not allowed|`Private` (`Public` in `Structure`, not allowed in `Interface`)|`Public`|  
|Enumeration ([Enum Statement (Visual Basic)](../VS_csharp/enum-statement--visual-basic-.md))|`Friend`|`Public`|Not allowed|  
|Class ([Class Statement (Visual Basic)](../VS_csharp/class-statement--visual-basic-.md))|`Friend`|`Public`|Not allowed|  
|Structure ([Structure Statement](../VS_csharp/structure-statement.md))|`Friend`|`Public`|Not allowed|  
|Module ([Module Statement](../VS_csharp/module-statement.md))|`Friend`|Not allowed|Not allowed|  
|Interface ([Interface Statement](../VS_csharp/interface-statement--visual-basic-.md))|`Friend`|`Public`|Not allowed|  
|Procedure ([Function Statement (Visual Basic)](../VS_csharp/function-statement--visual-basic-.md), [Sub Statement (Visual Basic)](../VS_csharp/sub-statement--visual-basic-.md))|Not allowed|`Public`|Not allowed|  
|External reference ([Declare Statement](../VS_csharp/declare-statement.md))|Not allowed|`Public` (not allowed in `Interface`)|Not allowed|  
|Operator ([Operator Statement](../VS_csharp/operator-statement.md))|Not allowed|`Public` (not allowed in `Interface` or `Module`)|Not allowed|  
|Property ([Property Statement](../VS_csharp/property-statement.md))|Not allowed|`Public`|Not allowed|  
|Default property ([Default (Visual Basic)](../VS_csharp/default--visual-basic-.md))|Not allowed|`Public` (not allowed in `Module`)|Not allowed|  
|Event ([Event Statement](../VS_csharp/event-statement.md))|Not allowed|`Public`|Not allowed|  
|Delegate ([Delegate Statement](../VS_csharp/delegate-statement.md))|`Friend`|`Public`|Not allowed|  
  
 For more information, see [Access Levels in Visual Basic](../VS_csharp/access-levels-in-visual-basic.md).  
  
## See Also  
 [Friend (Visual Basic)](../VS_csharp/friend--visual-basic-.md)   
 [Private (Visual Basic)](../VS_csharp/private--visual-basic-.md)   
 [Public (Visual Basic)](../VS_csharp/public--visual-basic-.md)