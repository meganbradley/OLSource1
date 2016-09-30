---
title: "Class &#39;&lt;classname&gt;&#39; has no accessible &#39;Sub New&#39; and cannot be inherited"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vbc31399"
  - "BC31399"
helpviewer_keywords: 
  - "BC31399"
ms.assetid: 035b333f-ff6a-4fc4-bd36-82f40b1d8bab
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Class &#39;&lt;classname&gt;&#39; has no accessible &#39;Sub New&#39; and cannot be inherited
A class uses an [Inherits Statement](../vs140/inherits-statement.md) to specify a base class, but it cannot access any constructor on the intended base class.  
  
 This can happen if the intended base class has no constructors or if it has constructors with access levels that prevent access from another class.  
  
 When you inherit a class, your constructor should call the base class constructor using [MyBase - delete](assetId:///52491d06-6451-4f6f-9aa6-8fab59bbc2b9). If you do not make this call, or if you do not even write an explicit constructor, Visual Basic generates an implicit constructor that calls <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>.  
  
 **Error ID:** BC31399  
  
### To correct this error  
  
1.  If you have source control over the intended base class, then change the access level of at least one of its constructors so that another class can access them.  
  
2.  If you cannot change the access levels of the intended base class constructors, then inherit from a different class or not at all.  
  
## See Also  
 [Inherits Statement](../vs140/inherits-statement.md)   
 [Inheritance Basics](../vs140/inheritance-basics--visual-basic-.md)   
 [MyBase - delete](assetId:///52491d06-6451-4f6f-9aa6-8fab59bbc2b9)   
 [New (Visual Basic)](../vs140/new-operator--visual-basic-.md)   
 [Access Levels in Visual Basic](../vs140/access-levels-in-visual-basic.md)