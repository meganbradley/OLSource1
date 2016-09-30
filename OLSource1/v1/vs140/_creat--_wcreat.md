---
title: "_creat, _wcreat"
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
  - "_creat"
  - "_wcreat"
apilocation: 
  - "msvcr110.dll"
  - "msvcr100.dll"
  - "msvcr90.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
  - "msvcr80.dll"
  - "msvcrt.dll"
apitype: "DLLExport"
f1_keywords: 
  - "wcreat"
  - "_wcreat"
  - "_creat"
  - "tcreat"
  - "_tcreat"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "wcreat function"
  - "_wcreat function"
  - "files [C++], creating"
  - "_creat function"
  - "tcreat function"
  - "creat function"
  - "_tcreat function"
ms.assetid: 3b3b795d-1620-40ec-bd2b-a4bbb0d20fe5
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _creat, _wcreat
Creates a new file. <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> have been deprecated; use [_sopen_s, _wsopen_s](../vs140/_sopen_s--_wsopen_s.md) instead.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Name of new file.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Permission setting.  
  
## Return Value  
 These functions, if successful, return a file descriptor to the created file. Otherwise, the functions return –1 and set <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> as shown in the following table.  
  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder> setting|Description|  
|---------------------|-----------------|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder> specifies an existing read-only file or specifies a directory instead of a file.|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|No more file descriptors are available.|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Specified file could not be found.|  
  
 If <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is NULL, these functions invoke the invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, these functions set <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and return -1.  
  
 For more information about these and other return codes, see [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md).  
  
## Remarks  
 The <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> function creates a new file or opens and truncates an existing one. <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is a wide-character version of <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>; the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> argument to <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is a wide-character string. <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> behave identically otherwise.  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|  
  
 If the file specified by <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> does not exist, a new file is created with the given permission setting and is opened for writing. If the file already exists and its permission setting allows writing, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> truncates the file to length 0, destroying the previous contents, and opens it for writing. The permission setting, <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, applies to newly created files only. The new file receives the specified permission setting after it is closed for the first time. The integer expression <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> contains one or both of the manifest constants <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, defined in SYS\Stat.h. When both constants are given, they are joined with the bitwise <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> operator ( **&#124;** ). The <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> parameter is set to one of the following values.  
  
|Value|Definition|  
|-----------|----------------|  
|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|Writing permitted.|  
|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|Reading permitted.|  
|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|Reading and writing permitted.|  
  
 If write permission is not given, the file is read-only. All files are always readable; it is impossible to give write-only permission. The modes <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> are then equivalent. Files opened using <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> are always opened in compatibility mode (see [_sopen](../vs140/_sopen--_wsopen.md)) with <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> applies the current file-permission mask to <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> before setting the permissions (see [_umask](../vs140/_umask.md)). <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> is provided primarily for compatibility with previous libraries. A call to <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> with <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> in the <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> parameter is equivalent to <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> and is preferable for new code.  
  
## Requirements  
  
|Routine|Required header|Optional header|  
|-------------|---------------------|---------------------|  
|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|\<io.h>|\<sys/types.h>, \<sys/stat.h>, \<errno.h>|  
|<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>|\<io.h> or \<wchar.h>|\<sys/types.h>, \<sys/stat.h>, \<errno.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Created data file.**   
## See Also  
 [Low-Level I/O](../vs140/low-level-i-o.md)   
 [_chmod, _wchmod](../vs140/_chmod--_wchmod.md)   
 [_chsize](../vs140/_chsize.md)   
 [_close](../vs140/_close.md)   
 [_dup, _dup2](../vs140/_dup--_dup2.md)   
 [_open, _wopen](../vs140/_open--_wopen.md)   
 [_sopen, _wsopen](../vs140/_sopen--_wsopen.md)   
 [_umask](../vs140/_umask.md)