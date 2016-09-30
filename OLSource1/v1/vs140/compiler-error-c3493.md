---
title: "Compiler Error C3493"
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
  - "C3493"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3493"
ms.assetid: 734b4257-12a3-436f-8488-c8c55ec81634
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3493
'var' cannot be implicitly captured because no default capture mode has been specified  
  
 The empty lambda expression capture, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, specifies that the lambda expression does not explicitly or implicitly capture any variables.  
  
### To correct this error  
  
-   Provide a default capture mode, or  
  
-   Explicitly capture one or more variables.  
  
## Example  
 The following example generates C3493 because it modifies an external variable but specifies the empty capture clause:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 The following example resolves C3493 by specifying by-reference as the default capture mode.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Lambda Expressions in C++](../vs140/lambda-expressions-in-c--.md)