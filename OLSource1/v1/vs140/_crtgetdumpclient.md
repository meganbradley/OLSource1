---
title: "_CrtGetDumpClient"
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
  - _CrtGetDumpClient
apilocation: 
  - msvcr80.dll
  - msvcr110.dll
  - msvcr90.dll
  - msvcrt.dll
  - msvcr110_clr0400.dll
  - msvcr120.dll
  - msvcr100.dll
apitype: DLLExport
f1_keywords: 
  - CrtGetDumpClient
  - _CrtGetDumpClient
dev_langs: 
  - C++
  - C
helpviewer_keywords: 
  - _CrtGetDumpClient function
  - CrtGetDumpClient function
ms.assetid: 9051867f-341b-493b-b53d-45d2b454a3ad
caps.latest.revision: 17
translation.priority.ht: 
  - de-de
  - ja-jp
---
# _CrtGetDumpClient
Retrieves the current application-defined function for dumping the `_CLIENT_BLOCK` type memory blocks (debug version only).  
  
## Syntax  
  
```  
_CRT_DUMP_CLIENT _CrtGetDumpClient( void );  
```  
  
## Return Value  
 Returns the current dump routine.  
  
## Remarks  
 The `_CrtGetDumpClient` function retrieves the current hook function for dumping objects stored in the `_CLIENT_BLOCK` memory blocks for the C run-time debug memory dump process.  
  
 For more information about using other hook-capable run-time functions and writing your own client-defined hook functions, see [Debug Hook Function Writing](../vs140/debug-hook-function-writing.md).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`_CrtGetDumpClient`|<crtdbg.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Libraries  
 Debug versions of [C run-time libraries](../vs140/crt-library-features.md) only.  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Debug Routines](../vs140/debug-routines.md)   
 [_CrtReportBlockType](../vs140/_crtreportblocktype.md)   
 [_CrtSetDumpClient](../vs140/_crtsetdumpclient.md)