---
title: "Compiler Error C2143"
ms.custom: na
ms.date: "09/23/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "C2143"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2143"
ms.assetid: 1d8d1456-e031-4965-9240-09a6e33ba81c
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2143
syntax error : missing 'token1' before 'token2'  
  
 The compiler expected a specific token (that is, a language element other than white space) and found another token instead.  
  
 For information about this error when it occurs when you are using a function-try block, see [Knowledge Base article 241706](http://support.microsoft.com/kb/241706).  
  
 Check the [C++ Language Reference](../vs140/c---language-reference.md) to determine where code is syntactically incorrect. Because the compiler may report this error after it encounters the line that causes the problem, check several lines of code that precede the error.  
  
 C2143 can occur in different situations.  
  
 It can occur when an operator that can qualify a name (<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>) must be followed by the keyword <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, as in this example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 By default, C++ assumes that <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> isn't a template; therefore, the following <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is interpreted as a less-than sign.  You must tell the compiler explicitly that <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is a template so that it can correctly parse the angle bracket. To correct this error, use the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> keyword on the dependent type's name, as shown here:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 C2143 can occur when **/clr** is used and a <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> directive has a syntax error:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 It can also occur when you are trying to compile a source code file by using CLR syntax without also using **/clr**:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The first non-whitespace character that follows an <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> statement must be a left parenthesis. The compiler cannot translate anything else:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 C2143 can occur when a closing brace, parenthesis, or semicolon is missing on the line where the error is detected or on one of the lines just above:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Or when there's an invalid tag in a class declaration:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Or when a label is not attached to a statement. If you must place a label by itself, for example, at the end of a compound statement, attach it to a null statement:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The error can occur when an unqualified call is made to a type in the Standard C++ Library:  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Or there is a missing <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> keyword:  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Or if you try to define an explicit instantiation:  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 In a C program, variables must be declared at the beginning of the function, and they cannot be declared after the function executes non-declaration instructions.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>