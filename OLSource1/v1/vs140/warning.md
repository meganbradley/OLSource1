---
title: "warning"
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
  - "warning_CPP"
  - "vc-pragma.warning"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "pragmas, warning"
  - "push pragma warning"
  - "pop warning pragma"
  - "warning pragma"
ms.assetid: 8e9a0dec-e223-4657-b21d-5417ebe29cc8
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# warning
Enables selective modification of the behavior of compiler warning messages.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The following warning-specifier parameters are available.  
  
|warning-specifier|Meaning|  
|------------------------|-------------|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Apply the given level to the specified warning(s). This also turns on a specified warning that is off by default.|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Reset warning behavior to its default value. This also turns on a specified warning that is off by default. The warning will be generated at its default, documented, level.\<br />\<br /> For more information, see [Compiler Warnings That Are Off by Default](../vs140/compiler-warnings-that-are-off-by-default.md).|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|Do not issue the specified warning message(s).|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Report the specified warnings as errors.|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|Display the specified message(s) only one time.|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Pushes the current state of the pragma on the stack, disables the specified warning for the next line, and then pops the warning stack so that the pragma state is reset.|  
  
 The following code statement illustrates that a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> parameter can contain multiple warning numbers, and that multiple <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> parameters can be specified in the same pragma directive.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 This is functionally equivalent to the following code.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The compiler adds 4000 to any warning number that is between 0 and 999.  
  
 For warning numbers in the range 4700-4999, which are the ones associated with code generation, the state of the warning in effect when the compiler encounters the open curly brace of a function will be in effect for the rest of the function. Using the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> pragma in the function to change the state of a warning that has a number larger than 4699 will only take effect after the end of the function. The following example shows the correct placement of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> pragmas to disable a code-generation warning message, and then to restore it.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Notice that throughout a function body, the last setting of the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> pragma will be in effect for the whole function.  
  
## Push and Pop  
 The <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> pragma also supports the following syntax.  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> [ <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> ] <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
  
 Where <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> represents a warning level (1 through 4).  
  
 The pragma <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> stores the current warning state for every warning. The pragma <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> stores the current state for every warning and sets the global warning level to <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>.  
  
 The pragma <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> pops the last warning state pushed onto the stack. Any changes that you made to the warning state between <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> are undone. Consider this example:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 At the end of this code, <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> restores the state of every warning (includes 4705, 4706, and 4707) to what it was at the start of the code.  
  
 When you write header files, you can use <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> to guarantee that warning-state changes made by a user do not prevent the headers from compiling correctly. Use <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> at the start of the header and <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> at the end. For example, if you have a header that does not compile cleanly at warning level 4, the following code would change the warning level to 3 and then restore the original warning level at the end of the header.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 For more information about compiler options that help you suppress warnings, see [/FI](../vs140/-fi--name-forced-include-file-.md) and [/w](../vs140/-w---w0---w1---w2---w3---w4---w1---w2---w3---w4---wall---wd---we---wo---wv---wx--warning-level-.md).  
  
## See Also  
 [Pragma Directives and the __Pragma Keyword](../vs140/pragma-directives-and-the-__pragma-keyword.md)