---
title: "NotOverridable (Visual Basic)"
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
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# NotOverridable (Visual Basic)
Specifies that a property or procedure cannot be overridden in a derived class.  
  
## Remarks  
 The `NotOverridable` modifier prevents a property or method from being overridden in a derived class.  The [Overridable (Visual Basic)](../vs140/overridable--visual-basic-.md) modifier allows a property or method in a class to be overridden in a derived class. For more information, see [Inheritance Basics (Visual Basic)](../vs140/inheritance-basics--visual-basic-.md).  
  
 If the `Overridable` or `NotOverridable` modifier is not specified, the default setting depends on whether the property or method overrides a base class property or method. If the property or method overrides a base class property or method, the default setting is `Overridable`; otherwise, it is `NotOverridable`.  
  
 An element that cannot be overridden is sometimes called a *sealed* element.  
  
 You can use `NotOverridable` only in a property or procedure declaration statement. You can specify `NotOverridable` only on a property or procedure that overrides another property or procedure, that is, only in combination with `Overrides`.  
  
## Combined Modifiers  
 You cannot specify `Overridable` or `NotOverridable` for a `Private` method.  
  
 You cannot specify `NotOverridable` together with `MustOverride`, `Overridable`, or `Shared` in the same declaration.  
  
## Usage  
 The `NotOverridable` modifier can be used in these contexts:  
  
 [Function Statement](../vs140/function-statement--visual-basic-.md)  
  
 [Property Statement](../vs140/property-statement.md)  
  
 [Sub Statement](../vs140/sub-statement--visual-basic-.md)  
  
## See Also  
 [Modifiers (Visual Basic)](../vs140/modifiers--visual-basic-.md)   
 [Inheritance Basics (Visual Basic)](../vs140/inheritance-basics--visual-basic-.md)   
 [MustOverride](../vs140/mustoverride--visual-basic-.md)   
 [Overridable](../vs140/overridable--visual-basic-.md)   
 [Overrides](../vs140/overrides--visual-basic-.md)   
 [Keywords (Visual Basic)](../vs140/keywords--visual-basic-.md)   
 [Shadowing in Visual Basic](../vs140/shadowing-in-visual-basic.md)