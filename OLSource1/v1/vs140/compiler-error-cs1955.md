---
title: "Compiler Error CS1955"
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
  - "CS1955"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1955"
ms.assetid: 38a8542d-da53-4739-b807-46c8c077363c
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1955
Non-invocable member 'name' cannot be used like a method.  
  
 Only methods and delegates can be invoked. This error is generated when you try to use empty parentheses to call something other than a method or delegate.  
  
### To correct this error  
  
1.  Remove the parentheses from the expression.  
  
## Example  
 The following code generates CS1955 because the code is trying to invoke a field and a property by using the method call operator [()](../vs140/---operator--csharp-reference-.md). You cannot call a field or property, but you can access the value it stores by using the member access operator ( [.](../vs140/.-operator--csharp-reference-.md) ).  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>