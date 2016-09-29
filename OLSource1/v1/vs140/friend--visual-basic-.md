---
title: "Friend (Visual Basic)"
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
  - "vb.Friend"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "Friend keyword"
  - "Friend access modifier"
  - "Friend keyword, syntax"
  - "Protected Friend keyword combination"
  - "Friend keyword, and Protected"
ms.assetid: b664605e-1c79-4728-b996-aa59c50846bc
caps.latest.revision: 29
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Friend (Visual Basic)
Specifies that one or more declared programming elements are accessible only from within the assembly that contains their declaration.  
  
## Remarks  
 In many cases, you want programming elements such as classes and structures to be used by the entire assembly, not only by the component that declares them. However, you might not want them to be accessible by code outside the assembly (for example, if the application is proprietary). If you want to limit access to an element in this way, you can declare it by using the `Friend` modifier.  
  
 Code in other classes, structures, and modules that are compiled to the same assembly can access all the `Friend` elements in that assembly.  
  
 `Friend` access is often the preferred level for an application's programming elements, and `Friend` is the default access level of an interface, a module, a class, or a structure.  
  
 You can use `Friend` only at the module, interface, or namespace level. Therefore, the declaration context for a `Friend` element must be a source file, a namespace, an interface, a module, a class, or a structure; it can't be a procedure.  
  
 You can use the `Friend` modifier in conjunction with the [Protected](../vs140/protected--visual-basic-.md) modifier in the same declaration. This combination confers both `Friend` access and protected access on the declared elements, so they are accessible from anywhere in the same assembly, from their own class, and from derived classes. You can specify `Protected Friend` only on members of classes.  
  
 For a comparison of `Friend` and the other access modifiers, see [Access Levels in Visual Basic](../vs140/access-levels-in-visual-basic.md).  
  
> [!NOTE]
>  You can specify that another assembly is a friend assembly, which allows it to access all types and members that are marked as `Friend`. For more information, see [Friend Assemblies (C# and Visual Basic)](../vs140/friend-assemblies--csharp-and-visual-basic-.md).  
  
## Example  
 The following class uses the `Friend` modifier to allow other programming elements within the same assembly to access certain members.  
  
 [!code[VbVbalrAccessModifiers#1](../vs140/codesnippet/VisualBasic/friend--visual-basic-_1.vb)]  
  
## Usage  
 You can use the `Friend` modifier in these contexts:  
  
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
  
 [Property Statement](../vs140/property-statement.md)  
  
 [Structure Statement](../vs140/structure-statement.md)  
  
 [Sub Statement](../vs140/sub-statement--visual-basic-.md)  
  
## See Also  
 <xref:System.Runtime.CompilerServices.InternalsVisibleToAttribute*>   
 [Public](../vs140/public--visual-basic-.md)   
 [Protected](../vs140/protected--visual-basic-.md)   
 [Private](../vs140/private--visual-basic-.md)   
 [Access Levels in Visual Basic](../vs140/access-levels-in-visual-basic.md)   
 [Procedures in Visual Basic](../vs140/procedures-in-visual-basic.md)   
 [Structures](../vs140/structures--visual-basic-.md)   
 [Objects and Classes in Visual Basic](../vs140/objects-and-classes-in-visual-basic.md)