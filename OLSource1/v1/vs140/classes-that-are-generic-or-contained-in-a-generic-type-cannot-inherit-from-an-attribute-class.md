---
title: "Classes that are generic or contained in a generic type cannot inherit from an attribute class"
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
  - "vbc32074"
  - "BC32074"
helpviewer_keywords: 
  - "BC32074"
ms.assetid: 3552ac98-d86a-4962-9d51-b9a8acc38ea1
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Classes that are generic or contained in a generic type cannot inherit from an attribute class
A class that is either generic or nested within a generic type specifies that it inherits from an attribute class.  
  
 Visual Basic and the .NET Framework do not currently support any combination of attributes and generic types. This means the following limitations apply:  
  
-   An attribute cannot be a generic type or be declared within a generic type.  
  
-   An attribute cannot inherit from a generic class, nor can a generic class inherit from an attribute.  
  
-   When you apply an attribute, you cannot supply an argument that is any of the following:  
  
    -   A generic type,  
  
    -   A type constructed from a generic type,  
  
    -   A type parameter of a containing type, or  
  
    -   A type constructed from a type parameter of a containing type.  
  
 **Error ID:** BC32074  
  
### To correct this error  
  
-   Change the base class to something other than an attribute class, or remove the `Inherits` statement entirely.  
  
## See Also  
 <xref:System.Attribute*>   
 [NOT IN BUILD: Attributes Overview in Visual Basic](assetId:///0d0cff64-892d-4f57-83bd-bef388553d4f)   
 [Generic Types in Visual Basic](../vs140/generic-types-in-visual-basic--visual-basic-.md)   
 [Inheritance Basics](../vs140/inheritance-basics--visual-basic-.md)   
 [Inherits Statement](../vs140/inherits-statement.md)