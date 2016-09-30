---
title: "getenv_s, _wgetenv_s"
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
  - "getenv_s"
  - "_wgetenv_s"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcr100.dll"
  - "msvcr120.dll"
  - "msvcr80.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
  - "msvcrt.dll"
apitype: "DLLExport"
f1_keywords: 
  - "getenv_s"
  - "_tgetenv_s"
  - "_wgetenv_s"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_tgetenv_s function"
  - "wgetenv_s function"
  - "_wgetenv_s function"
  - "getenv_s function"
  - "environment variables"
  - "tgetenv_s function"
ms.assetid: c3ae1ffe-d4cd-4bae-bcb1-3afa754c613a
caps.latest.revision: 44
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# getenv_s, _wgetenv_s
Gets a value from the current environment. These versions of [getenv, _wgetenv](../vs140/getenv--_wgetenv.md) have security enhancements, as described in [Security Enhancements in the CRT](../vs140/security-features-in-the-crt.md).  
  
> [!IMPORTANT]
>  This API cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)]. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The buffer size that's required, or 0 if the variable is not found.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Buffer to store the value of the environment variable.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Size of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Environment variable name.  
  
## Return Value  
 Zero if successful; otherwise, an error code on failure.  
  
### Error Conditions  
  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|Return Value|  
|--------------------|--------------|------------------------|---------------|------------------|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|any|any|any|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|  
|any|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|>0|any|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|  
|any|any|any|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|  
  
 Any of these error conditions invokes an invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, the functions set <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and return <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
 Also, if the buffer is too small, these functions return <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>. They do not invoke an invalid parameter handler. They write out the required buffer size in <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, and thereby enable programs to call the function again with a larger buffer.  
  
## Remarks  
 The <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> function searches the list of environment variables for <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is not case sensitive in the Windows operating system. <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> use the copy of the environment that's pointed to by the global variable <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> to access the environment. <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> operates only on the data structures that are accessible to the run-time library and not on the environment "segment" that's created for the process by the operating system. Therefore, programs that use the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> argument to [main](../vs140/main--program-startup.md) or [wmain](../vs140/main--program-startup.md) might retrieve invalid information.  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> is a wide-character version of <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>; the argument and return value of <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> are wide-character strings. The <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> global variable is a wide-character version of <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>.  
  
 In an MBCS program (for example, in an SBCS ASCII program), <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> is initially <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> because the environment is composed of multibyte-character strings. Then, on the first call to <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>, or on the first call to <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>, if an (MBCS) environment already exists, a corresponding wide-character string environment is created and is then pointed to by <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>.  
  
 Similarly in a Unicode <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>) program, <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> is initially <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> because the environment is composed of wide-character strings. Then, on the first call to <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>, or on the first call to <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> if a (Unicode) environment already exists, a corresponding MBCS environment is created and is then pointed to by <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>.  
  
 When two copies of the environment (MBCS and Unicode) exist simultaneously in a program, the run-time system must maintain both copies, and this causes slower execution time. For example, when you call <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>, a call to <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> is also executed automatically so that the two environment strings correspond.  
  
> [!CAUTION]
>  In rare instances, when the run-time system is maintaining both a Unicode version and a multibyte version of the environment, the two environment versions may not correspond exactly. This happens because, although any unique multibyte-character string maps to a unique Unicode string, the mapping from a unique Unicode string to a multibyte-character string is not necessarily unique. For more information, see [_environ, _wenviron](../vs140/_environ--_wenviron.md).  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> families of functions are not thread-safe. <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> could return a string pointer while <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> is modifying the string and thereby cause random failures. Make sure that calls to these functions are synchronized.  
  
 In C++, use of these functions is simplified by template overloads; the overloads can infer buffer length automatically and thereby eliminate the need to specify a size argument. For more information, see [Secure Template Overloads](../vs140/secure-template-overloads.md).  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>|  
  
 To check or change the value of the <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> environment variable, use <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>, as required. For more information about <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>, see [_tzset](../vs140/_tzset.md) and [_daylight, _dstbias, _timezone, and _tzname](../vs140/_daylight--_dstbias--_timezone--and-_tzname.md).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>|\<stdlib.h>|  
|<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>|\<stdlib.h> or \<wchar.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Original LIB variable is: c:\vctools\lib;c:\vctools\atlmfc\lib;c:\vctools\PlatformSDK\lib;c:\vctools\Visual Studio SDKs\DIA Sdk\lib;c:\vctools\Visual Studio SDKs\BSC Sdk\lib**  
**New LIB variable is: c:\mylib;c:\yourlib**   
## .NET Framework Equivalent  
 [System::Environment::GetEnvironmentVariable](https://msdn.microsoft.com/en-us/library/system.environment.getenvironmentvariable.aspx)  
  
## See Also  
 [Process and Environment Control](../vs140/process-and-environment-control.md)   
 [Environmental Constants](../vs140/environmental-constants.md)   
 [_putenv, _wputenv](../vs140/_putenv--_wputenv.md)   
 [_dupenv_s, _wdupenv_s](../vs140/_dupenv_s--_wdupenv_s.md)