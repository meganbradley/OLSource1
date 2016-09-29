---
title: "Overload resolution failed because no accessible &#39;&lt;genericprocedurename&gt;&#39; accepts this number of type arguments"
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
  - "bc32087"
  - "vbc32087"
helpviewer_keywords: 
  - "BC32087"
ms.assetid: a3eaafd3-80f6-4b7d-9b75-47b043fe17b5
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Overload resolution failed because no accessible &#39;&lt;genericprocedurename&gt;&#39; accepts this number of type arguments
A call to an overloaded generic procedure cannot be resolved because the compiler cannot access any overloaded version with the appropriate number of type parameters.  
  
 When you call a generic procedure, you must supply one type argument for each type parameter. Alternatively, you can supply no type arguments at all and let the compiler attempt to do *type inference*. For more information, see "Type Inference" in [Generic Procedures in Visual Basic](../vs140/generic-procedures-in-visual-basic.md).  
  
 **Error ID:** BC32087  
  
### To correct this error  
  
1.  Ensure that the version you intend to call is accessible by the calling code. See [Access Levels in Visual Basic](../vs140/access-levels-in-visual-basic.md).  
  
2.  Add or remove type arguments from your calling code so that the type argument list matches the type parameter list of the version you intend to call.  
  
     -or-  
  
     Remove all type arguments from your calling code and let the compiler attempt to do type inference. Be aware that type inference can fail if there are conflicts or ambiguities.  
  
## See Also  
 [Overloaded Properties and Methods](../vs140/overloaded-properties-and-methods--visual-basic-.md)   
 [Overload Resolution](../vs140/overload-resolution--visual-basic-.md)   
 [Generic Types in Visual Basic](../vs140/generic-types-in-visual-basic--visual-basic-.md)   
 [Type List](../vs140/type-list--visual-basic-.md)