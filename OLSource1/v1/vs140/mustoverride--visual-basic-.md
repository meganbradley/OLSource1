---
title: "MustOverride (Visual Basic)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-visual-basic
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - vb.MustOverride
  - MustOverride
dev_langs: 
  - VB
helpviewer_keywords: 
  - virtual elements, pure
  - elements, pure virtual
  - properties [Visual Basic], redefining
  - procedures, overriding
  - overriding, MustOverride keyword
  - procedures, redefining
  - pure virtual elements
  - MustOverride keyword
  - properties [Visual Basic], overriding
ms.assetid: 6e9d9ad6-bb64-433f-b32b-3ef84293bf96
caps.latest.revision: 21
translation.priority.ht: 
  - de-de
  - ja-jp
---
# MustOverride (Visual Basic)
Specifies that a property or procedure is not implemented in this class and must be overridden in a derived class before it can be used.  
  
## Remarks  
 You can use `MustOverride` only in a property or procedure declaration statement. The property or procedure that specifies `MustOverride` must be a member of a class, and the class must be marked [MustInherit](../vs140/mustinherit--visual-basic-.md).  
  
## Rules  
  
-   **Incomplete Declaration.** When you specify `MustOverride`, you do not supply any additional lines of code for the property or procedure, not even the `End Function`, `End Property`, or `End Sub` statement.  
  
-   **Combined Modifiers.** You cannot specify `MustOverride` together with `NotOverridable`, `Overridable`, or `Shared` in the same declaration.  
  
-   **Shadowing and Overriding.** Both shadowing and overriding redefine an inherited element, but there are significant differences between the two approaches. For more information, see [Shadowing in Visual Basic](../vs140/shadowing-in-visual-basic.md).  
  
-   **Alternate Terms.** An element that cannot be used except in an override is sometimes called a *pure virtual* element.  
  
 The `MustOverride` modifier can be used in these contexts:  
  
 [Function Statement](../vs140/function-statement--visual-basic-.md)  
  
 [Property Statement](../vs140/property-statement.md)  
  
 [Sub Statement](../vs140/sub-statement--visual-basic-.md)  
  
## See Also  
 [NotOverridable](../vs140/notoverridable--visual-basic-.md)   
 [Overridable](../vs140/overridable--visual-basic-.md)   
 [Overrides](../vs140/overrides--visual-basic-.md)   
 [MustInherit](../vs140/mustinherit--visual-basic-.md)   
 [Keywords (Visual Basic)](../vs140/keywords--visual-basic-.md)   
 [Shadowing in Visual Basic](../vs140/shadowing-in-visual-basic.md)