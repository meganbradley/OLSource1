---
title: "First statement of this &#39;Sub New&#39; must be a call to &#39;MyBase.New&#39; or &#39;MyClass.New&#39; (More Than One Accessible Constructor Without Parameters)"
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
  - vbc32038
  - bc32038
helpviewer_keywords: 
  - BC32038
ms.assetid: 52e4e9df-a85b-46ae-a0cc-7d8fa377fe95
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# First statement of this &#39;Sub New&#39; must be a call to &#39;MyBase.New&#39; or &#39;MyClass.New&#39; (More Than One Accessible Constructor Without Parameters)
First statement of this 'Sub New' must be a call to 'MyBase.New' or 'MyClass.New' because base class '<base\>' of '<derived\>' has more than one accessible 'Sub New' that can be called with no arguments.  
  
 A class constructor does not supply a call to a base class constructor, and [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] cannot provide an implicit call because it cannot determine which base class constructor to call.  
  
 **Error ID:** BC32038  
  
### To correct this error  
  
-   Add a call to a base class constructor `MyBase.New()`, or to another constructor of this class using `MyClass.New()` or `Me.New()`, as the first line of this constructor.  
  
## See Also  
 [Object Lifetime: How Objects Are Created and Destroyed](../vs140/object-lifetime--how-objects-are-created-and-destroyed--visual-basic-.md)   
 [NOT IN BUILD: Using Constructors and Destructors](assetId:///548eebe1-86c4-4377-b2f5-447cb8be3d90)   
 [MyBase - delete](assetId:///52491d06-6451-4f6f-9aa6-8fab59bbc2b9)