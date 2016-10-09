---
title: "Overridable (Visual Basic)"
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
  - "Overridable"
  - "vb.Overridable"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "elements, concrete"
  - "properties [Visual Basic], redefining"
  - "overriding, Overridable keyword"
  - "elements, virtual"
  - "virtual elements"
  - "procedures, overriding"
  - "concrete elements"
  - "procedures, redefining"
  - "Overridable keyword"
  - "properties [Visual Basic], overriding"
ms.assetid: 612581e7-8a4c-4a5d-beff-3402fffa6f35
caps.latest.revision: 17
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
# Overridable (Visual Basic)
Specifies that a property or procedure can be overridden by an identically named property or procedure in a derived class.  
  
## Remarks  
 The `Overridable` modifier allows a property or method in a class to be overridden in a derived class. The [NotOverridable](../VS_visualbasic/notoverridable--visual-basic-.md) modifier prevents a property or method from being overridden in a derived class.  For more information, see [Inheritance Basics](../VS_visualbasic/inheritance-basics--visual-basic-.md).  
  
 If the `Overridable` or `NotOverridable` modifier is not specified, the default setting depends on whether the property or method overrides a base class property or method. If the property or method overrides a base class property or method, the default setting is `Overridable`; otherwise, it is `NotOverridable`.  
  
 You can shadow or override to redefine an inherited element, but there are significant differences between the two approaches. For more information, see [Shadowing in Visual Basic](../VS_visualbasic/shadowing-in-visual-basic.md).  
  
 An element that can be overridden is sometimes referred to as a *virtual* element. If it can be overridden, but does not have to be, it is sometimes also called a *concrete* element.  
  
 You can use `Overridable` only in a property or procedure declaration statement.  
  
## Combined Modifiers  
 You cannot specify `Overridable` or `NotOverridable` for a `Private` method.  
  
 You cannot specify `Overridable` together with `MustOverride`, `NotOverridable`, or `Shared` in the same declaration.  
  
 Because an overriding element is implicitly overridable, you cannot combine `Overridable` with `Overrides`.  
  
## Usage  
 The `Overridable` modifier can be used in these contexts:  
  
 [Function Statement](../VS_visualbasic/function-statement--visual-basic-.md)  
  
 [Property Statement](../VS_visualbasic/property-statement.md)  
  
 [Sub Statement](../VS_visualbasic/sub-statement--visual-basic-.md)  
  
## See Also  
 [Modifiers](../VS_visualbasic/modifiers--visual-basic-.md)   
 [Inheritance Basics](../VS_visualbasic/inheritance-basics--visual-basic-.md)   
 [MustOverride](../VS_visualbasic/mustoverride--visual-basic-.md)   
 [NotOverridable](../VS_visualbasic/notoverridable--visual-basic-.md)   
 [Overrides](../VS_visualbasic/overrides--visual-basic-.md)   
 [Keywords](../VS_visualbasic/keywords--visual-basic-.md)   
 [Shadowing in Visual Basic](../VS_visualbasic/shadowing-in-visual-basic.md)