---
title: "Type &#39;&lt;typename&gt;&#39; cannot inherit from a type parameter"
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
  - "bc32055"
  - "vbc32055"
helpviewer_keywords: 
  - "BC32055"
ms.assetid: 97af7cad-6e40-41e3-892d-1fbcbd86356d
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Type &#39;&lt;typename&gt;&#39; cannot inherit from a type parameter
A class or interface includes an [Inherits Statement](../vs140/inherits-statement.md) specifying a generic type parameter.  
  
 A type cannot inherit from a type that is not yet defined. Inheritance involves the ability to reuse members of the base class, which in turn requires that these members be defined. A generic type parameter is a placeholder that is to be replaced by a specific type supplied by a type argument. Therefore, a type cannot inherit from the placeholder.  
  
 **Error ID:** BC32055  
  
### To correct this error  
  
-   If the inheriting type must inherit from another type, use a specific type instead of a type parameter.  
  
-   If the base type must be represented by a generic type parameter, no other type can inherit from it. Remove the [Inherits Statement](../vs140/inherits-statement.md).  
  
## See Also  
 [NOT IN BUILD: Inheritance in Visual Basic](assetId:///e5e6e240-ed31-4657-820c-079b7c79313c)   
 [Generic Types in Visual Basic](../vs140/generic-types-in-visual-basic--visual-basic-.md)