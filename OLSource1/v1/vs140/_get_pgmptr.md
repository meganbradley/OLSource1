---
title: "_get_pgmptr"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
apiname: 
  - _get_pgmptr
apilocation: 
  - msvcr120.dll
  - msvcr80.dll
  - msvcr110.dll
  - msvcr100.dll
  - msvcrt.dll
  - msvcr110_clr0400.dll
  - msvcr90.dll
apitype: DLLExport
f1_keywords: 
  - get_pgmptr
  - _get_pgmptr
dev_langs: 
  - C++
  - C
helpviewer_keywords: 
  - get_pgmptr function
  - _get_pgmptr function
  - pgmptr global variable
  - _pgmptr global variable
ms.assetid: 29f16a9f-a685-4721-add3-7fad4f67eece
caps.latest.revision: 19
translation.priority.ht: 
  - de-de
  - ja-jp
---
# _get_pgmptr
Gets the current value of the `_pgmptr`global variable.  
  
## Syntax  
  
```  
errno_t _get_pgmptr(   
   char **pValue   
);  
```  
  
#### Parameters  
 [out] `pValue`  
 A pointer to a string to be filled with the current value of the `_pgmptr` variable.  
  
## Return Value  
 Returns zero if successful; an error code on failure. If `pValue` is `NULL`, the invalid parameter handler is invoked as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, this function sets `errno` to `EINVAL` and returns `EINVAL`.  
  
## Remarks  
 The `_pgmptr`global variable contains the full path to the executable associated with the process. For more information, see [_pgmptr, _wpgmptr](../vs140/_pgmptr--_wpgmptr.md).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`_get_pgmptr`|<stdlib.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## NET Framework Equivalent  
 Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [_get_wpgmptr](../vs140/_get_wpgmptr.md)