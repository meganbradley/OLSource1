---
title: "_tempnam_dbg, _wtempnam_dbg"
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
  - "_wtempnam_dbg"
  - "_tempnam_dbg"
apilocation: 
  - "msvcr110.dll"
  - "msvcr90.dll"
  - "msvcr120.dll"
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "wtempnam_dbg"
  - "tempnam_dbg"
  - "_tempnam_dbg"
  - "_wtempnam_dbg"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "file names [C++], creating temporary"
  - "tempnam_dbg function"
  - "temporary files, creating"
  - "file names [C++], temporary"
  - "wtempnam_dbg function"
  - "_tempnam_dbg function"
  - "_wtempnam_dbg function"
ms.assetid: e3760bb4-bb01-4808-b689-2c45af56a170
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _tempnam_dbg, _wtempnam_dbg
Function versions of [_tempnam, _wtempnam, tmpnam, _wtmpnam](../vs140/_tempnam--_wtempnam--tmpnam--_wtmpnam.md) that use the debug version of `malloc, _malloc_dbg`.  
  
## Syntax  
  
```  
char *_tempnam_dbg(  
   const char *dir,  
   const char *prefix,  
   int blockType,  
   const char *filename,  
   int linenumber   
);  
wchar_t *_wtempnam_dbg(  
   const wchar_t *dir,  
   const wchar_t *prefix,  
   int blockType,  
   const char *filename,  
   int linenumber   
);  
```  
  
#### Parameters  
 `dir`  
 The path used in the file name if there is no TMP environment variable, or if TMP is not a valid directory.  
  
 `prefix`  
 The string that will be pre-pended to names returned by `_tempnam`.  
  
 `blockType`  
 Requested type of memory block: `_CLIENT_BLOCK`or `_NORMAL_BLOCK`.  
  
 `filename`  
 Pointer to name of source file that requested allocation operation or `NULL`.  
  
 `linenumber`  
 Line number in source file where allocation operation was requested or `NULL`.  
  
## Return Value  
 Each function returns a pointer to the name generated or `NULL` if there is a failure. Failure can occur if there is an invalid directory name specified in the TMP environment variable and in the `dir` parameter.  
  
> [!NOTE]
>  `free` (or `free_dbg`) does need to be called for pointers allocated by `_tempnam_dbg` and `_wtempnam_dbg`.  
  
## Remarks  
 The `_tempnam_dbg`and `_wtempnam_dbg`functions are identical to `_tempnam`and `_wtempnam`except that, when `_DEBUG`is defined, these functions use the debug version of `malloc` and `_malloc_dbg`, to allocate memory if `NULL` is passed as the first parameter. For more information, see [_malloc_dbg](../vs140/_malloc_dbg.md).  
  
 You do not need to call these functions explicitly in most cases. Instead, you can define the flag `_CRTDBG_MAP_ALLOC`. When `_CRTDBG_MAP_ALLOC` is defined, calls to `_tempnam` and `_wtempnam` are remapped to `_tempnam_dbg` and `_wtempnam_dbg`, respectively, with the `blockType` set to `_NORMAL_BLOCK`. Thus, you do not need to call these functions explicitly unless you want to mark the heap blocks as `_CLIENT_BLOCK`. For more information, see [Types of Blocks on the Debug Heap](../vs140/crt-debug-heap-details.md#BKMK_Types_of_blocks_on_the_debug_heap).  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|`_ttempnam_dbg`|`_tempnam_dbg`|`_tempnam_dbg`|`_wtempnam_dbg`|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`_tempnam_dbg`, `_wtempnam_dbg`|<crtdbg.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [_tempnam, _wtempnam, tmpnam, _wtmpnam](../vs140/_tempnam--_wtempnam--tmpnam--_wtmpnam.md)   
 [Stream I/O](../vs140/stream-i-o.md)   
 [Debug Versions of Heap Allocation Functions](../vs140/debug-versions-of-heap-allocation-functions.md)