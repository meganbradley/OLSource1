---
title: "_fullpath_dbg, _wfullpath_dbg"
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
  - "_wfullpath_dbg"
  - "_fullpath_dbg"
apilocation: 
  - "msvcr80.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
  - "msvcr100.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
  - "msvcrt.dll"
apitype: "DLLExport"
f1_keywords: 
  - "wfullpath_dbg"
  - "_wfullpath_dbg"
  - "_fullpath_dbg"
  - "fullpath_dbg"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_fullpath_dbg function"
  - "relative file paths"
  - "absolute paths"
  - "fullpath_dbg function"
  - "_wfullpath_dbg function"
  - "wfullpath_dbg function"
ms.assetid: 81f72f85-07da-4f5c-866a-598e0fb03f6b
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _fullpath_dbg, _wfullpath_dbg
Versions of [_fullpath, _wfullpath](../vs140/_fullpath--_wfullpath.md) that use the debug version of `malloc` to allocate memory.  
  
## Syntax  
  
```  
char *_fullpath_dbg(   
   char *absPath,  
   const char *relPath,  
   size_t maxLength,  
   int blockType,  
   const char *filename,  
   int linenumber   
);  
wchar_t *_wfullpath_dbg(   
   wchar_t *absPath,  
   const wchar_t *relPath,  
   size_t maxLength,  
   int blockType,  
   const char *filename,  
   int linenumber   
);  
```  
  
#### Parameters  
 `absPath`  
 Pointer to a buffer containing the absolute or full path name, or `NULL`.  
  
 `relPath`  
 Relative path name.  
  
 `maxLength`  
 Maximum length of the absolute path name buffer (`absPath`). This length is in bytes for `_fullpath` but in wide characters (`wchar_t`) for `_wfullpath`.  
  
 `blockType`  
 Requested type of memory block: `_CLIENT_BLOCK` or `_NORMAL_BLOCK`.  
  
 `filename`  
 Pointer to the name of the source file that requested allocation operation or `NULL`.  
  
 `linenumber`  
 Line number in the source file where the allocation operation was requested or `NULL`.  
  
## Return Value  
 Each function returns a pointer to a buffer containing the absolute path name (`absPath`). If there is an error (for example, if the value passed in `relPath` includes a drive letter that is not valid or cannot be found, or if the length of the created absolute path name (`absPath`) is greater than `maxLength`) the function returns `NULL`.  
  
## Remarks  
 The `_fullpath_dbg` and `_wfullpath_dbg` functions are identical to `_fullpath` and `_wfullpath` except that, when **_**`DEBUG`is defined, these functions use the debug version of `malloc`, `_malloc_dbg`, to allocate memory if NULL is passed as the first parameter. For information on the debugging features of `_malloc_dbg`, see [_malloc_dbg](../vs140/_malloc_dbg.md).  
  
 You do not need to call these functions explicitly in most cases. Instead, you can define the `_CRTDBG_MAP_ALLOC` flag. When `_CRTDBG_MAP_ALLOC`is defined, calls to `_fullpath` and `_wfullpath`are remapped to `_fullpath_dbg` and `_wfullpath_dbg`, respectively, with the `blockType` set to `_NORMAL_BLOCK`. Thus, you do not need to call these functions explicitly unless you want to mark the heap blocks as `_CLIENT_BLOCK`. For more information, see [Types of Blocks on the Debug Heap](../vs140/crt-debug-heap-details.md#BKMK_Types_of_blocks_on_the_debug_heap).  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|`_tfullpath_dbg`|`_fullpath_dbg`|`_fullpath_dbg`|`_wfullpath_dbg`|  
  
## Requirements  
  
|Function|Required header|  
|--------------|---------------------|  
|`_fullpath_dbg`|<crtdbg.h>|  
|`_wfullpath_dbg`|<crtdbg.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## .NET Framework Equivalent  
 <xref:System.IO.File.Create*>  
  
## See Also  
 [File Handling](../vs140/file-handling.md)   
 [_fullpath, _wfullpath](../vs140/_fullpath--_wfullpath.md)   
 [Debug Versions of Heap Allocation Functions](../vs140/debug-versions-of-heap-allocation-functions.md)