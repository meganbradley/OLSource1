---
title: "_putenv, _wputenv"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
apiname: 
  - "_putenv"
  - "_wputenv"
apilocation: 
  - "msvcr110.dll"
  - "msvcr100.dll"
  - "msvcrt.dll"
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr80.dll"
  - "msvcr90.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_tputenv"
  - "_wputenv"
  - "_putenv"
  - "wputenv"
  - "tputenv"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_putenv function"
  - "environment variables, deleting"
  - "putenv function"
  - "tputenv function"
  - "environment variables, creating"
  - "wputenv function"
  - "_wputenv function"
  - "_tputenv function"
  - "environment variables, modifying"
ms.assetid: 9ba9b7fd-276e-45df-8420-d70c4204b8bd
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _putenv, _wputenv
Creates, modifies, or removes environment variables. More secure versions of these functions are available; see [putenv_s, _wputenv_s](../vs140/_putenv_s--_wputenv_s.md).  
  
> [!IMPORTANT]
>  This API cannot be used in applications that execute in the Windows Runtime. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Environment-string definition.  
  
## Return Value  
 Return 0 if successful or –1 in the case of an error.  
  
## Remarks  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> function adds new environment variables or modifies the values of existing environment variables. Environment variables define the environment in which a process executes (for example, the default search path for libraries to be linked with a program). <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is a wide-character version of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>; the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> argument to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is a wide-character string.  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|  
  
 The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> argument must be a pointer to a string of the form <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is the name of the environment variable to be added or modified and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is the variable's value. If <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is already part of the environment, its value is replaced by <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>; otherwise, the new <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> variable and its <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> value are added to the environment. You can remove a variable from the environment by specifying an empty <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> — in other words, by specifying only <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> affect only the environment that is local to the current process; you cannot use them to modify the command-level environment. That is, these functions operate only on data structures accessible to the run-time library and not on the environment segment created for a process by the operating system. When the current process terminates, the environment reverts to the level of the calling process (in most cases, the operating-system level). However, the modified environment can be passed to any new processes created by <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, and these new processes get any new items added by <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.  
  
 Do not change an environment entry directly: instead, use <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> to change it. In particular, direct freeing elements of the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> global array might lead to invalid memory being addressed.  
  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> use the global variable <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> to access the environment table; <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> use <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> might change the value of <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, thus invalidating the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> argument to <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> and the _<CodeContentPlaceHolder>43\</CodeContentPlaceHolder> argument to <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>. Therefore, it is safer to use <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> to access the environment information. For more information about the relation of <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> to global variables, see [_environ, _wenviron](../vs140/_environ--_wenviron.md).  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> families of functions are not thread-safe. <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> could return a string pointer while <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> is modifying the string, causing random failures. Make sure that calls to these functions are synchronized.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>|\<stdlib.h>|  
|<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>|\<stdlib.h> or \<wchar.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
 For a sample of how to use <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>, see [getenv, _wgetenv](../vs140/getenv--_wgetenv.md).  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Process and Environment Control](../vs140/process-and-environment-control.md)   
 [getenv, _wgetenv](../vs140/getenv--_wgetenv.md)   
 [_searchenv, _wsearchenv](../vs140/_searchenv--_wsearchenv.md)