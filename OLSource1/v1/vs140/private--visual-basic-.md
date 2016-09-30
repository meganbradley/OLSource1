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
 If a programming element represents proprietary functionality, or contains confidential data, you usually want to limit access to it as strictly as possible. You achieve the maximum limitation by allowing only the module, class, or structure that defines it to access it. To limit access to an element in this way, you can declare it with <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>.  
  
## Rules  
  
-   **Declaration Context.** You can use <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> only at module level. This means the declaration context for a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> element must be a module, class, or structure, and cannot be a source file, namespace, interface, or procedure.  
  
## Behavior  
  
-   **Access Level.** All code within a declaration context can access its <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> elements. This includes code within a contained type, such as a nested class or an assignment expression in an enumeration. No code outside of the declaration context can access its <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> elements.  
  
-   **Access Modifiers.** The keywords that specify access level are called *access modifiers*. For a comparison of the access modifiers, see [Access Levels in Visual Basic](../vs140/access-levels-in-visual-basic.md).  
  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> modifier can be used in these contexts:  
  
 [Class Statement](../vs140/class-statement--visual-basic-.md)  
  
 [Const Statement](../vs140/const-statement--visual-basic-.md)  
  
 [Declare Statement](../vs140/declare-statement.md)  
  
 [Delegate Statement](../vs140/delegate-statement.md)  
  
 [Dim Statement](../vs140/dim-statement--visual-basic-.md)  
  
 [Enum Statement](../vs140/enum-statement--visual-basic-.md)  
  
 [Event Statement](../vs140/event-statement.md)  
  
 [Function Statement](../vs140/function-statement--visual-basic-.md)  
  
 [Interface Statement](../vs140/interface-statement--visual-basic-.md)  
  
 [Property Statement](../vs140/property-statement.md)  
  
 [Structure Statement](../vs140/structure-statement.md)  
  
 [Sub Statement](../vs140/sub-statement--visual-basic-.md)  
  
## See Also  
 [Public](../vs140/public--visual-basic-.md)   
 [Protected](../vs140/protected--visual-basic-.md)   
 [Friend](../vs140/friend--visual-basic-.md)   
 [Access Levels in Visual Basic](../vs140/access-levels-in-visual-basic.md)   
 [Procedures in Visual Basic](../vs140/procedures-in-visual-basic.md)   
 [Structures](../vs140/structures--visual-basic-.md)   
 [Objects and Classes in Visual Basic](../vs140/objects-and-classes-in-visual-basic.md)