---
title: "_findclose"
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
  - "_findclose"
apilocation: 
  - "msvcr100.dll"
  - "msvcr80.dll"
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr110.dll"
  - "msvcr90.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_findclose"
  - "findclose"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_findclose function"
  - "findclose function"
ms.assetid: 9216c573-0878-444c-b5d7-cdaf16fb9163
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _findclose
Closes the specified search handle and releases associated resources.  
  
## Syntax  
  
```  
int _findclose(   
   intptr_t handle   
);  
```  
  
#### Parameters  
 `handle`  
 Search handle returned by a previous call to `_findfirst`.  
  
## Return Value  
 If successful, `_findclose` returns 0. Otherwise, it returns –1 and sets `errno` to `ENOENT`, indicating that no more matching files could be found.  
  
## Requirements  
  
|Function|Required header|  
|--------------|---------------------|  
|`_findclose`|<io.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [System Calls](../vs140/system-calls.md)   
 [Filename Search Functions](../vs140/filename-search-functions.md)