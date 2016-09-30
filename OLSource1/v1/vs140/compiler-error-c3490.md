---
title: "Compiler Error C3490"
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
  - "C3490"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3490"
ms.assetid: 7638559a-fd06-4527-a9c1-0c8ae68b3123
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3490
'var' cannot be modified because it is being accessed through a const object  
  
 A lambda expression that is declared in a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> method cannot modify non-mutable member data.  
  
### To correct this error  
  
-   Remove the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> modifier from your method declaration.  
  
## Example  
 The following example generates C3490 because it modifies the member variable<CodeContentPlaceHolder>4\</CodeContentPlaceHolder> in a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> method:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 The following example resolves C3490 by removing the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> modifier from the method declaration:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Lambda Expressions in C++](../vs140/lambda-expressions-in-c--.md)