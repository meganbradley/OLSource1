---
title: "Too many type arguments"
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
  - "vbc36579"
  - "bc36579"
helpviewer_keywords: 
  - "BC36579"
ms.assetid: f59617b2-ca66-45c6-baaa-3c8bdf7f9a55
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Too many type arguments
A generic method has been invoked with more type arguments than there are type parameters.  
  
 When you invoke a generic method, you must supply one type argument for each type parameter defined by that method.  
  
 **Error ID:** BC36579  
  
### To correct this error  
  
-   Remove type arguments from your type argument list so that there is one for each type parameter of the generic method you are invoking.  
  
## See Also  
 [Generic Types in Visual Basic](../vs140/generic-types-in-visual-basic--visual-basic-.md)   
 [Type List](../vs140/type-list--visual-basic-.md)