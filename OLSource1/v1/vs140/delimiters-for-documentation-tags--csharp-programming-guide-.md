---
title: "Delimiters for Documentation Tags (C# Programming Guide)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "XML [C#], delimiters"
  - "/** */ delimiters for C# documentation tags"
  - "/// delimiter for C# documentation"
ms.assetid: 9b2bdd18-4f5c-4c0b-988e-fb992e0d233e
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Delimiters for Documentation Tags (C# Programming Guide)
The use of XML doc comments requires delimiters, which indicate to the compiler where a documentation comment begins and ends. You can use the following kinds of delimiters with the XML documentation tags:  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Single-line delimiter. This is the form that is shown in documentation examples and used by the Visual C# project templates. If there is a white space character following the delimiter, that character is not included in the XML output.  
  
> [!NOTE]
>  The Visual Studio IDE has a feature called Smart Comment Editing that automatically inserts the \<summary> and \</summary> tags and moves your cursor within these tags after you type the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> delimiter in the Code Editor. Access this feature from the [Formatting, C#/J#, Text Editor, Options Dialog Box](../vs140/options--text-editor--csharp--formatting.md) in your project property pages.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Multiline delimiters.  
  
 There are some formatting rules to follow when you use the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> delimiters.  
  
-   On the line that contains the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> delimiter, if the remainder of the line is white space, the line is not processed for comments. If the first character after the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> delimiter is white space, that white space character is ignored and the rest of the line is processed. Otherwise, the entire text of the line after the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> delimiter is processed as part of the comment.  
  
-   On the line that contains the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> delimiter, if there is only white space up to the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> delimiter, that line is ignored. Otherwise, the text on the line up to the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> delimiter is processed as part of the comment, subject to the pattern-matching rules described in the following bullet.  
  
-   For the lines after the one that begins with the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> delimiter, the compiler looks for a common pattern at the beginning of each line. The pattern can consist of optional white space and an asterisk (<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>), followed by more optional white space. If the compiler finds a common pattern at the beginning of each line that does not begin with the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> delimiter or the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> delimiter, it ignores that pattern for each line.  
  
 The following examples illustrate these rules.  
  
-   The only part of the following comment that will be processed is the line that begins with <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>. The three tag formats produce the same comments.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
-   The compiler identifies a common pattern of " * " at the beginning of the second and third lines. The pattern is not included in the output.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
-   The compiler finds no common pattern in the following comment because the second character on the third line is not an asterisk. Therefore, all text on the second and third lines is processed as part of the comment.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
-   The compiler finds no pattern in the following comment for two reasons. First, the number of spaces before the asterisk is not consistent. Second, the fifth line begins with a tab, which does not match spaces. Therefore, all text from lines two through five is processed as part of the comment.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Documenting Your Code with XML](../vs140/xml-documentation-comments--csharp-programming-guide-.md)   
 [/doc (C# Compiler Options)](../vs140/-doc--csharp-compiler-options-.md)   
 [XML Documentation Comments](../vs140/xml-documentation-comments--csharp-programming-guide-.md)