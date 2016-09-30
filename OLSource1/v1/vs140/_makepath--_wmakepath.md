---
title: "_makepath, _wmakepath"
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
  - "_makepath"
  - "_wmakepath"
apilocation: 
  - "msvcr90.dll"
  - "msvcr120.dll"
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr110.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_wmakepath"
  - "_tmakepath"
  - "makepath"
  - "tmakepath"
  - "wmakepath"
  - "_makepath"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_makepath function"
  - "wmakepath function"
  - "makepath function"
  - "_tmakepath function"
  - "paths"
  - "_wmakepath function"
  - "tmakepath function"
ms.assetid: 5930b197-a7b8-46eb-8519-2841a58cd026
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _makepath, _wmakepath
Create a path name from components. More secure versions of these functions are available; see [_makepath_s, _wmakepath_s](../vs140/_makepath_s--_wmakepath_s.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Full path buffer.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Contains a letter (A, B, and so on) corresponding to the desired drive and an optional trailing colon. <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> inserts the colon automatically in the composite path if it is missing. If <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> or points to an empty string, no drive letter appears in the composite <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> string.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Contains the path of directories, not including the drive designator or the actual file name. The trailing slash is optional, and either a forward slash (/) or a backslash (\\) or both might be used in a single <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> argument. If no trailing slash (/ or \\) is specified, it is inserted automatically. If <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> or points to an empty string, no directory path is inserted in the composite <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> string.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 Contains the base file name without any file name extensions. If <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> or points to an empty string, no filename is inserted in the composite <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> string.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 Contains the actual file name extension, with or without a leading period (.). <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> inserts the period automatically if it does not appear in <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> or points to an empty string, no extension is inserted in the composite <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> string.  
  
## Remarks  
 The <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> function creates a composite path string from individual components, storing the result in <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> might include a drive letter, directory path, filename, and filename extension. <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> is a wide-character version of <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>; the arguments to <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> are wide-character strings. <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> behave identically otherwise.  
  
 **Security Note** Use a null-terminated string. To avoid buffer overrun, the null-terminated string must not exceed the size of the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> buffer. <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> does not ensure that the length of the composite path string does not exceed <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>. For more information, see [Avoiding Buffer Overruns](http://msdn.microsoft.com/library/windows/desktop/ms717795).  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|  
  
 The <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> argument must point to an empty buffer large enough to hold the complete path. The composite <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> must be no larger than the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> constant, defined in Stdlib.h.  
  
 If path is <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). In addition, <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> values are allowed for all other parameters.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|\<stdlib.h>|  
|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|\<stdlib.h> or \<wchar.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Path created with _makepath: c:\sample\crt\makepath.c**  
**Path extracted with _splitpath:**  
 **Drive: c:**  
 **Dir: \sample\crt\\**  
 **Filename: makepath**  
 **Ext: .c**   
## .NET Framework Equivalent  
 [System::IO::File::Create](https://msdn.microsoft.com/en-us/library/system.io.file.create.aspx)  
  
## See Also  
 [File Handling](../vs140/file-handling.md)   
 [_fullpath, _wfullpath](../vs140/_fullpath--_wfullpath.md)   
 [_splitpath, _wsplitpath](../vs140/_splitpath--_wsplitpath.md)   
 [_makepath_s, _wmakepath_s](../vs140/_makepath_s--_wmakepath_s.md)