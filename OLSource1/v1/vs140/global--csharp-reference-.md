---
title: "global (C# Reference)"
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
  - "global"
  - "global_CSharpKeyword"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "global keyword [C#]"
ms.assetid: 8932c16a-6959-42c2-86e7-2c4221ab788b
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# global (C# Reference)
The `global` contextual keyword, when it comes before the [:: operator](../vs140/---operator--csharp-reference-.md), refers to the global namespace, which is the default namespace for any C# program and is otherwise unnamed. For more information, see [How to: Use the Namespace Alias Qualifier (C# Programming Guide)](../vs140/how-to--use-the-global-namespace-alias--csharp-programming-guide-.md).  
  
## Example  
 The following example shows how to use the `global` contextual keyword to specify that the class `TestApp` is defined in the global namespace:  
  
 [!code[csrefKeywordsContextual#13](../vs140/codesnippet/CSharp/global--csharp-reference-_1.cs)]  
  
## See Also  
 [Namespaces](../vs140/namespaces--csharp-programming-guide-.md)