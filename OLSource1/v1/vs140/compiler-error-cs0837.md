---
title: "Compiler Error CS0837"
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
  - "CS0837"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0837"
ms.assetid: cbde45dc-222c-4bfe-8814-856476319d37
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0837
The first operand of an "is" or "as" operator may not be a lambda expression or anonymous method.  
  
 Lambda expressions and anonymous methods may not be used on the left side of [is](../vs140/is--csharp-reference-.md) or [as](../vs140/as--csharp-reference-.md).  
  
### To correct this error  
  
-   If the error involves the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> operator, remember that <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> takes a value and a type and tells you whether the value can be made into that type by a reference, boxing, or unboxing conversion. Because lambdas are not values and have no reference, boxing, or unboxing conversions, lambdas are not candidates for <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
-   If the code misuses <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, the correction is probably to change it to a cast.  
  
## Example  
 The following example generates CS0837:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>