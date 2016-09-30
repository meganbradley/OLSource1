---
title: "Compiler Error C3485"
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
  - "C3485"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3485"
ms.assetid: d67536f9-67a1-4ad9-9a94-d8bbbca3d0dc
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3485
a lambda definition cannot have any cv-qualifiers  
  
 You cannot use a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> qualifier as part of the definition of a lambda expression.  
  
### To correct this error  
  
-   Remove the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> qualifier from the definition of your lambda expression.  
  
## Example  
 The following example generates C3485 because it uses the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> qualifier as part of the definition of a lambda expression:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Lambda Expressions in C++](../vs140/lambda-expressions-in-c--.md)