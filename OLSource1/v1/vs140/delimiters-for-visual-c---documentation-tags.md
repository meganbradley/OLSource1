---
title: "Delimiters for Visual C++ Documentation Tags"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "XML documentation, delimiters"
ms.assetid: debfbdd9-63fa-4c58-a18e-a4d203d241d7
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Delimiters for Visual C++ Documentation Tags
The use of documentation tags requires delimiters, which indicate to the compiler where a documentation comment begins and ends.  
  
 You can use the following kinds of delimiters with the XML documentation tags:  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 This is the form that is shown in documentation examples and used by the Visual C++ project templates.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 These are multiline delimiters.  
  
 There are some formatting rules when using the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> delimiters:  
  
-   For the line that contains the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> delimiter, if the remainder of the line is white space, the line is not processed for comments. If the first character is white space, that white space character is ignored and the rest of the line is processed. Otherwise, the entire text of the line after the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> delimiter is processed as part of the comment.  
  
-   For the line that contains the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> delimiter, if there is only white space up to the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> delimiter, that line is ignored. Otherwise, the text on the line up to the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> delimiter is processed as part of the comment, subject to the pattern-matching rules described in the following bullet.  
  
-   For the lines after the one that begins with the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> delimiter, the compiler looks for a common pattern at the beginning of each line that consists of optional white space and an asterisk (<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>), followed by more optional white space. If the compiler finds a common set of characters at the beginning of each line, it will ignore that pattern for all lines after the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> delimiter, up to and possibly including the line that contains the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> delimiter.  
  
 Some examples:  
  
-   The only part of the following comment that will be processed is the line that begins with <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. The following two tag formats will produce the same comments:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
-   The compiler applies a pattern of " * " to ignore at the beginning of the second and third lines.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
-   The compiler finds no pattern in this comment because there is no asterisk on the second line. Therefore, all text on the second and third lines, up till the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, will be processed as part of the comment.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
-   The compiler finds no pattern in this comment for two reasons. First, there is no line that begins with a consistent number of spaces before the asterisk. Second, the fifth line begins with a tab, which does not match spaces. Therefore, all text from the second line until the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> will be processed as part of the comment.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [XML Documentation](../vs140/xml-documentation--visual-c---.md)