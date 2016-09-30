---
title: "getenv, _wgetenv"
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
  - "getenv"
  - "_wgetenv"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr110.dll"
  - "msvcr120.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_wgetenv"
  - "getenv"
  - "_tgetenv"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "getenv function"
  - "tgetenv function"
  - "wgetenv function"
  - "environment values"
  - "environment variables"
  - "_tgetenv function"
  - "_wgetenv function"
ms.assetid: 3b9cb9ab-a126-4e0e-a44f-6c5a7134daf4
caps.latest.revision: 33
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# getenv, _wgetenv
Gets a value from the current environment. More secure versions of these functions are available; see [getenv_s, _wgetenv_s](../vs140/getenv_s--_wgetenv_s.md).  
  
> [!IMPORTANT]
>  This API cannot be used in applications that execute in the Windows Runtime. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Environment variable name.  
  
## Return Value  
 Returns a pointer to the environment table entry containing <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. It is not safe to modify the value of the environment variable using the returned pointer. Use the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> function to modify the value of an environment variable. The return value is <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is not found in the environment table.  
  
## Remarks  
 The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> function searches the list of environment variables for <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is not case sensitive in the Windows operating system. <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> use the copy of the environment pointed to by the global variable <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> to access the environment. <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> operates only on the data structures accessible to the run-time library and not on the environment "segment" created for the process by the operating system. Therefore, programs that use the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> argument to [main](../vs140/main--program-startup.md) or [wmain](../vs140/main--program-startup.md) may retrieve invalid information.  
  
 If <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, this function invokes an invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, this function sets <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and returns <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is a wide-character version of <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>; the argument and return value of <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> are wide-character strings. The <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> global variable is a wide-character version of <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.  
  
 In an MBCS program (for example, in an SBCS ASCII program), <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> is initially <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> because the environment is composed of multibyte-character strings. Then, on the first call to <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, or on the first call to <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> if an (MBCS) environment already exists, a corresponding wide-character string environment is created and is then pointed to by <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>.  
  
 Similarly in a Unicode (<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>) program, <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> is initially <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> because the environment is composed of wide-character strings. Then, on the first call to <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, or on the first call to <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> if a (Unicode) environment already exists, a corresponding MBCS environment is created and is then pointed to by <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>.  
  
 When two copies of the environment (MBCS and Unicode) exist simultaneously in a program, the run-time system must maintain both copies, resulting in slower execution time. For example, whenever you call <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>, a call to <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> is also executed automatically, so that the two environment strings correspond.  
  
> [!CAUTION]
>  In rare instances, when the run-time system is maintaining both a Unicode version and a multibyte version of the environment, these two environment versions may not correspond exactly. This is because, although any unique multibyte-character string maps to a unique Unicode string, the mapping from a unique Unicode string to a multibyte-character string is not necessarily unique. For more information, see [_environ, _wenviron](../vs140/_environ--_wenviron.md).  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> families of functions are not thread-safe. <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> could return a string pointer while <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> is modifying the string, causing random failures. Make sure that calls to these functions are synchronized.  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|  
  
 To check or change the value of the <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> environment variable, use <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> as necessary. For more information about <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>, see [_tzset](../vs140/_tzset.md) and [_daylight, timezone, and _tzname](../vs140/_daylight--_dstbias--_timezone--and-_tzname.md).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>|\<stdlib.h>|  
|<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>|\<stdlib.h> or \<wchar.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Original LIB variable is: C:\progra~1\devstu~1\vc\lib**  
**New LIB variable is: c:\mylib;c:\yourlib**   
## .NET Framework Equivalent  
 [System::Environment::GetEnvironmentVariable](https://msdn.microsoft.com/en-us/library/system.environment.getenvironmentvariable.aspx)  
  
## See Also  
 [Process and Environment Control](../vs140/process-and-environment-control.md)   
 [_putenv, _wputenv](../vs140/_putenv--_wputenv.md)   
 [Environmental Constants](../vs140/environmental-constants.md)