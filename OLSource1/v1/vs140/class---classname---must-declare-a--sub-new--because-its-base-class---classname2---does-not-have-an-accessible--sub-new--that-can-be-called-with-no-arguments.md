---
title: "Class &#39;&lt;classname&gt;&#39; must declare a &#39;Sub New&#39; because its base class &#39;&lt;classname2&gt;&#39; does not have an accessible &#39;Sub New&#39; that can be called with no arguments"
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
  - "vbc30387"
  - "bc30387"
helpviewer_keywords: 
  - "BC30387"
ms.assetid: ff587e79-fa47-4b55-9a08-24688b209e0a
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Class &#39;&lt;classname&gt;&#39; must declare a &#39;Sub New&#39; because its base class &#39;&lt;classname2&gt;&#39; does not have an accessible &#39;Sub New&#39; that can be called with no arguments
A derived class does not declare a constructor, and [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] cannot generate one because there is no base class constructor it can call.  
  
 When a derived class does not declare a constructor, [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] attempts to generate an implicit parameterless constructor that calls `MyBase.New()`. If there is no accessible constructor in the base class that can be called without arguments, or if there is more than one, [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] cannot generate an implicit constructor.  
  
 **Error ID:** BC30387  
  
### To correct this error  
  
1.  Declare and implement at least one `Sub New` constructor somewhere in the derived class.  
  
2.  Add a call to a base class constructor, `MyBase.New()`, as the first line of every `Sub New`.  
  
## See Also  
 [Object Lifetime: How Objects Are Created and Destroyed](../vs140/object-lifetime--how-objects-are-created-and-destroyed--visual-basic-.md)   
 [NOT IN BUILD: Using Constructors and Destructors](assetId:///548eebe1-86c4-4377-b2f5-447cb8be3d90)   
 [Optional](../vs140/optional--visual-basic-.md)   
 [ParamArray](../vs140/paramarray--visual-basic-.md)   
 [Optional Parameters](../vs140/optional-parameters--visual-basic-.md)   
 [Parameter Arrays](../vs140/parameter-arrays--visual-basic-.md)