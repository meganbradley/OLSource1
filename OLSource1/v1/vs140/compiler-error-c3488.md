---
title: "Compiler Error C3488"
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
  - "C3488"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3488"
ms.assetid: 0a6fcd76-dd3b-48d7-abb3-22eccda96034
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3488
'var' is not allowed when the default capture mode is by-reference  
  
 When you specify that the default capture mode for a lambda expression is by-reference, you cannot pass a variable by reference to the capture clause of that expression.  
  
### To correct this error  
  
-   Do not explicitly pass the variable to the capture clause, or  
  
-   Do not specify by-reference as the default capture mode, or  
  
-   Specify by-value as the default capture mode, or  
  
-   Pass the variable by value to the capture clause. (This might change the behavior of the lambda expression.)  
  
## Example  
 The following example generates C3488 because a reference to the variable <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> appears in the capture clause of a lambda expression whose default mode is by-reference:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 The following example shows four possible resolutions to C3488:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Lambda Expressions in C++](../vs140/lambda-expressions-in-c--.md)