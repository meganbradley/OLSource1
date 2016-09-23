---
title: "Type parameter &#39;&lt;typeparametername&gt;&#39; has the same name as a type parameter of an enclosing type"
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
  - vbc40048
  - bc40048
helpviewer_keywords: 
  - BC40048
ms.assetid: d5428b36-88d3-42c4-a096-cbc7bb9571f2
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Type parameter &#39;&lt;typeparametername&gt;&#39; has the same name as a type parameter of an enclosing type
A type parameter of a generic type is declared with the same name as a type parameter of a containing generic type.  
  
 In the type parameter list of a generic type, each type parameter must have a name distinct from all of the following names:  
  
-   Every other type parameter in the same type parameter list,  
  
-   Every type parameter in the type parameter list of any containing generic type, and  
  
-   The name of the generic type itself.  
  
 By default, this message is a warning. For information on hiding warnings or treating warnings as errors, see [Configuring Warnings in Visual Basic](../vs140/configuring-warnings-in-visual-basic.md).  
  
 **Error ID:** BC40048  
  
### To correct this error  
  
-   Rename the type parameter to be distinct from every name cited in the list on this Help page.  
  
## See Also  
 [Generic Types in Visual Basic](../vs140/generic-types-in-visual-basic--visual-basic-.md)   
 [Type List](../vs140/type-list--visual-basic-.md)