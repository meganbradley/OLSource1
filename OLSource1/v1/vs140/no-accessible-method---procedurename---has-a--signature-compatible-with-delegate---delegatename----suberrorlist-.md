---
title: "No accessible method &#39;&lt;procedurename&gt;&#39; has a  signature compatible with delegate &#39;&lt;delegatename&gt;&#39;:&lt;suberrorlist&gt;"
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
  - "bc30950"
  - "vbc30950"
helpviewer_keywords: 
  - "BC30950"
ms.assetid: c1938099-2c03-491e-b599-d0c43bf94baf
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# No accessible method &#39;&lt;procedurename&gt;&#39; has a  signature compatible with delegate &#39;&lt;delegatename&gt;&#39;:&lt;suberrorlist&gt;
An assignment statement assigns the address of a procedure to a delegate variable, but the compiler cannot find a version of the procedure with a matching signature.  
  
 When code uses the address of a procedure, the compiler tries to find a version of that procedure with a parameter list that matches that of the delegate. If the procedure is defined in several overloaded versions, the compiler tries to find a single version with a matching signature. For more information, see [Overload Resolution](../vs140/overload-resolution--visual-basic-.md).  
  
 If the compiler cannot find any version of the procedure with a matching signature, it generates this error. This can happen, for example, if either the procedure or the delegate is generic and a type argument is passed to it that gives it a signature that does not match the other signature.  
  
 **Error ID:** BC30950  
  
### To correct this error  
  
1.  Redefine either the procedure or the delegate so that they have matching parameter lists.  
  
     -or-  
  
     Define a new delegate with a parameter list matching that of the procedure, or define a new procedure with a parameter list matching that of the delegate.  
  
2.  If either the procedure or the delegate is generic, then pass it a type argument that causes its signature to match the other signature.  
  
## See Also  
 [AddressOf Operator](../vs140/addressof-operator--visual-basic-.md)   
 [Delegate Statement](../vs140/delegate-statement.md)   
 [NOT IN BUILD: Delegates and the AddressOf Operator](assetId:///7b2ed932-8598-4355-b2f7-5cedb23ee86f)   
 [Overload Resolution](../vs140/overload-resolution--visual-basic-.md)   
 [Generic Types in Visual Basic](../vs140/generic-types-in-visual-basic--visual-basic-.md)