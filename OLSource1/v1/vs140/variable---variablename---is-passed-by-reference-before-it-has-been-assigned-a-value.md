---
title: "Variable &#39;&lt;variablename&gt;&#39; is passed by reference before it has been assigned a value"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vbc42030"
  - "BC42030"
helpviewer_keywords: 
  - "BC42030"
ms.assetid: 8f1aae99-f032-4fdf-b6dc-3360cc5b94de
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Variable &#39;&lt;variablename&gt;&#39; is passed by reference before it has been assigned a value
Variable '\<variablename>' is passed by reference before it has been assigned a value. A null reference exception could result at run time.  
  
 A procedure call passes a variable as an argument to a `ByRef` parameter before any value is assigned to the variable.  
  
 If a variable has never been assigned a value, it holds the default value for its data type. For a reference data type, that default value is [Nothing (Visual Basic)](../vs140/nothing--visual-basic-.md). Reading a reference variable that has a value of `Nothing` can cause a \<xref:System.NullReferenceException*> in some circumstances.  
  
 Passing an argument to a procedure `ByRef` exposes the variable underlying the argument to possible modification by the procedure.  
  
 By default, this message is a warning. For more information about hiding warnings or treating warnings as errors, see [Configuring Warnings in Visual Basic](../vs140/configuring-warnings-in-visual-basic.md).  
  
 **Error ID:** BC42030  
  
### To correct this error  
  
-   If you intend the procedure to assign a value to the variable through the `ByRef` argument, and if it does not matter whether the variable already holds a value, then no action is necessary.  
  
-   If the logic in the procedure reads the argument before assigning any value to it, and if the variable is of a value type, then make sure that the procedure logic does not depend on whether the variable holds its default value or not.  
  
-   If the logic in the procedure reads the argument before assigning any value to it, and if the variable is of a reference type, then make sure that the procedure logic can handle a value of `Nothing`. For example, it could use a [Try...Catch...Finally Statement (Visual Basic)](../vs140/try...catch...finally-statement--visual-basic-.md) to catch a \<xref:System.NullReferenceException*>.  
  
## See Also  
 [Dim Statement (Visual Basic)](../vs140/dim-statement--visual-basic-.md)   
 [Value Types and Reference Types](../vs140/value-types-and-reference-types.md)   
 [Argument Passing By Value and By Reference](../vs140/passing-arguments-by-value-and-by-reference--visual-basic-.md)   
 [ByRef](../vs140/byref--visual-basic-.md)   
 [Variable Declaration in Visual Basic](../vs140/variable-declaration-in-visual-basic.md)   
 [Troubleshooting Variables in Visual Basic](../vs140/troubleshooting-variables-in-visual-basic.md)