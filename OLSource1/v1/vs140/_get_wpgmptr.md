---
title: "_get_wpgmptr"
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
  - "_get_wpgmptr"
apilocation: 
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "get_wpgmptr"
  - "_get_wpgmptr"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_wpgmptr global variable"
  - "get_wpgmptr function"
  - "wpgmptr global variable"
  - "_get_wpgmptr function"
ms.assetid: a77cdd13-2303-4b7c-9a60-8debdbef2011
caps.latest.revision: 21
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _get_wpgmptr
Gets the current value of the `_wpgmptr` global variable.  
  
## Syntax  
  
```  
errno_t _get_wpgmptr(   
   wchar_t **pValue   
);  
```  
  
#### Parameters  
 [out] `pValue`  
 A pointer to a string to be filled with the current value of the `_wpgmptr` variable.  
  
## Return Value  
 Returns zero if successful; an error code on failure. If `pValue` is `NULL`, the invalid parameter handler is invoked as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, this function sets `errno` to `EINVAL` and returns `EINVAL`.  
  
## Remarks  
 The `_wpgmptr` global variable contains the full path to the executable associated with the process as a wide-character string. For more information, see [_pgmptr, _wpgmptr](../vs140/_pgmptr--_wpgmptr.md).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`_get_wpgmptr`|<stdlib.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [_get_pgmptr](../vs140/_get_pgmptr.md)