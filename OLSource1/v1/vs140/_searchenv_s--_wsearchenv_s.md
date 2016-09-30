---
title: "_searchenv_s, _wsearchenv_s"
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
  - "_wsearchenv_s"
  - "_searchenv_s"
apilocation: 
  - "msvcr100.dll"
  - "msvcrt.dll"
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr110.dll"
  - "msvcr90.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_searchenv_s"
  - "_wsearchenv_s"
  - "wsearchenv_s"
  - "searchenv_s"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "tsearchenv_s function"
  - "files [C++], finding"
  - "buffers [C++], buffer overruns"
  - "environment paths, searching for files"
  - "wsearchenv_s function"
  - "searchenv_s function"
  - "_tsearchenv_s function"
  - "buffer overruns"
  - "buffers [C++], avoiding overruns"
  - "_wsearchenv_s function"
  - "_searchenv_s function"
  - "environment paths"
ms.assetid: 47f9fc29-250e-4c09-b52e-9e9f0ef395ca
caps.latest.revision: 34
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _searchenv_s, _wsearchenv_s
Searches for a file by using environment paths. These versions of [_searchenv, _wsearchenv](../vs140/_searchenv--_wsearchenv.md) have security enhancements, as described in [Security Enhancements in the CRT](../vs140/security-features-in-the-crt.md).  
  
> [!IMPORTANT]
>  This API cannot be used in applications that execute in the Windows Runtime. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Name of the file to search for.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Environment to search.  
  
 [out] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Buffer to store the complete path.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Size of the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>buffer.  
  
## Return Value  
 Zero if successful; an error code on failure.  
  
 If <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is an empty string, the return value is <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
### Error Conditions  
  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|Return value|Contents of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|  
|----------------|---------------|----------------|------------------------|------------------|----------------------------|  
|any|any|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|any|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|n/a|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|any|any|any|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|not changed|  
|any|any|any|<= 0|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|not changed|  
  
 If any of these error conditions occurs, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, these functions set <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> and return <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
## Remarks  
 The <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> routine searches for the target file in the specified domain. The <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> variable can be any environment or user-defined variable that specifies a list of directory paths, such as <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>. Because <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> is case-sensitive, <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> should match the case of the environment variable. If <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> does not match the name of an environment variable defined in the process's environment, the function returns zero and the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> variable is unchanged.  
  
 The routine searches first for the file in the current working directory. If it does not find the file, it looks next through the directories specified by the environment variable. If the target file is in one of those directories, the newly created path is copied into <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>. If the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> file is not found, <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> contains an empty null-terminated string.  
  
 The <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> buffer should be at least <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> characters long to accommodate the full length of the constructed path name. Otherwise, <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> might overrun the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> buffer resulting in unexpected behavior.  
  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> is a wide-character version of <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>; the arguments to <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> are wide-character strings. <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> behave identically otherwise.  
  
 In C++, using these functions is simplified by template overloads; the overloads can infer buffer length automatically (eliminating the need to specify a size argument) and they can automatically replace older, non-secure functions with their newer, secure counterparts. For more information, see [Secure Template Overloads](../vs140/secure-template-overloads.md).  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|\<stdlib.h>|  
|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>|\<stdlib.h> or \<wchar.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Path for CL.EXE:**  
**C:\Program Files\Microsoft Visual Studio 2010\VC\BIN\CL.EXE**   
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Directory Control](../vs140/directory-control.md)   
 [_searchenv, _wsearchenv](../vs140/_searchenv--_wsearchenv.md)   
 [getenv, _wgetenv](../vs140/getenv--_wgetenv.md)   
 [_putenv, _wputenv](../vs140/_putenv--_wputenv.md)