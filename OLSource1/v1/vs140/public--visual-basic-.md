---
title: "Public (Visual Basic)"
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
  - "vb.Public"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "Public keyword"
  - "Public keyword, syntax"
  - "Public access modifier"
ms.assetid: 284c9e1b-ed23-499b-9bc9-ad87c11485a5
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Public (Visual Basic)
Specifies that one or more declared programming elements have no access restrictions.  
  
## Remarks  
 If you are publishing a component or set of components, such as a class library, you usually want the programming elements to be accessible by any code that interoperates with your assembly. To confer such unlimited access on an element, you can declare it with <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>.  
  
 Public access is the normal level for a programming element when you do not need to limit access to it. Note that the access level of an element declared within an interface, module, class, or structure defaults to <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> if you do not declare it otherwise.  
  
## Rules  
  
-   **Declaration Context.** You can use <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> only at module, interface, or namespace level. This means the declaration context for a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> element must be a source file, namespace, interface, module, class, or structure, and cannot be a procedure.  
  
## Behavior  
  
-   **Access Level.** All code that can access a module, class, or structure can access its <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> elements.  
  
-   **Default Access.** Local variables inside a procedure default to public access, and you cannot use any access modifiers on them.  
  
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
  
 [Module Statement](../vs140/module-statement.md)  
  
 [Operator Statement](../vs140/operator-statement.md)  
  
 [Property Statement](../vs140/property-statement.md)  
  
 [Structure Statement](../vs140/structure-statement.md)  
  
 [Sub Statement](../vs140/sub-statement--visual-basic-.md)  
  
## See Also  
 [Protected](../vs140/protected--visual-basic-.md)   
 [Friend](../vs140/friend--visual-basic-.md)   
 [Private](../vs140/private--visual-basic-.md)   
 [Access Levels in Visual Basic](../vs140/access-levels-in-visual-basic.md)   
 [Procedures in Visual Basic](../vs140/procedures-in-visual-basic.md)   
 [Structures](../vs140/structures--visual-basic-.md)   
 [Objects and Classes in Visual Basic](../vs140/objects-and-classes-in-visual-basic.md)