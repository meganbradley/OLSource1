---
title: "unexpected (CRT)"
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
  - "unexpected"
apilocation: 
  - "msvcr80.dll"
  - "msvcr120.dll"
  - "msvcr100.dll"
  - "msvcr110.dll"
  - "msvcr90.dll"
  - "msvcrt.dll"
  - "msvcr110_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "unexpected"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "unexpected function"
ms.assetid: 2f873763-15ad-4556-a924-dcf28f2b52b4
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unexpected (CRT)
Calls `terminate` or function you specify using `set_unexpected`.  
  
## Syntax  
  
```  
void unexpected( void );  
```  
  
## Remarks  
 The `unexpected` routine is not used with the current implementation of C++ exception handling. `unexpected` calls `terminate` by default. You can change this default behavior by writing a custom termination function and calling `set_unexpected` with the name of your function as its argument. `unexpected` calls the last function given as an argument to `set_unexpected`.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`unexpected`|<eh.h>|  
  
 For additional compatibility information, see [Compatibility](../VS_csharp/compatibility.md) in the Introduction.  
  
## .NET Framework Equivalent  
 [System::Exception Class](https://msdn.microsoft.com/en-us/library/system.exception.aspx)  
  
## See Also  
 [Exception Handling Routines](../VS_csharp/exception-handling-routines.md)   
 [abort](../VS_csharp/abort.md)   
 [_set_se_translator](../VS_csharp/_set_se_translator.md)   
 [set_terminate](../VS_csharp/set_terminate--crt-.md)   
 [set_unexpected](../VS_csharp/set_unexpected--crt-.md)   
 [terminate](../VS_csharp/terminate--crt-.md)