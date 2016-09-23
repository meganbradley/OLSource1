---
title: "Type parameter already declared with name &#39;&lt;typeparametername&gt;&#39;"
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
  - vbc32049
  - bc32049
helpviewer_keywords: 
  - BC32049
ms.assetid: d7affad0-0c3d-4fce-a1c2-a17f65514471
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Type parameter already declared with name &#39;&lt;typeparametername&gt;&#39;
A type parameter of a generic type is declared with the same name as another type parameter of that same generic type.  
  
 In the type parameter list of a generic type, each type parameter must have a name distinct from all of the following names:  
  
-   Every other type parameter in the same type parameter list,  
  
-   Every type parameter in the type parameter list of any containing generic type, and  
  
-   The name of the generic type itself.  
  
 **Error ID:** BC32049  
  
### To correct this error  
  
-   Rename the type parameter to be distinct from every name cited in the list on this Help page.  
  
## See Also  
 [Generic Types in Visual Basic](../vs140/generic-types-in-visual-basic--visual-basic-.md)   
 [Type List](../vs140/type-list--visual-basic-.md)