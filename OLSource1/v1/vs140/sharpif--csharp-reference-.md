---
title: "#if (C# Reference)"
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
  - "#if"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "#if directive [C#]"
ms.assetid: 48cabbff-ca82-491f-a56a-eeccd528c7c2
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# #if (C# Reference)
When the C# compiler encounters an <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> directive, followed eventually by an [#endif](../vs140/sharpendif--csharp-reference-.md) directive, it will compile the code between the directives only if the specified symbol is defined.  Unlike C and C++, you cannot assign a numeric value to a symbol; the #if statement in C# is Boolean and only tests whether the symbol has been defined or not. For example,  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 You can use the operators [==](../vs140/==-operator--csharp-reference-.md) (equality), [!=](../vs140/!=-operator--csharp-reference-.md) (inequality) only to test for [true](../vs140/true--csharp-reference-.md) or [false](../vs140/false--csharp-reference-.md) . True means the symbol is defined. The statement <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> has the same meaning as <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. You can use the operators [&&](../vs140/---operator--csharp-reference-.md) (and), [&#124;&#124;](../vs140/---operator--csharp-reference-.md) (or), and [!](../vs140/!-operator--csharp-reference-.md) (not) to evaluate whether multiple symbols have been defined. You can also group symbols and operators with parentheses.  
  
## Remarks  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, along with the [#else](../vs140/sharpelse--csharp-reference-.md), [#elif](../vs140/sharpelif--csharp-reference-.md), [#endif](../vs140/sharpendif--csharp-reference-.md), [#define](../vs140/sharpdefine--csharp-reference-.md), and [#undef](../vs140/sharpundef--csharp-reference-.md) directives, lets you include or exclude code based on the existence of one or more symbols. This can be useful when compiling code for a debug build or when compiling for a specific configuration.  
  
 A conditional directive beginning with a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> directive must explicitly be terminated with a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> directive.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> lets you define a symbol, such that, by using the symbol as the expression passed to the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> directive, the expression will evaluate to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
 You can also define a symbol with the [/define](../vs140/-define--csharp-compiler-options-.md) compiler option. You can undefine a symbol with [#undef](../vs140/sharpundef--csharp-reference-.md).  
  
 A symbol that you define with <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> or with <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> does not conflict with a variable of the same name. That is, a variable name should not be passed to a preprocessor directive and a symbol can only be evaluated by a preprocessor directive.  
  
 The scope of a symbol created with <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is the file in which it was defined.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **DEBUG and MYTEST are defined**   
## See Also  
 [C# Programmer's Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Preprocessor Directives](../vs140/csharp-preprocessor-directives.md)