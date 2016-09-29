---
title: "Private (Visual Basic)"
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
  - "vb.Private"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "Private keyword"
  - "Private keyword, syntax"
ms.assetid: aba74a2e-5824-4613-bf63-b9ec7787f4e6
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Private (Visual Basic)
Specifies that one or more declared programming elements are accessible only from within their declaration context, including from within any contained types.  
  
## Remarks  
 If a programming element represents proprietary functionality, or contains confidential data, you usually want to limit access to it as strictly as possible. You achieve the maximum limitation by allowing only the module, class, or structure that defines it to access it. To limit access to an element in this way, you can declare it with `Private`.  
  
## Rules  
  
-   **Declaration Context.** You can use `Private` only at module level. This means the declaration context for a `Private` element must be a module, class, or structure, and cannot be a source file, namespace, interface, or procedure.  
  
## Behavior  
  
-   **Access Level.** All code within a declaration context can access its `Private` elements. This includes code within a contained type, such as a nested class or an assignment expression in an enumeration. No code outside of the declaration context can access its `Private` elements.  
  
-   **Access Modifiers.** The keywords that specify access level are called *access modifiers*. For a comparison of the access modifiers, see [Access Levels in Visual Basic](../VS_csharp/access-levels-in-visual-basic.md).  
  
 The `Private` modifier can be used in these contexts:  
  
 [Class Statement](../VS_csharp/class-statement--visual-basic-.md)  
  
 [Const Statement](../VS_csharp/const-statement--visual-basic-.md)  
  
 [Declare Statement](../VS_csharp/declare-statement.md)  
  
 [Delegate Statement](../VS_csharp/delegate-statement.md)  
  
 [Dim Statement](../VS_csharp/dim-statement--visual-basic-.md)  
  
 [Enum Statement](../VS_csharp/enum-statement--visual-basic-.md)  
  
 [Event Statement](../VS_csharp/event-statement.md)  
  
 [Function Statement](../VS_csharp/function-statement--visual-basic-.md)  
  
 [Interface Statement](../VS_csharp/interface-statement--visual-basic-.md)  
  
 [Property Statement](../VS_csharp/property-statement.md)  
  
 [Structure Statement](../VS_csharp/structure-statement.md)  
  
 [Sub Statement](../VS_csharp/sub-statement--visual-basic-.md)  
  
## See Also  
 [Public](../VS_csharp/public--visual-basic-.md)   
 [Protected](../VS_csharp/protected--visual-basic-.md)   
 [Friend](../VS_csharp/friend--visual-basic-.md)   
 [Access Levels in Visual Basic](../VS_csharp/access-levels-in-visual-basic.md)   
 [Procedures in Visual Basic](../VS_csharp/procedures-in-visual-basic.md)   
 [Structures](../VS_csharp/structures--visual-basic-.md)   
 [Objects and Classes in Visual Basic](../VS_csharp/objects-and-classes-in-visual-basic.md)