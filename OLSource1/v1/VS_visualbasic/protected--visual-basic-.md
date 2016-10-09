---
title: "Protected (Visual Basic)"
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
  - "vb.Protected"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "Protected Friend keyword combination"
  - "Protected keyword, and Friend"
  - "Protected keyword, syntax"
  - "Protected access modifier"
  - "Protected keyword"
ms.assetid: 74ad3d56-309f-49d2-b60c-1d0157d010e8
caps.latest.revision: 16
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
# Protected (Visual Basic)
Specifies that one or more declared programming elements are accessible only from within their own class or from a derived class.  
  
## Remarks  
 Sometimes a programming element declared in a class contains sensitive data or restricted code, and you want to limit access to the element. However, if the class is inheritable and you expect a hierarchy of derived classes, it might be necessary for these derived classes to access the data or code. In such a case, you want the element to be accessible both from the base class and from all derived classes. To limit access to an element in this manner, you can declare it with `Protected`.  
  
## Rules  
  
-   **Declaration Context.** You can use `Protected` only at class level. This means the declaration context for a `Protected` element must be a class, and cannot be a source file, namespace, interface, module, structure, or procedure.  
  
-   **Combined Modifiers.** You can use the `Protected` modifier together with the [Friend](../VS_visualbasic/friend--visual-basic-.md) modifier in the same declaration. This combination makes the declared elements accessible from anywhere in the same assembly, from their own class, and from derived classes. You can specify `Protected Friend` only on members of classes.  
  
## Behavior  
  
-   **Access Level.** All code in a class can access its elements. Code in any class that derives from a base class can access all the `Protected` elements of the base class. This is true for all generations of derivation. This means that a class can access `Protected` elements of the base class of the base class, and so on.  
  
     Protected access is not a superset or subset of friend access.  
  
-   **Access Modifiers.** The keywords that specify access level are called *access modifiers*. For a comparison of the access modifiers, see [Access Levels in Visual Basic](../VS_visualbasic/access-levels-in-visual-basic.md).  
  
 The `Protected` modifier can be used in these contexts:  
  
 [Class Statement](../VS_visualbasic/class-statement--visual-basic-.md)  
  
 [Const Statement](../VS_visualbasic/const-statement--visual-basic-.md)  
  
 [Declare Statement](../VS_visualbasic/declare-statement.md)  
  
 [Delegate Statement](../VS_visualbasic/delegate-statement.md)  
  
 [Dim Statement](../VS_visualbasic/dim-statement--visual-basic-.md)  
  
 [Enum Statement](../VS_visualbasic/enum-statement--visual-basic-.md)  
  
 [Event Statement](../VS_visualbasic/event-statement.md)  
  
 [Function Statement](../VS_visualbasic/function-statement--visual-basic-.md)  
  
 [Interface Statement](../VS_visualbasic/interface-statement--visual-basic-.md)  
  
 [Property Statement](../VS_visualbasic/property-statement.md)  
  
 [Structure Statement](../VS_visualbasic/structure-statement.md)  
  
 [Sub Statement](../VS_visualbasic/sub-statement--visual-basic-.md)  
  
## See Also  
 [Public](../VS_visualbasic/public--visual-basic-.md)   
 [Friend](../VS_visualbasic/friend--visual-basic-.md)   
 [Private](../VS_visualbasic/private--visual-basic-.md)   
 [Access Levels in Visual Basic](../VS_visualbasic/access-levels-in-visual-basic.md)   
 [Procedures](../VS_visualbasic/procedures-in-visual-basic.md)   
 [Structures](../VS_visualbasic/structures--visual-basic-.md)   
 [Objects and Classes](../VS_visualbasic/objects-and-classes-in-visual-basic.md)