---
title: "Cannot inherit interface &#39;&lt;interfacename1&gt;&#39; because it could be identical to interface &#39;&lt;interfacename2&gt;&#39; for some type arguments"
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
  - "vbc32120"
  - "bc32120"
helpviewer_keywords: 
  - "BC32120"
ms.assetid: c91f84a1-e61d-4b5f-8028-221e64ac044c
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Cannot inherit interface &#39;&lt;interfacename1&gt;&#39; because it could be identical to interface &#39;&lt;interfacename2&gt;&#39; for some type arguments
A generic interface inherits more than once from another generic interface, and two of the inheritances could conflict for certain values of type arguments.  
  
 The following statements can generate this error.  
  
 `Public Interface interfaceA(Of u)`  
  
 `End Interface`  
  
 `Public Interface derivedInterface(Of t1, t2)`  
  
 `Inherits interfaceA(Of t1), interfaceA(Of t2)`  
  
 `End Interface`  
  
 If `derivedInterface` is constructed or implemented supplying the same type to both `t1` and `t2`, it must inherit two versions of `interfaceA` with identical type arguments. Doing so would produce an ambiguity about which version to access.  
  
 **Error ID:** BC32120  
  
### To correct this error  
  
-   Change one of the type arguments supplied to the derived interface so that there is no conflict.  
  
     -or-  
  
-   Remove from the `Inherits` statement one of the interfaces causing the potential inheritance or implementation conflict.  
  
## See Also  
 [NOT IN BUILD: Interfaces Overview](assetId:///f96bb470-c1b8-4c73-89bc-6f536b798da1)   
 [Interface Statement (Visual Basic)](../vs140/interface-statement--visual-basic-.md)   
 [Inheritance Basics](../vs140/inheritance-basics--visual-basic-.md)   
 [Inherits Statement](../vs140/inherits-statement.md)   
 [Generic Types in Visual Basic](../vs140/generic-types-in-visual-basic--visual-basic-.md)