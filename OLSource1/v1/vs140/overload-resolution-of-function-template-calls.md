---
title: "Overload Resolution of Function Template Calls"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "function templates overload resolution"
ms.assetid: a2918748-2cbb-4fc6-a176-e256f120bee4
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Overload Resolution of Function Template Calls
A function template can overload nontemplate functions of the same name. In this scenario, function calls are resolved by first using template argument deduction to instantiate the function template with a unique specialization. If template argument deduction fails, the other function overloads are considered to resolve the call. These other overloads, also known as the candidate set, include nontemplate functions and other instantiated function templates. If template argument deduction succeeds, then the generated function is compared with the other functions to determine the best match, following the rules for overload resolution. For more information, see [Overloading](../vs140/overloading---c---.md) and [Argument Matching](../vs140/argument-matching.md).  
  
## Example  
 If a nontemplate function is an equally good match to a template function, the nontemplate function is chosen (unless the template arguments were explicitly specified), as in the call <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> in the following example.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **f(int, int)**  
**void f(T1, T2)**  
**void f(T1, T2)**   
## Example  
 The next example illustrates that the exactly matching template function is preferred if the nontemplate function requires a conversion.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **void f(T1, T2)**   
## See Also  
 [Name Resolution](../vs140/templates-and-name-resolution.md)   
 [typename](../vs140/typename.md)   
 [Template Argument Deduction](../vs140/template-argument-deduction.md)