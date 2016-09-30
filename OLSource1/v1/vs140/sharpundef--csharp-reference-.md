---
title: "#undef (C# Reference)"
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
  - "#undef"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "#undef directive [C#]"
ms.assetid: 686c92d2-7194-4be4-b2f4-80091712d513
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# #undef (C# Reference)
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder> lets you undefine a symbol, such that, by using the symbol as the expression in a [#if](../vs140/sharpif--csharp-reference-.md) directive, the expression will evaluate to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 A symbol can be defined either with the [#define](../vs140/sharpdefine--csharp-reference-.md) directive or the [/define](../vs140/-define--csharp-compiler-options-.md) compiler option. The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> directive must appear in the file before you use any statements that are not also directives.  
  
## Example  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **DEBUG is not defined**   
## See Also  
 [C# Programmer's Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Preprocessor Directives](../vs140/csharp-preprocessor-directives.md)