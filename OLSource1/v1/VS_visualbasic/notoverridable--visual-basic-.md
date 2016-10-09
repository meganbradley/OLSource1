---
title: "NotOverridable (Visual Basic)"
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
  - "vb.NotOverridable"
  - "NotOverridable"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "sealed methods"
  - "NotOverridable keyword"
  - "properties [Visual Basic], redefining"
  - "elements, sealed"
  - "sealed elements"
  - "procedures, overriding"
  - "procedures, redefining"
  - "overriding"
  - "methods [Visual Basic], sealed"
  - "properties [Visual Basic], overriding"
ms.assetid: 66ec6984-f5f5-4857-b362-6a3907aaf9e0
caps.latest.revision: 15
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
# NotOverridable (Visual Basic)
Specifies that a property or procedure cannot be overridden in a derived class.  
  
## Remarks  
 The `NotOverridable` modifier prevents a property or method from being overridden in a derived class.  The [Overridable](../VS_visualbasic/overridable--visual-basic-.md) modifier allows a property or method in a class to be overridden in a derived class. For more information, see [Inheritance Basics](../VS_visualbasic/inheritance-basics--visual-basic-.md).  
  
 If the `Overridable` or `NotOverridable` modifier is not specified, the default setting depends on whether the property or method overrides a base class property or method. If the property or method overrides a base class property or method, the default setting is `Overridable`; otherwise, it is `NotOverridable`.  
  
 An element that cannot be overridden is sometimes called a *sealed* element.  
  
 You can use `NotOverridable` only in a property or procedure declaration statement. You can specify `NotOverridable` only on a property or procedure that overrides another property or procedure, that is, only in combination with `Overrides`.  
  
## Combined Modifiers  
 You cannot specify `Overridable` or `NotOverridable` for a `Private` method.  
  
 You cannot specify `NotOverridable` together with `MustOverride`, `Overridable`, or `Shared` in the same declaration.  
  
## Usage  
 The `NotOverridable` modifier can be used in these contexts:  
  
 [Function Statement](../VS_visualbasic/function-statement--visual-basic-.md)  
  
 [Property Statement](../VS_visualbasic/property-statement.md)  
  
 [Sub Statement](../VS_visualbasic/sub-statement--visual-basic-.md)  
  
## See Also  
 [Modifiers](../VS_visualbasic/modifiers--visual-basic-.md)   
 [Inheritance Basics](../VS_visualbasic/inheritance-basics--visual-basic-.md)   
 [MustOverride](../VS_visualbasic/mustoverride--visual-basic-.md)   
 [Overridable](../VS_visualbasic/overridable--visual-basic-.md)   
 [Overrides](../VS_visualbasic/overrides--visual-basic-.md)   
 [Keywords](../VS_visualbasic/keywords--visual-basic-.md)   
 [Shadowing in Visual Basic](../VS_visualbasic/shadowing-in-visual-basic.md)