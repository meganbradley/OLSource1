---
title: "Property cannot be declared &#39;&lt;propertymodifier&gt;&#39; because it contains a &#39;Private&#39; accessor"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - vbc31108
  - bc31108
helpviewer_keywords: 
  - BC31108
ms.assetid: 74fb36f4-54cd-4fda-bcc6-e965b5c7c37b
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Property cannot be declared &#39;&lt;propertymodifier&gt;&#39; because it contains a &#39;Private&#39; accessor
A property with a `Private` property procedure (`Get` or `Set`) is marked [Overridable](../vs140/overridable--visual-basic-.md).  
  
 If a base class property or procedure is declared [Private (Visual Basic)](../vs140/private--visual-basic-.md), a derived class cannot override that property or procedure because it cannot access it. Because of this, you cannot use `Private` in combination with `Overridable`. This applies not only to the property itself but to the individual property procedures as well.  
  
 **Error ID:** BC31108  
  
### To correct this error  
  
-   Remove the `Overridable` keyword from the [Property Statement](../vs140/property-statement.md), or remove the `Private` keyword from the [Get Statement](../vs140/get-statement.md) or the [Set Statement (Visual Basic)](../vs140/set-statement--visual-basic-.md).  
  
## See Also  
 [Property Procedures](../vs140/property-procedures--visual-basic-.md)   
 [How to: Declare a Property with Mixed Access Levels](../vs140/how-to--declare-a-property-with-mixed-access-levels--visual-basic-.md)