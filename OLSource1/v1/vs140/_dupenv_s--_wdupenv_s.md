---
title: "_dupenv_s, _wdupenv_s"
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
  - "_dupenv_s"
  - "_wdupenv_s"
apilocation: 
  - "msvcr90.dll"
  - "msvcr80.dll"
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr110.dll"
  - "msvcr120.dll"
  - "msvcrt.dll"
apitype: "DLLExport"
f1_keywords: 
  - "tdupenv_s"
  - "_dupenv_s"
  - "wdupenv_s"
  - "dupenv_s"
  - "_tdupenv_s"
  - "_wdupenv_s"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_dupenv_s function"
  - "_tdupenv_s function"
  - "_wdupenv_s function"
  - "environment variables"
  - "wdupenv_s function"
  - "dupenv_s function"
  - "tdupenv_s function"
ms.assetid: b729ecc2-a31d-4ccf-92a7-5accedb8f8c8
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _dupenv_s, _wdupenv_s
Gets a value from the current environment.  
  
> [!IMPORTANT]
>  This API cannot be used in applications that execute in the Windows Runtime. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Buffer to store the variable's value.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Size of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Environment variable name.  
  
## Return Value  
 Zero on success, an error code on failure.  
  
 These functions validate their parameters; if <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, the invalid parameter handler is invoked as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, the functions set <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and return <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
 If these functions cannot allocate enough memory, they set <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> to 0, and return <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
## Remarks  
 The <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> function searches the list of environment variables for <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>. If the variable is found, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> allocates a buffer and copies the variable's value into the buffer. The buffer's address and length are returned in <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>. By allocating the buffer itself, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> provides a more convenient alternative to [getenv_s, _wgetenv_s](../vs140/getenv_s--_wgetenv_s.md).  
  
> [!NOTE]
>  It is the calling program's responsibility to free the memory by calling [free](../vs140/free.md).  
  
 If the variable is not found, then <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> is set to 0, and the return value is 0 because this situation is not considered to be an error condition.  
  
 If you are not interested in the size of the buffer you can pass <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> for <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is not case sensitive in the Windows operating system. <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> uses the copy of the environment pointed to by the global variable <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> to access the environment. See the Remarks in [getenv_s, _wgetenv_s](../vs140/getenv_s--_wgetenv_s.md) for a discussion of <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>.  
  
 The value in <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> is a copy of the environment variable's value; modifying it has no effect on the environment. Use the [putenv_s](../vs140/_putenv_s--_wputenv_s.md) function to modify the value of an environment variable.  
  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> is a wide-character version of <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>; the arguments of <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> are wide-character strings. The <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> global variable is a wide-character version of <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>. See the Remarks in [getenv_s, _wgetenv_s](../vs140/getenv_s--_wgetenv_s.md) for more on <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>.  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|\<stdlib.h>|  
|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|\<stdlib.h> or \<wchar.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Sample Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## .NET Framework Equivalent  
 [System::Environment::GetEnvironmentVariable](https://msdn.microsoft.com/en-us/library/system.environment.getenvironmentvariable.aspx)  
  
## See Also  
 [Process and Environment Control](../vs140/process-and-environment-control.md)   
 [Environmental Constants](../vs140/environmental-constants.md)   
 [_dupenv_s_dbg, _wdupenv_s_dbg](../vs140/_dupenv_s_dbg--_wdupenv_s_dbg.md)   
 [getenv_s, _wgetenv_s](../vs140/getenv_s--_wgetenv_s.md)   
 [putenv_s, _wputenv_s](../vs140/_putenv_s--_wputenv_s.md)