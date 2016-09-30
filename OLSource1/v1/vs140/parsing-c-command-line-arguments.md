---
title: "Parsing C Command-Line Arguments"
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
  - "quotation marks, command-line arguments"
  - "double quotation marks"
  - "command line, parsing"
  - "parsing, command-line arguments"
  - "startup code, parsing command-line arguments"
ms.assetid: ffce8037-2811-45c4-8db4-1ed787859c80
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Parsing C Command-Line Arguments
**Microsoft Specific**  
  
 Microsoft C startup code uses the following rules when interpreting arguments given on the operating system command line:  
  
-   Arguments are delimited by white space, which is either a space or a tab.  
  
-   A string surrounded by double quotation marks is interpreted as a single argument, regardless of white space contained within. A quoted string can be embedded in an argument. Note that the caret (**^**) is not recognized as an escape character or delimiter.  
  
-   A double quotation mark preceded by a backslash, **\\"**, is interpreted as a literal double quotation mark (**"**).  
  
-   Backslashes are interpreted literally, unless they immediately precede a double quotation mark.  
  
-   If an even number of backslashes is followed by a double quotation mark, then one backslash (**\\**) is placed in the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> array for every pair of backslashes (**\\\\**), and the double quotation mark (**"**) is interpreted as a string delimiter.  
  
-   If an odd number of backslashes is followed by a double quotation mark, then one backslash (**\\**) is placed in the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> array for every pair of backslashes (**\\\\**) and the double quotation mark is interpreted as an escape sequence by the remaining backslash, causing a literal double quotation mark (**"**) to be placed in <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 This list illustrates the rules above by showing the interpreted result passed to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> for several examples of command-line arguments. The output listed in the second, third, and fourth columns is from the ARGS.C program that follows the list.  
  
|Command-Line Input|argv[1]|argv[2]|argv[3]|  
|-------------------------|---------------|---------------|---------------|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|  
  
## Example  
  
### Code  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Comments  
 One example of output from this program is:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **END Microsoft Specific**  
  
## See Also  
 [The main Function and Program Execution](../vs140/main-function-and-program-execution.md)