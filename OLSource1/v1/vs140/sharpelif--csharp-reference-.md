---
title: "#elif (C# Reference)"
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
  - "#elif"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "#elif directive [C#]"
ms.assetid: 731d78df-08e0-4d51-b8c8-f193c27de13f
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# #elif (C# Reference)
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder> lets you create a compound conditional directive. The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> expression will be evaluated if neither the preceding [#if](../vs140/sharpif--csharp-reference-.md) nor any preceding, optional, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> directive expressions evaluate to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. If a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> expression evaluates to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, the compiler evaluates all the code between the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and the next conditional directive. For example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 You can use the operators <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> (equality), <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> (inequality), <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> (and), and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> (or), to evaluate multiple symbols. You can also group symbols and operators with parentheses.  
  
## Remarks  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is equivalent to using:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Using <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is simpler, because each <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> requires a [#endif](../vs140/sharpendif--csharp-reference-.md), whereas a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> can be used without a matching <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
 See [#if](../vs140/sharpif--csharp-reference-.md) for an example of how to use <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
## See Also  
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Preprocessor Directives](../vs140/csharp-preprocessor-directives.md)