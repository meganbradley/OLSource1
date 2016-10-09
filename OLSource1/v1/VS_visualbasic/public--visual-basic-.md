---
title: "Public (Visual Basic)"
ms.custom: na
ms.date: "10/03/2016"
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
caps.latest.revision: 13
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
# Public (Visual Basic)
Specifies that one or more declared programming elements have no access restrictions.  
  
## Remarks  
 If you are publishing a component or set of components, such as a class library, you usually want the programming elements to be accessible by any code that interoperates with your assembly. To confer such unlimited access on an element, you can declare it with `Public`.  
  
 Public access is the normal level for a programming element when you do not need to limit access to it. Note that the access level of an element declared within an interface, module, class, or structure defaults to `Public` if you do not declare it otherwise.  
  
## Rules  
  
-   **Declaration Context.** You can use `Public` only at module, interface, or namespace level. This means the declaration context for a `Public` element must be a source file, namespace, interface, module, class, or structure, and cannot be a procedure.  
  
## Behavior  
  
-   **Access Level.** All code that can access a module, class, or structure can access its `Public` elements.  
  
-   **Default Access.** Local variables inside a procedure default to public access, and you cannot use any access modifiers on them.  
  
-   **Access Modifiers.** The keywords that specify access level are called *access modifiers*. For a comparison of the access modifiers, see [Access Levels in Visual Basic](../VS_visualbasic/access-levels-in-visual-basic.md).  
  
 The `Public` modifier can be used in these contexts:  
  
 [Class Statement](../VS_visualbasic/class-statement--visual-basic-.md)  
  
 [Const Statement](../VS_visualbasic/const-statement--visual-basic-.md)  
  
 [Declare Statement](../VS_visualbasic/declare-statement.md)  
  
 [Delegate Statement](../VS_visualbasic/delegate-statement.md)  
  
 [Dim Statement](../VS_visualbasic/dim-statement--visual-basic-.md)  
  
 [Enum Statement](../VS_visualbasic/enum-statement--visual-basic-.md)  
  
 [Event Statement](../VS_visualbasic/event-statement.md)  
  
 [Function Statement](../VS_visualbasic/function-statement--visual-basic-.md)  
  
 [Interface Statement](../VS_visualbasic/interface-statement--visual-basic-.md)  
  
 [Module Statement](../VS_visualbasic/module-statement.md)  
  
 [Operator Statement](../VS_visualbasic/operator-statement.md)  
  
 [Property Statement](../VS_visualbasic/property-statement.md)  
  
 [Structure Statement](../VS_visualbasic/structure-statement.md)  
  
 [Sub Statement](../VS_visualbasic/sub-statement--visual-basic-.md)  
  
## See Also  
 [Protected](../VS_visualbasic/protected--visual-basic-.md)   
 [Friend](../VS_visualbasic/friend--visual-basic-.md)   
 [Private](../VS_visualbasic/private--visual-basic-.md)   
 [Access Levels in Visual Basic](../VS_visualbasic/access-levels-in-visual-basic.md)   
 [Procedures](../VS_visualbasic/procedures-in-visual-basic.md)   
 [Structures](../VS_visualbasic/structures--visual-basic-.md)   
 [Objects and Classes](../VS_visualbasic/objects-and-classes-in-visual-basic.md)