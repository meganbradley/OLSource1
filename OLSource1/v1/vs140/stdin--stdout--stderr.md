---
title: "stdin, stdout, stderr"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "stdin"
  - "stderr"
  - "stdout"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "stdout function"
  - "standard output stream"
  - "standard error stream"
  - "stdin function"
  - "standard input stream"
  - "stderr function"
ms.assetid: badd4735-596d-4498-857c-ec8b7e670e4c
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# stdin, stdout, stderr
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 These are standard streams for input, output, and error output.  
  
 By default, standard input is read from the keyboard, while standard output and standard error are printed to the screen.  
  
 The following stream pointers are available to access the standard streams:  
  
|Pointer|Stream|  
|-------------|------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Standard input|  
|**stdout**|Standard output|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Standard error|  
  
 These pointers can be used as arguments to functions. Some functions, such as **getchar** and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, use <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and **stdout** automatically.  
  
 These pointers are constants, and cannot be assigned new values. The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> function can be used to redirect the streams to disk files or to other devices. The operating system allows you to redirect a program's standard input and output at the command level.  
  
## See Also  
 [Stream I/O](../vs140/stream-i-o.md)   
 [Global Constants](../vs140/global-constants.md)