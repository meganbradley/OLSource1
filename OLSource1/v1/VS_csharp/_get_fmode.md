---
title: "_get_fmode"
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
  - "_get_fmode"
apilocation: 
  - "msvcr110.dll"
  - "msvcrt.dll"
  - "msvcr120.dll"
  - "msvcr80.dll"
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr90.dll"
apitype: "DLLExport"
f1_keywords: 
  - "get_fmode"
  - "_get_fmode"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_get_fmode function"
  - "file translation [C++], default mode"
  - "get_fmode function"
ms.assetid: 22ea70e2-b9b5-422d-b514-64f4beaea45c
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _get_fmode
Gets the default file translation mode for file I/O operations.  
  
## Syntax  
  
```  
errno_t _get_fmode(   
   int * pmode   
);  
```  
  
#### Parameters  
 [out] `pmode`  
 A pointer to an integer to be filled with the current default mode: `_O_TEXT` or `_O_BINARY`.  
  
## Return Value  
 Returns zero if successful; an error code on failure. If `pmode` is `NULL`, the invalid parameter handler is invoked as described in [Parameter Validation](../VS_csharp/parameter-validation.md). If execution is allowed to continue, `errno` is set to `EINVAL` and the function returns `EINVAL`.  
  
## Remarks  
 The function gets the value of the [_fmode](../VS_csharp/_fmode.md) global variable. This variable specifies the default file translation mode for both low-level and stream file I/O operations, such as `_open`, `_pipe`, `fopen`, and `freopen`.  
  
## Requirements  
  
|Routine|Required header|Optional header|  
|-------------|---------------------|---------------------|  
|`_get_fmode`|<stdlib.h>|<fcntl.h>|  
  
 For more compatibility information, see [Compatibility](../VS_csharp/compatibility.md) in the Introduction.  
  
## Example  
 See the example in [_set_fmode](../VS_csharp/_set_fmode.md).  
  
## NET Framework Equivalent  
 Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [_fmode](../VS_csharp/_fmode.md)   
 [_set_fmode](../VS_csharp/_set_fmode.md)   
 [_setmode](../VS_csharp/_setmode.md)   
 [Text and Binary Mode File I/O](../VS_csharp/text-and-binary-mode-file-i-o.md)