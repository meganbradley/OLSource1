---
title: "Protected (Visual Basic)"
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
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Protected (Visual Basic)
Specifies that one or more declared programming elements are accessible only from within their own class or from a derived class.  
  
## Remarks  
 Sometimes a programming element declared in a class contains sensitive data or restricted code, and you want to limit access to the element. However, if the class is inheritable and you expect a hierarchy of derived classes, it might be necessary for these derived classes to access the data or code. In such a case, you want the element to be accessible both from the base class and from all derived classes. To limit access to an element in this manner, you can declare it with <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>.  
  
## Rules  
  
-   **Declaration Context.** You can use <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> only at class level. This means the declaration context for a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> element must be a class, and cannot be a source file, namespace, interface, module, structure, or procedure.  
  
-   **Combined Modifiers.** You can use the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> modifier together with the [Friend](../vs140/friend--visual-basic-.md) modifier in the same declaration. This combination makes the declared elements accessible from anywhere in the same assembly, from their own class, and from derived classes. You can specify <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> only on members of classes.  
  
## Behavior  
  
-   **Access Level.** All code in a class can access its elements. Code in any class that derives from a base class can access all the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> elements of the base class. This is true for all generations of derivation. This means that a class can access <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> elements of the base class of the base class, and so on.  
  
     Protected access is not a superset or subset of friend access.  
  
-   **Access Modifiers.** The keywords that specify access level are called *access modifiers*. For a comparison of the access modifiers, see [Access Levels in Visual Basic](../vs140/access-levels-in-visual-basic.md).  
  
 The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> modifier can be used in these contexts:  
  
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
 [Friend](../vs140/friend--visual-basic-.md)   
 [Private](../vs140/private--visual-basic-.md)   
 [Access Levels in Visual Basic](../vs140/access-levels-in-visual-basic.md)   
 [Procedures in Visual Basic](../vs140/procedures-in-visual-basic.md)   
 [Structures](../vs140/structures--visual-basic-.md)   
 [Objects and Classes in Visual Basic](../vs140/objects-and-classes-in-visual-basic.md)