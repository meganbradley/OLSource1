---
title: "Compiler Error C3534"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "C3534"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3534"
ms.assetid: 41d4328b-8ce3-4a11-bb0c-c96f6af03b01
caps.latest.revision: 11
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3534
a 'new expression' whose type contains 'auto' must have a single initializer expression  
  
 If a [new](../vs140/operator-new---new--.md) expression is used with the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> keyword and the default [/Zc:auto](../vs140/-zc-auto--deduce-variable-type-.md) compiler option, the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> expression must specify a single initializer.  
  
### To correct this error  
  
1.  Specify a single initializer expression for the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> operator.  
  
## Example  
 The following example demonstrates C3534. The first declaration does not yield an error because it has a direct initializer (0) whose type is <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. The second declaration yields an error because it does not have an initializer. In the third declaration, the second use of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> keyword yields an error because the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> operator does not have an initializer.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [auto Keyword](../vs140/auto-keyword.md)   
 [operator new (\<new>)](../vs140/operator-new---new--.md)