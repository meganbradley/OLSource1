---
title: "_RTC_SetErrorFunc"
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
  - "_RTC_SetErrorFunc"
apilocation: 
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
  - "msvcr100.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
apitype: "DLLExport"
f1_keywords: 
  - "RTC_SetErrorFunc"
  - "_RTC_SetErrorFunc"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "RTC_SetErrorFunc function"
  - "_RTC_SetErrorFunc function"
ms.assetid: b2292722-0d83-4092-83df-3d5b19880666
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# _RTC_SetErrorFunc
Designates a function as the handler for reporting run-time error checks (RTCs). This function is deprecated; use `_RTC_SetErrorFuncW` instead.  
  
## Syntax  
  
```  
  
      _RTC_error_fn _RTC_SetErrorFunc(  
   _RTC_error_fn function   
);  
```  
  
#### Parameters  
 *function*  
 The address of the function that will handle run-time error checks.  
  
## Return Value  
 The previously defined error function. If there is no previously defined function, returns NULL.  
  
## Remarks  
 Do not use this function; instead, use `_RTC_SetErrorFuncW`. It is retained only for backward compatibility.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`_RTC_SetErrorFunc`|<rtcapi.h>|  
  
 For more information, see [Compatibility](../vs140/compatibility.md).  
  
## Libraries  
 All versions of the [C run-time libraries](../vs140/crt-library-features.md).  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [_CrtDbgReport, _CrtDbgReportW](../vs140/_crtdbgreport--_crtdbgreportw.md)   
 [Run-Time Error Checking](../vs140/run-time-error-checking.md)