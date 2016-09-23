---
title: "Property accessors cannot be declared &#39;&lt;accessmodifier&gt;&#39; in a &#39;NotOverridable&#39; property"
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
  - vbc31106
  - bc31106
helpviewer_keywords: 
  - BC31106
ms.assetid: 84bcb157-9c33-4e4f-89a9-c5e6cb73028b
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Property accessors cannot be declared &#39;&lt;accessmodifier&gt;&#39; in a &#39;NotOverridable&#39; property
A [Get Statement](../vs140/get-statement.md) or [Set Statement (Visual Basic)](../vs140/set-statement--visual-basic-.md) in a `NotOverridable` property includes the `Private` keyword.  
  
 The following line of reasoning explains why `NotOverridable` and `Private` cannot be combined in a [Property Statement](../vs140/property-statement.md):  
  
1.  A property or procedure that does not override a base class property or procedure has a default setting of [NotOverridable](../vs140/notoverridable--visual-basic-.md).  
  
2.  However, a property or procedure in a derived class that overrides a base class property or procedure has a default setting of [Overridable](../vs140/overridable--visual-basic-.md). To terminate the hierarchy of overriding, you can declare it `NotOverridable`. This is the only context in which you can use `NotOverridable`. That is, you can use `NotOverridable` only in combination with [Overrides](../vs140/overrides--visual-basic-.md).  
  
3.  If a base class property or procedure is declared [Private (Visual Basic)](../vs140/private--visual-basic-.md), a derived class cannot override that property or procedure because it cannot access it. Because of this, you cannot use `Private` in combination with `Overridable`.  
  
4.  To override a property or procedure, the overriding property or procedure must have not only the identical signature but also the same access level. This means that an overriding property or procedure cannot specify `Private`, because an overridable property or procedure cannot specify `Private`.  
  
5.  Because you can specify `NotOverridable` only on an overriding property or procedure, you cannot combine it with `Private`.  
  
 By the same reasoning, the individual property procedures (`Get` and `Set`) of an overriding property cannot be `Private`.  
  
 **Error ID:** BC31106  
  
### To correct this error  
  
-   Remove the `Private` keyword from the `Get` or `Set` statement, or remove the `Overrides` and `NotOverridable` keywords from the `Property` statement.  
  
## See Also  
 [Property Procedures](../vs140/property-procedures--visual-basic-.md)   
 [Differences Between Shadowing and Overriding](../vs140/differences-between-shadowing-and-overriding--visual-basic-.md)   
 [How to: Declare a Property with Mixed Access Levels](../vs140/how-to--declare-a-property-with-mixed-access-levels--visual-basic-.md)