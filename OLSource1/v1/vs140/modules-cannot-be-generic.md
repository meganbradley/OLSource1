---
title: "Modules cannot be generic"
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
  - "BC32073"
  - "vbc32073"
helpviewer_keywords: 
  - "BC32073"
ms.assetid: 47246e2b-51d4-4a10-a3ac-bc77b44fa2ca
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Modules cannot be generic
A `Module` statement uses the `Of` keyword to introduce generic type parameters.  
  
 You can define and use generic classes, structures, interfaces, procedures, and delegates. You cannot define generic modules.  
  
 **Error ID:** BC32073  
  
### To correct this error  
  
1.  Remove the `Of` keyword from the `Module` statement.  
  
2.  If you want the functionality of a generic module, the closest approximation is a generic class. Use a [Class Statement (Visual Basic)](../vs140/class-statement--visual-basic-.md) instead of a `Module` statement.  
  
## See Also  
 [Module Statement](../vs140/module-statement.md)   
 [Of](../vs140/of-clause--visual-basic-.md)   
 [Generic Types in Visual Basic](../vs140/generic-types-in-visual-basic--visual-basic-.md)   
 [How to: Define a Class That Can Provide Identical Functionality on Different Data Types](../vs140/how-to--define-a-class-that-can-provide-identical-functionality-on-different-data-types--visual-basic-.md)