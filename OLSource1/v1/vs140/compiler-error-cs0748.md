---
title: "Compiler Error CS0748"
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
  - "CS0748"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0748"
ms.assetid: da1935af-a5ea-41f4-84ae-58559b750566
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0748
Inconsistent lambda parameter usage; all parameter types must either be explicit or implicit.  
  
 If a lambda expression has multiple input parameters, some parameters cannot use implicit typing while others use explicit typing.  
  
### To correct this error  
  
1.  Give all the input parameters implicit types, or give them all explicit types.  
  
## Example  
 The following code generates CS0748 because, in the lambda expression, only <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is given an explicit type:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Lambda Expressions (C# Programming Guide)](../vs140/lambda-expressions--csharp-programming-guide-.md)