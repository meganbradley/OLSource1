---
title: "C Comments"
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
  - "C"
helpviewer_keywords: 
  - "code comments, C code"
  - "comments, documenting code"
  - "comments, C code"
  - "/* */ comment delimiters"
  - "comments"
ms.assetid: 0f5f2825-e673-49e7-8669-94e2f5294989
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# C Comments
A "comment" is a sequence of characters beginning with a forward slash/asterisk combination (**/\***) that is treated as a single white-space character by the compiler and is otherwise ignored. A comment can include any combination of characters from the representable character set, including newline characters, but excluding the "end comment" delimiter (**\*/**). Comments can occupy more than one line but cannot be nested.  
  
 Comments can appear anywhere a white-space character is allowed. Since the compiler treats a comment as a single white-space character, you cannot include comments within tokens. The compiler ignores the characters in the comment.  
  
 Use comments to document your code. This example is a comment accepted by the compiler:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Comments can appear on the same line as a code statement:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 You can choose to precede functions or program modules with a descriptive comment block:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Since comments cannot contain nested comments, this example causes an error:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The error occurs because the compiler recognizes the first <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, after the words <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, as the end of the comment. It tries to process the remaining text and produces an error when it finds the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> outside a comment.  
  
 While you can use comments to render certain lines of code inactive for test purposes, the preprocessor directives <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and conditional compilation are a useful alternative for this task. For more information, see [Preprocessor Directives](../vs140/preprocessor-directives.md) in the *Preprocessor Reference*.  
  
 **Microsoft Specific**  
  
 The Microsoft compiler also supports single-line comments preceded by two forward slashes (**//**). If you compile with /Za (ANSI standard), these comments generate errors. These comments cannot extend to a second line.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Comments beginning with two forward slashes (**//**) are terminated by the next newline character that is not preceded by an escape character. In the next example, the newline character is preceded by a backslash (**\\**), creating an "escape sequence." This escape sequence causes the compiler to treat the next line as part of the previous line. (For more information, see [Escape Sequences](../vs140/escape-sequences.md).)  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Therefore, the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> statement is commented out.  
  
 The default for Microsoft C is that the Microsoft extensions are enabled. Use /Za to disable these extensions.  
  
 **END Microsoft Specific**  
  
## See Also  
 [C Tokens](../vs140/c-tokens.md)