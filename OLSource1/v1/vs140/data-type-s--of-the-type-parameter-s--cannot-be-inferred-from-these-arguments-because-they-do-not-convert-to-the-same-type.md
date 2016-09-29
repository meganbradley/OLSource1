---
title: "Data type(s) of the type parameter(s) cannot be inferred from these arguments because they do not convert to the same type"
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
  - "vbc36659"
  - "bc36659"
  - "vbc36656"
  - "bc36656"
helpviewer_keywords: 
  - "BC36659"
  - "BC36656"
ms.assetid: 0aa809da-3b44-4d78-b3c5-0a148bdf7ce8
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Data type(s) of the type parameter(s) cannot be inferred from these arguments because they do not convert to the same type
Data type(s) of the type parameter(s) cannot be inferred from these arguments because they do not convert to the same type. Specifying the data type(s) explicitly might correct this error.  
  
 This error occurs when overload resolution has failed. It occurs as a subordinate message that states why a particular overload candidate has been eliminated. The error explains that the compiler cannot use type inference to find data types for the type parameters that are compatible with the arguments.  
  
> [!NOTE]
>  When specifying arguments is not an option (for example, for query operators in query expressions), the error message appears without the second sentence.  
  
 For more information and examples, see [Data type(s) of the type parameter(s) in method '\<methodname>' cannot be inferred from these arguments because they do not convert to the same type](../vs140/data-type-s--of-the-type-parameter-s--in-method---methodname---cannot-be-inferred-from-these-arguments-because-they-do-not-convert-to-the-same-type.md).  
  
 **Error ID:** BC36659 and BC36656  
  
## See Also  
 [Relaxed Delegate Conversion](../vs140/relaxed-delegate-conversion--visual-basic-.md)   
 [Generic Procedures in Visual Basic](../vs140/generic-procedures-in-visual-basic.md)   
 [Overload Resolution](../vs140/overload-resolution--visual-basic-.md)