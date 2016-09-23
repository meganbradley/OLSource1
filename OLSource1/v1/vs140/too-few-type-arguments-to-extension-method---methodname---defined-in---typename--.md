---
title: "Too few type arguments to extension method &#39;&lt;methodname&gt;&#39; defined in &#39;&lt;typename&gt;&#39;"
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
  - vbc36590
  - bc36590
helpviewer_keywords: 
  - BC36590
ms.assetid: 8a9dd2d3-d8af-4ef5-8427-eb6e83d16230
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Too few type arguments to extension method &#39;&lt;methodname&gt;&#39; defined in &#39;&lt;typename&gt;&#39;
A generic extension method has been invoked with fewer type arguments than there are type parameters in the method definition.  
  
 When you invoke a generic method, you must supply one type argument for each type parameter defined by that method.  
  
 **Error ID:** BC36590  
  
### To correct this error  
  
-   Add type arguments to your type argument list so that there is one for each type parameter of the extension method that you are invoking.  
  
## See Also  
 [Extension Methods (Visual Basic)](../vs140/extension-methods--visual-basic-.md)   
 [Generic Types in Visual Basic](../vs140/generic-types-in-visual-basic--visual-basic-.md)   
 [Type List](../vs140/type-list--visual-basic-.md)   
 [Generic Procedures in Visual Basic](../vs140/generic-procedures-in-visual-basic.md)