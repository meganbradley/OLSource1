---
title: "Attributes cannot be generics or types nested inside generics"
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
  - bc32067
  - vbc32067
helpviewer_keywords: 
  - BC32067
ms.assetid: 93ae2848-0a72-4ae5-82a3-32e0a49bb7cd
caps.latest.revision: 14
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Attributes cannot be generics or types nested inside generics
An attribute is declared as a generic type, or within a generic type.  
  
 Visual Basic and the .NET Framework do not currently support any combination of attributes and generic types. This means the following limitations apply:  
  
-   An attribute cannot be a generic type or be declared within a generic type.  
  
-   An attribute cannot inherit from a generic class, nor can a generic class inherit from an attribute.  
  
-   When you apply an attribute, you cannot supply an argument that is any of the following:  
  
    -   A generic type,  
  
    -   A type constructed from a generic type,  
  
    -   A type parameter of a containing type, or  
  
    -   A type constructed from a type parameter of a containing type.  
  
 **Error ID:** BC32067  
  
### To correct this error  
  
-   If the attribute declaration includes the `Of` keyword and a type parameter list, then remove them.  
  
-   If the attribute declaration appears inside a generic type, then move it to where it is not inside any generic type.  
  
## See Also  
 <xref:System.Attribute?qualifyHint=False>   
 [NOT IN BUILD: Attributes Overview in Visual Basic](assetId:///0d0cff64-892d-4f57-83bd-bef388553d4f)   
 [Generic Types in Visual Basic](../vs140/generic-types-in-visual-basic--visual-basic-.md)