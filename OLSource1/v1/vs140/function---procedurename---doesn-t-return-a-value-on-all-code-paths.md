---
title: "Function &#39;&lt;procedurename&gt;&#39; doesn&#39;t return a value on all code paths"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "bc42105"
  - "vbc42105"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "BC42105"
ms.assetid: b6929bf4-a365-4a70-8dc9-6b0fc09e1468
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Function &#39;&lt;procedurename&gt;&#39; doesn&#39;t return a value on all code paths
Function '<procedurename\>' doesn't return a value on all code paths. Are you missing a 'Return' statement?  
  
 A `Function` procedure has at least one possible path through its code that does not return a value.  
  
 You can return a value from a `Function` procedure in any of the following ways:  
  
-   Include the value in a [Return Statement (Visual Basic)](../vs140/return-statement--visual-basic-.md).  
  
-   Assign the value to the `Function` procedure name and then perform an `Exit Function` statement.  
  
-   Assign the value to the `Function` procedure name and then perform the `End Function` statement.  
  
 If control passes to `Exit Function` or `End Function` and you have not assigned any value to the procedure name, the procedure returns the default value of the return data type. For more information, see "Behavior" in [Function Statement (Visual Basic)](../vs140/function-statement--visual-basic-.md).  
  
 By default, this message is a warning. For more information on hiding warnings or treating warnings as errors, see [Configuring Warnings in Visual Basic](../vs140/configuring-warnings-in-visual-basic.md).  
  
 **Error ID:** BC42105  
  
### To correct this error  
  
-   Check your control flow logic and make sure you assign a value before every statement that causes a return.  
  
     It is easier to guarantee that every return from the procedure returns a value if you always use the `Return` statement. If you do this, the last statement before `End Function` should be a `Return` statement.  
  
## See Also  
 [Function Procedures](../vs140/function-procedures--visual-basic-.md)   
 [Function Statement (Visual Basic)](../vs140/function-statement--visual-basic-.md)   
 [Compile Page, Project Designer (Visual Basic)](../vs140/compile-page--project-designer--visual-basic-.md)