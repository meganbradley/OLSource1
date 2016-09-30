---
title: "Compiler Error C3489"
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
  - "C3489"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3489"
ms.assetid: 47b58d69-459d-4499-abc7-5f0b9303d773
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3489
'var' is required when the default capture mode is by-value  
  
 When you specify that the default capture mode for a lambda expression is by-value, you cannot pass a variable by value to the capture clause of that expression.  
  
### To correct this error  
  
-   Do not explicitly pass the variable to the capture clause, or  
  
-   Do not specify by-value as the default capture mode, or  
  
-   Specify by-reference as the default capture mode, or  
  
-   Pass the variable by reference to the capture clause. (This might change the behavior of the lambda expression.)  
  
## Example  
 The following example generates C3489 variable <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> appears by value in the capture clause of a lambda expression whose default mode is by-value:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 The following example shows four possible resolutions to C3489:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Lambda Expressions in C++](../vs140/lambda-expressions-in-c--.md)