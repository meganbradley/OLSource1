---
title: "Type parameter cannot have the same name as its defining function"
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
  - "vbc32090"
  - "bc32090"
helpviewer_keywords: 
  - "BC32090"
ms.assetid: 02f4d82c-dcd7-44cc-b725-81e235f680f6
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Type parameter cannot have the same name as its defining function
A type parameter of a generic type is declared with the same name as the generic type.  
  
 In the type parameter list of a generic type, each type parameter must have a name distinct from all of the following names:  
  
-   Every other type parameter in the same type parameter list,  
  
-   Every type parameter in the type parameter list of any containing generic type, and  
  
-   The name of the generic type itself.  
  
 **Error ID:** BC32090  
  
### To correct this error  
  
-   Rename the type parameter to be distinct from every name cited in the list on this Help page.  
  
## See Also  
 [Generic Types in Visual Basic](../vs140/generic-types-in-visual-basic--visual-basic-.md)   
 [Type List](../vs140/type-list--visual-basic-.md)