---
title: "_splitpath, _wsplitpath"
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
  - "_wsplitpath"
  - "_splitpath"
apilocation: 
  - "msvcr120.dll"
  - "msvcrt.dll"
  - "msvcr90.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr100.dll"
  - "msvcr110.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "wsplitpath"
  - "_splitpath"
  - "splitpath"
  - "_wsplitpath"
  - "_tsplitpath"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_splitpath function"
  - "pathnames"
  - "wsplitpath function"
  - "splitpath function"
  - "_wsplitpath function"
  - "tsplitpath function"
  - "path names"
  - "_tsplitpath function"
ms.assetid: 32bd76b5-1385-4ee8-a64c-abcb541cd2e4
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _splitpath, _wsplitpath
Break a path name into components. More secure versions of these functions are available, see [_splitpath_s, _wsplitpath_s](../vs140/_splitpath_s--_wsplitpath_s.md).  
  
## Syntax  
  
```  
void _splitpath(  
   const char *path,  
   char *drive,  
   char *dir,  
   char *fname,  
   char *ext   
);  
void _wsplitpath(  
   const wchar_t *path,  
   wchar_t *drive,  
   wchar_t *dir,  
   wchar_t *fname,  
   wchar_t *ext   
);  
```  
  
#### Parameters  
 `path`  
 Full path.  
  
 `drive`  
 Drive letter, followed by a colon (`:`). You can pass `NULL` for this parameter if you do not need the drive letter.  
  
 `dir`  
 Directory path, including trailing slash. Forward slashes ( `/` ), backslashes ( `\` ), or both may be used. You can pass `NULL` for this parameter if you do not need the directory path.  
  
 `fname`  
 Base filename (no extension). You can pass `NULL` for this parameter if you do not need the filename.  
  
 `ext`  
 Filename extension, including leading period (`.`). You can pass `NULL` for this parameter if you do not need the filename extension.  
  
## Remarks  
 The `_splitpath` function breaks a path into its four components. `_splitpath` automatically handles multibyte-character string arguments as appropriate, recognizing multibyte-character sequences according to the multibyte code page currently in use. `_wsplitpath` is a wide-character version of `_splitpath`; the arguments to `_wsplitpath` are wide-character strings. These functions behave identically otherwise.  
  
 **Security Note** These functions incur a potential threat brought about by a buffer overrun problem. Buffer overrun problems are a frequent method of system attack, resulting in an unwarranted elevation of privilege. For more information, see [Avoiding Buffer Overruns](http://msdn.microsoft.com/library/windows/desktop/ms717795). More secure versions of these functions are available; see [_splitpath_s, _wsplitpath_s](../vs140/_splitpath_s--_wsplitpath_s.md).  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|`_tsplitpath`|`_splitpath`|`_splitpath`|`_wsplitpath`|  
  
 Each component of the full path is stored in a separate buffer; the manifest constants `_MAX_DRIVE`, `_MAX_DIR`, `_MAX_FNAME`, and `_MAX_EXT` (defined in STDLIB.H) specify the maximum size for each file component. File components that are larger than the corresponding manifest constants cause heap corruption.  
  
 Each buffer must be as large as its corresponding manifest constant to avoid potential buffer overrun.  
  
 The following table lists the values of the manifest constants.  
  
|Name|Value|  
|----------|-----------|  
|_MAX_DRIVE|3|  
|_MAX_DIR|256|  
|_MAX_FNAME|256|  
|_MAX_EXT|256|  
  
 If the full path does not contain a component (for example, a filename), `_splitpath` assigns empty strings to the corresponding buffers.  
  
 You can pass `NULL` to `_splitpath` for any parameter other than `path` that you do not need.  
  
 If `path` is `NULL`, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, `errno` is set to `EINVAL` and the function returns `EINVAL`.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`_splitpath`|\<stdlib.h>|  
|`_wsplitpath`|\<stdlib.h> or \<wchar.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
 See the example for [_makepath](../vs140/_makepath--_wmakepath.md).  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [File Handling](../vs140/file-handling.md)   
 [_fullpath, _wfullpath](../vs140/_fullpath--_wfullpath.md)   
 [_getmbcp](../vs140/_getmbcp.md)   
 [_makepath, _wmakepath](../vs140/_makepath--_wmakepath.md)   
 [_setmbcp](../vs140/_setmbcp.md)   
 [_splitpath_s, _wsplitpath_s](../vs140/_splitpath_s--_wsplitpath_s.md)