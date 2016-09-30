---
title: "_environ, _wenviron"
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
  - "environ"
  - "wenviron"
  - "_wenviron"
  - "_environ"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "environ function"
  - "_environ function"
  - "_wenviron function"
  - "process environment"
  - "wenviron function"
ms.assetid: 7e639962-6536-47cd-8095-0cbe44a56e03
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _environ, _wenviron
The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> variable is a pointer to an array of pointers to the multibyte-character strings that constitute the process environment. This global variable has been deprecated for the more secure functional versions [getenv_s, _wgetenv_s](../vs140/getenv_s--_wgetenv_s.md) and [putenv_s, _wputenv_s](../vs140/_putenv_s--_wputenv_s.md), which should be used in place of the global variable. <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is declared in Stdlib.h.  
  
> [!IMPORTANT]
>  This API cannot be used in applications that execute in the Windows Runtime. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 In a program that uses the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> function, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is initialized at program startup according to settings taken from the operating-system environment. The environment consists of one or more entries of the form  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> use the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> variable to access and modify the environment table. When <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is called to add or delete environment settings, the environment table changes size. Its location in memory may also change, depending on the program's memory requirements. The value of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is automatically adjusted accordingly.  
  
 The <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> variable, declared in Stdlib.h as:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 is a wide-character version of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. In a program that uses the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> function, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is initialized at program startup according to settings taken from the operating-system environment.  
  
 In a program that uses <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is initially <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> because the environment is composed of multibyte-character strings. On the first call to <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, a corresponding wide-character string environment is created and is pointed to by <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.  
  
 Similarly, in a program that uses <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> is initially <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> because the environment is composed of wide-character strings. On the first call to <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, a corresponding multibyte-character string environment is created and is pointed to by <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>.  
  
 When two copies of the environment (MBCS and Unicode) exist simultaneously in a program, the run-time system must maintain both copies, resulting in slower execution time. For example, whenever you call <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, a call to <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> is also executed automatically, so that the two environment strings correspond.  
  
> [!CAUTION]
>  In rare instances, when the run-time system is maintaining both a Unicode version and a multibyte version of the environment, these two environment versions might not correspond exactly. This is because, although any unique multibyte-character string maps to a unique Unicode string, the mapping from a unique Unicode string to a multibyte-character string is not necessarily unique. Therefore, two distinct Unicode strings might map to the same multibyte string.  
  
 Polling <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> in a Unicode context is meaningless when [/MD](../vs140/-md---mt---ld--use-run-time-library-.md) or <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> linkage is used. For the CRT DLL, the type (wide or multibyte) of the program is unknown. Only the multibyte type is created because that is the most likely scenario.  
  
 The following pseudo-code illustrates how this can happen.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 In the notation used for this example, the character strings are not C string literals; rather, they are placeholders that represent Unicode environment string literals in the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> call and multibyte environment strings in the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> call. The character placeholders '<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>' and '<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>' in the two distinct Unicode environment strings do not map uniquely to characters in the current MBCS. Instead, both map to some MBCS character '<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>' that is the default result of the attempt to convert the strings.  
  
 Thus, in the multibyte environment, the value of "<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>" after the first implicit call to <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> would be "<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>", but this value would be overwritten on the second implicit call to <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>, when the value of "<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>" is set to "<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>". The Unicode environment (in <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>) and the multibyte environment (in <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>) would therefore differ following this series of calls.  
  
## See Also  
 [Global Variables](../vs140/global-variables.md)   
 [getenv, _wgetenv](../vs140/getenv--_wgetenv.md)   
 [getenv_s, _wgetenv_s](../vs140/getenv_s--_wgetenv_s.md)   
 [_putenv, _wputenv](../vs140/_putenv--_wputenv.md)   
 [putenv_s, _wputenv_s](../vs140/_putenv_s--_wputenv_s.md)