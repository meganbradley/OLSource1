---
title: "_putenv_s, _wputenv_s"
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
  - "_wputenv_s"
  - "_putenv_s"
apilocation: 
  - "msvcrt.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
  - "msvcr110.dll"
  - "msvcr80.dll"
  - "msvcr100.dll"
  - "msvcr90.dll"
apitype: "DLLExport"
f1_keywords: 
  - "putenv_s"
  - "wputenv_s"
  - "_wputenv_s"
  - "_putenv_s"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "wputenv_s function"
  - "_putenv_s function"
  - "environment variables, deleting"
  - "putenv_s function"
  - "_wputenv_s function"
  - "environment variables, creating"
  - "environment variables, modifying"
ms.assetid: fbf51225-a8da-4b9b-9d7c-0b84ef72df18
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _putenv_s, _wputenv_s
Creates, modifies, or removes environment variables. These are versions of [_putenv, _wputenv](../vs140/_putenv--_wputenv.md) but have security enhancements, as described in [Security Enhancements in the CRT](../vs140/security-features-in-the-crt.md).  
  
> [!IMPORTANT]
>  This API cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)]. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/en-us/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The environment variable name.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The value to set the environment variable to.  
  
## Return Value  
 Returns 0 if successful, or an error code.  
  
### Error Conditions  
  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Return value|  
|------------|-------------|------------------|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|any|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|  
|any|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|  
  
 If one of the error conditions occurs, these functions invoke an invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, these functions return <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and set <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
## Remarks  
 The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> function adds new environment variables or modifies the values of existing environment variables. Environment variables define the environment in which a process executes (for example, the default search path for libraries to be linked with a program). <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is a wide-character version of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>; the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> argument to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is a wide-character string.  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is the name of the environment variable to be added or modified and <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is the variable's value. If <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> is already part of the environment, its value is replaced by <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>; otherwise, the new <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> variable and its <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> are added to the environment. You can remove a variable from the environment by specifying an empty string (that is, "") for <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> affect only the environment that is local to the current process; you cannot use them to modify the command-level environment. These functions operate only on data structures that are accessible to the run-time library and not on the environment "segment" that the operating system creates for a process. When the current process terminates, the environment reverts to the level of the calling process, which in most cases is the operating-system level. However, the modified environment can be passed to any new processes that are created by <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, and these new processes get any new items that are added by <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>.  
  
 Do not change an environment entry directly; instead, use <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> to change it. In particular, directly freeing elements of the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> global array might cause invalid memory to be addressed.  
  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> use the global variable <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> to access the environment table; <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> use <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> may change the value of <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>, and thereby invalidate the <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> argument to <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> and the <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> argument to <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>. Therefore, it is safer to use <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> to access the environment information. For more information about the relationship of <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> to global variables, see [_environ, _wenviron](../vs140/_environ--_wenviron.md).  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> families of functions are not thread-safe. <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> could return a string pointer while <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> is modifying the string, and thereby cause random failures. Make sure that calls to these functions are synchronized.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>|\<stdlib.h>|  
|<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>|\<stdlib.h> or \<wchar.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
 For a sample that shows how to use <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>, see [getenv_s, _wgetenv_s](../vs140/getenv_s--_wgetenv_s.md).  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Process and Environment Control](../vs140/process-and-environment-control.md)   
 [getenv, _wgetenv](../vs140/getenv--_wgetenv.md)   
 [_searchenv, _wsearchenv](../vs140/_searchenv--_wsearchenv.md)