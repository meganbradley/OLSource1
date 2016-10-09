---
title: "Friend (Visual Basic)"
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
caps.latest.revision: 25
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# Friend (Visual Basic)
Specifies that one or more declared programming elements are accessible only from within the assembly that contains their declaration.  
  
## Remarks  
 In many cases, you want programming elements such as classes and structures to be used by the entire assembly, not only by the component that declares them. However, you might not want them to be accessible by code outside the assembly (for example, if the application is proprietary). If you want to limit access to an element in this way, you can declare it by using the `Friend` modifier.  
  
 Code in other classes, structures, and modules that are compiled to the same assembly can access all the `Friend` elements in that assembly.  
  
 `Friend` access is often the preferred level for an application's programming elements, and `Friend` is the default access level of an interface, a module, a class, or a structure.  
  
 You can use `Friend` only at the module, interface, or namespace level. Therefore, the declaration context for a `Friend` element must be a source file, a namespace, an interface, a module, a class, or a structure; it can't be a procedure.  
  
 You can use the `Friend` modifier in conjunction with the [Protected](../VS_visualbasic/protected--visual-basic-.md) modifier in the same declaration. This combination confers both `Friend` access and protected access on the declared elements, so they are accessible from anywhere in the same assembly, from their own class, and from derived classes. You can specify `Protected Friend` only on members of classes.  
  
 For a comparison of `Friend` and the other access modifiers, see [Access Levels in Visual Basic](../VS_visualbasic/access-levels-in-visual-basic.md).  
  
> [!NOTE]
>  You can specify that another assembly is a friend assembly, which allows it to access all types and members that are marked as `Friend`. For more information, see [Friend Assemblies](../Topic/Friend%20Assemblies%20\(C%23%20and%20Visual%20Basic\).md).  
  
## Example  
 The following class uses the `Friend` modifier to allow other programming elements within the same assembly to access certain members.  
  
 [!code[VbVbalrAccessModifiers#1](../VS_visualbasic/codesnippet/VisualBasic/friend--visual-basic-_1.vb)]  
  
## Usage  
 You can use the `Friend` modifier in these contexts:  
  
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
  
 [Property Statement](../VS_visualbasic/property-statement.md)  
  
 [Structure Statement](../VS_visualbasic/structure-statement.md)  
  
 [Sub Statement](../VS_visualbasic/sub-statement--visual-basic-.md)  
  
## See Also  
 \<xref:System.Runtime.CompilerServices.InternalsVisibleToAttribute>   
 [Public](../VS_visualbasic/public--visual-basic-.md)   
 [Protected](../VS_visualbasic/protected--visual-basic-.md)   
 [Private](../VS_visualbasic/private--visual-basic-.md)   
 [Access Levels in Visual Basic](../VS_visualbasic/access-levels-in-visual-basic.md)   
 [Procedures](../VS_visualbasic/procedures-in-visual-basic.md)   
 [Structures](../VS_visualbasic/structures--visual-basic-.md)   
 [Objects and Classes](../VS_visualbasic/objects-and-classes-in-visual-basic.md)