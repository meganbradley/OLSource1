---
title: "_fullpath, _wfullpath"
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
  - "_fullpath"
  - "_wfullpath"
apilocation: 
  - "msvcr120.dll"
  - "msvcrt.dll"
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr80.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
apitype: "DLLExport"
f1_keywords: 
  - "wfullpath"
  - "fullpath"
  - "_wfullpath"
  - "_fullpath"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_wfullpath function"
  - "relative file paths"
  - "absolute paths"
  - "wfullpath function"
  - "_fullpath function"
  - "fullpath function"
ms.assetid: 4161ec17-0d22-45dd-b07d-0222553afae9
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _fullpath, _wfullpath
Creates an absolute or full path name for the specified relative path name.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Pointer to a buffer containing the absolute or full path name, or NULL.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Relative path name.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Maximum length of the absolute path name buffer (<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>). This length is in bytes for <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> but in wide characters (<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>) for <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
## Return Value  
 Each of these functions returns a pointer to a buffer containing the absolute path name (<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>). If there is an error (for example, if the value passed in <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> includes a drive letter that is not valid or cannot be found, or if the length of the created absolute path name (<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>) is greater than <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>), the function returns <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
## Remarks  
 The <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> function expands the relative path name in <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> to its fully qualified or absolute path and stores this name in <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>*.* If <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is NULL, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is used to allocate a buffer of sufficient length to hold the path name. It is the responsibility of the caller to free this buffer. A relative path name specifies a path to another location from the current location (such as the current working directory: "."). An absolute path name is the expansion of a relative path name that states the entire path required to reach the desired location from the root of the file system. Unlike <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> can be used to obtain the absolute path name for relative paths (<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>) that include "./" or "../" in their names.  
  
 For example, to use C run-time routines, the application must include the header files that contain the declarations for the routines. Each header file include statement references the location of the file in a relative manner (from the application's working directory):  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 when the absolute path (actual file system location) of the file might be:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> automatically handles multibyte-character string arguments as appropriate, recognizing multibyte-character sequences according to the multibyte code page currently in use. <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> is a wide-character version of <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>; the string arguments to <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> are wide-character strings. <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> behave identically except that <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> does not handle multibyte-character strings.  
  
 If <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> are both defined, calls to <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> are replaced by calls to <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> to allow for debugging memory allocations. For more information, see [_fullpath_dbg, _wfullpath_dbg](../vs140/_fullpath_dbg--_wfullpath_dbg.md).  
  
 This function invokes the invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md), if <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> is less than or equal to 0. If execution is allowed to continue, this function sets <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> and returns <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>.  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|  
  
 If the <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> buffer is <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> calls [malloc](../vs140/malloc.md) to allocate a buffer and ignores the <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> argument. It is the caller's responsibility to deallocate this buffer (using [free](../vs140/free.md)) as appropriate. If the <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> argument specifies a disk drive, the current directory of this drive is combined with the path.  
  
## Requirements  
  
|Function|Required header|  
|--------------|---------------------|  
|<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>|\<stdlib.h>|  
|<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>|\<stdlib.h> or \<wchar.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 **Full path is: C:\Documents and Settings\user\My Documents\test**  
**Full path is: C:\test**  
**Full path is: C:\Documents and Settings\user\test**   
## .NET Framework Equivalent  
 [System::IO::File::Create](https://msdn.microsoft.com/en-us/library/system.io.file.create.aspx)  
  
## See Also  
 [File Handling](../vs140/file-handling.md)   
 [_getcwd, _wgetcwd](../vs140/_getcwd--_wgetcwd.md)   
 [_getdcwd, _wgetdcwd](../vs140/_getdcwd--_wgetdcwd.md)   
 [_makepath, _wmakepath](../vs140/_makepath--_wmakepath.md)   
 [_splitpath, _wsplitpath](../vs140/_splitpath--_wsplitpath.md)