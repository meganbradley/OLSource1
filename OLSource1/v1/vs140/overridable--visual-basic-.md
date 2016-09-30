---
title: "Overridable (Visual Basic)"
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
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Overridable (Visual Basic)
Specifies that a property or procedure can be overridden by an identically named property or procedure in a derived class.  
  
## Remarks  
 The <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> modifier allows a property or method in a class to be overridden in a derived class. The [NotOverridable (Visual Basic)](../vs140/notoverridable--visual-basic-.md) modifier prevents a property or method from being overridden in a derived class.  For more information, see [Inheritance Basics (Visual Basic)](../vs140/inheritance-basics--visual-basic-.md).  
  
 If the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> modifier is not specified, the default setting depends on whether the property or method overrides a base class property or method. If the property or method overrides a base class property or method, the default setting is <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>; otherwise, it is <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 You can shadow or override to redefine an inherited element, but there are significant differences between the two approaches. For more information, see [Shadowing in Visual Basic](../vs140/shadowing-in-visual-basic.md).  
  
 An element that can be overridden is sometimes referred to as a *virtual* element. If it can be overridden, but does not have to be, it is sometimes also called a *concrete* element.  
  
 You can use <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> only in a property or procedure declaration statement.  
  
## Combined Modifiers  
 You cannot specify <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> for a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> method.  
  
 You cannot specify <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> together with <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> in the same declaration.  
  
 Because an overriding element is implicitly overridable, you cannot combine <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> with <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
## Usage  
 The <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> modifier can be used in these contexts:  
  
 [Function Statement](../vs140/function-statement--visual-basic-.md)  
  
 [Property Statement](../vs140/property-statement.md)  
  
 [Sub Statement](../vs140/sub-statement--visual-basic-.md)  
  
## See Also  
 [Modifiers (Visual Basic)](../vs140/modifiers--visual-basic-.md)   
 [Inheritance Basics (Visual Basic)](../vs140/inheritance-basics--visual-basic-.md)   
 [MustOverride](../vs140/mustoverride--visual-basic-.md)   
 [NotOverridable](../vs140/notoverridable--visual-basic-.md)   
 [Overrides](../vs140/overrides--visual-basic-.md)   
 [Keywords (Visual Basic)](../vs140/keywords--visual-basic-.md)   
 [Shadowing in Visual Basic](../vs140/shadowing-in-visual-basic.md)