---
title: "_searchenv, _wsearchenv"
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
  - "_searchenv"
  - "_wsearchenv"
apilocation: 
  - "msvcr120.dll"
  - "msvcr80.dll"
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr90.dll"
  - "msvcrt.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_wsearchenv"
  - "_tsearchenv"
  - "wsearchenv"
  - "_searchenv"
  - "searchenv"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_wsearchenv function"
  - "files [C++], finding"
  - "_searchenv function"
  - "tsearchenv function"
  - "environment paths, searching for files"
  - "_tsearchenv function"
  - "wsearchenv function"
  - "searchenv function"
  - "environment paths"
ms.assetid: 9c944a27-d326-409b-aee6-410e8762d9d3
caps.latest.revision: 35
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _searchenv, _wsearchenv
Uses environment paths to search for a file. More secure versions of these functions are available; see [_searchenv_s, _wsearchenv_s](../vs140/_searchenv_s--_wsearchenv_s.md).  
  
> [!IMPORTANT]
>  This API cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)]. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Name of the file to search for.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Environment to search.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Buffer to store the complete path.  
  
## Remarks  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> routine searches for the target file in the specified domain. The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> variable can be any environment or user-defined variable—for example, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>—that specifies a list of directory paths. Because <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is case-sensitive, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> should match the case of the environment variable.  
  
 The routine first searches for the file in the current working directory. If it does not find the file, it looks through the directories that are specified by the environment variable. If the target file is in one of those directories, the newly created path is copied into <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. If the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> file is not found, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> contains an empty null-terminated string.  
  
 The <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> buffer should be at least <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> characters long to accommodate the full length of the constructed path name. Otherwise, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> might overrun the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> buffer and cause unexpected behavior.  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is a wide-character version of <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, and the arguments to <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> are wide-character strings. <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> behave identically otherwise.  
  
 If <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is an empty string, these functions return <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.  
  
 If <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> is a <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> pointer, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, these functions return -1 and set <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>.  
  
 For more information about <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> and error codes, see [errno Constants](../vs140/errno-constants.md).  
  
 In C++, these functions have template overloads that invoke the newer, more secure counterparts of these functions. For more information, see [Secure Template Overloads](../vs140/secure-template-overloads.md).  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|\<stdlib.h>|  
|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|\<stdlib.h> or \<wchar.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Path for CL.EXE:**  
**C:\Program Files\Microsoft Visual Studio 8\VC\BIN\CL.EXE**   
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Directory Control](../vs140/directory-control.md)   
 [getenv, _wgetenv](../vs140/getenv--_wgetenv.md)   
 [_putenv, _wputenv](../vs140/_putenv--_wputenv.md)   
 [_searchenv_s, _wsearchenv_s](../vs140/_searchenv_s--_wsearchenv_s.md)