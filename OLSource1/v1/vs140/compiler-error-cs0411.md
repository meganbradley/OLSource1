---
title: "Compiler Error CS0411"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "CS0411"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0411"
ms.assetid: 290947c9-10d0-427e-99f2-bff20299d533
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0411
The type arguments for method 'method' cannot be inferred from the usage. Try specifying the type arguments explicitly.  
  
 This error occurs if you call a generic method without explicitly providing the type arguments and the compiler cannot infer which type arguments are intended. To avoid this error, add the intended type arguments in angle brackets.  
  
## Example  
 The following sample generates CS0411:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 Other possible error cases include when the parameter is <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, which has no type information:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>