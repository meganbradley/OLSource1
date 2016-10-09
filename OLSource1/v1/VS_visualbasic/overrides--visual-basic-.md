---
title: "Overrides (Visual Basic)"
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
  - "Overrides"
  - "vb.Overrides"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "properties [Visual Basic], redefining"
  - "procedures, overriding"
  - "procedures, redefining"
  - "overriding"
  - "Overrides keyword"
  - "overriding, Overrides keyword"
  - "properties [Visual Basic], overriding"
ms.assetid: 9f5e6144-ce10-465e-842b-1a8f8760af90
caps.latest.revision: 18
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
# Overrides (Visual Basic)
Specifies that a property or procedure overrides an identically named property or procedure inherited from a base class.  
  
## Remarks  
  
## Rules  
  
-   **Declaration Context.** You can use `Overrides` only in a property or procedure declaration statement.  
  
-   **Combined Modifiers.** You cannot specify `Overrides` together with `Shadows` or `Shared` in the same declaration. Because an overriding element is implicitly overridable, you cannot combine `Overridable` with `Overrides`.  
  
-   **Matching Signatures.** The signature of this declaration must exactly match the *signature* of the property or procedure that it overrides. This means the parameter lists must have the same number of parameters, in the same order, with the same data types.  
  
     In addition to the signature, the overriding declaration must also exactly match the following:  
  
    -   The access level  
  
    -   The return type, if any  
  
-   **Generic Signatures.** For a generic procedure, the signature includes the number of type parameters. Therefore, the overriding declaration must match the base class version in that respect as well.  
  
-   **Additional Matching.** In addition to matching the signature of the base class version, this declaration must also match it in the following respects:  
  
    -   Access-level modifier (such as [Public](../VS_visualbasic/public--visual-basic-.md))  
  
    -   Passing mechanism of each parameter ([ByVal](../VS_visualbasic/byval--visual-basic-.md) or [ByRef](../VS_visualbasic/byref--visual-basic-.md))  
  
    -   Constraint lists on each type parameter of a generic procedure  
  
-   **Shadowing and Overriding.** Both shadowing and overriding redefine an inherited element, but there are significant differences between the two approaches. For more information, see [Shadowing in Visual Basic](../VS_visualbasic/shadowing-in-visual-basic.md).  
  
 If you use `Overrides`, the compiler implicitly adds `Overloads` so that your library APIs work with C# more easily.  
  
 The `Overrides` modifier can be used in these contexts:  
  
 [Function Statement](../VS_visualbasic/function-statement--visual-basic-.md)  
  
 [Property Statement](../VS_visualbasic/property-statement.md)  
  
 [Sub Statement](../VS_visualbasic/sub-statement--visual-basic-.md)  
  
## See Also  
 [MustOverride](../VS_visualbasic/mustoverride--visual-basic-.md)   
 [NotOverridable](../VS_visualbasic/notoverridable--visual-basic-.md)   
 [Overridable](../VS_visualbasic/overridable--visual-basic-.md)   
 [Keywords](../VS_visualbasic/keywords--visual-basic-.md)   
 [Shadowing in Visual Basic](../VS_visualbasic/shadowing-in-visual-basic.md)   
 [Generic Types in Visual Basic](../VS_visualbasic/generic-types-in-visual-basic--visual-basic-.md)   
 [Type List](../VS_visualbasic/type-list--visual-basic-.md)