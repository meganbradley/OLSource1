---
title: "Parsing C++ Command-Line Arguments"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "quotation marks, command-line arguments"
  - "double quotation marks"
  - "command line, parsing"
  - "parsing, command-line arguments"
  - "startup code, parsing command-line arguments"
ms.assetid: e634e733-ac2f-4298-abe2-7e9288c94951
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Parsing C++ Command-Line Arguments
**Microsoft Specific**  
  
 Microsoft C/C++ startup code uses the following rules when interpreting arguments given on the operating system command line:  
  
-   Arguments are delimited by white space, which is either a space or a tab.  
  
-   The caret character (^) is not recognized as an escape character or delimiter. The character is handled completely by the command-line parser in the operating system before being passed to the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> array in the program.  
  
-   A string surrounded by double quotation marks ("*string*") is interpreted as a single argument, regardless of white space contained within. A quoted string can be embedded in an argument.  
  
-   A double quotation mark preceded by a backslash (\\") is interpreted as a literal double quotation mark character (").  
  
-   Backslashes are interpreted literally, unless they immediately precede a double quotation mark.  
  
-   If an even number of backslashes is followed by a double quotation mark, one backslash is placed in the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> array for every pair of backslashes, and the double quotation mark is interpreted as a string delimiter.  
  
-   If an odd number of backslashes is followed by a double quotation mark, one backslash is placed in the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> array for every pair of backslashes, and the double quotation mark is "escaped" by the remaining backslash, causing a literal double quotation mark (") to be placed in <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Example  
 The following program demonstrates how command-line arguments are passed:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The following table shows example input and expected output, demonstrating the rules in the preceding list.  
  
### Results of Parsing Command Lines  
  
|Command-Line Input|argv[1]|argv[2]|argv[3]|  
|-------------------------|---------------|---------------|---------------|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|  
  
## END Microsoft Specific  
  
## See Also  
 [main: Program Startup](../vs140/main--program-startup.md)