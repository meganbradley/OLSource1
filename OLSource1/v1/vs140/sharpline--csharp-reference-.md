---
title: "#line (C# Reference)"
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
  - "#line"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "#line directive [C#]"
ms.assetid: 6439e525-5dd5-4acb-b8ea-efabb32ff95b
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# #line (C# Reference)
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder> lets you modify the compiler's line number and (optionally) the file name output for errors and warnings. This example shows how to report two warnings associated with line numbers. The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> directive forces the line number to be 200 (although the default is #7) and until the next #line directive, the filename will be reported as "Special". The #line default directive returns the line numbering to its default numbering, which counts the lines that were renumbered by the previous directive.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> directive might be used in an automated, intermediate step in the build process. For example, if lines were removed from the original source code file, but you still wanted the compiler to generate output based on the original line numbering in the file, you could remove lines and then simulate the original line numbering with <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> directive hides the successive lines from the debugger, such that when the developer steps through the code, any lines between a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and the next <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> directive (assuming that it is not another <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> directive) will be stepped over. This option can also be used to allow ASP.NET to differentiate between user-defined and machine-generated code. Although ASP.NET is the primary consumer of this feature, it is likely that more source generators will make use of it.  
  
 A <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> directive does not affect file names or line numbers in error reporting. That is, if an error is encountered in a hidden block, the compiler will report the current file name and line number of the error.  
  
 The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> directive specifies the file name you want to appear in the compiler output. By default, the actual name of the source code file is used. The file name must be in double quotation marks ("") and must be preceded by a line number.  
  
 A source code file can have any number of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> directives.  
  
## Example 1  
 The following example shows how the debugger ignores the hidden lines in the code. When you run the example, it will display three lines of text. However, when you set a break point, as shown in the example, and hit F10 to step through the code, you will notice that the debugger ignores the hidden line. Notice also that even if you set a break point at the hidden line, the debugger will still ignore it.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [C# Programmer's Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Preprocessor Directives](../vs140/csharp-preprocessor-directives.md)