---
title: "_RTC_NumErrors"
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
  - "_RTC_NumErrors"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr110.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
  - "msvcr80.dll"
  - "msvcr120.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_RTC_NumErrors"
  - "RTC_NumErrors"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "run-time errors"
  - "_RTC_NumErrors function"
  - "RTC_NumErrors function"
ms.assetid: 7e82adae-38e2-4f8b-bc0b-37bda8109fd1
caps.latest.revision: 16
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# _RTC_NumErrors
Returns the total number of errors that can be detected by run-time error checks (RTC). You can use this number as the control in a **for** loop, where each value in the loop is passed to [_RTC_GetErrDesc](../vs140/_rtc_geterrdesc.md).  
  
## Syntax  
  
```  
  
int _RTC_NumErrors( void );  
  
```  
  
## Return Value  
 An integer whose value represents the total number of errors that can be detected by the Visual C++ run-time error checks.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`_RTC_NumErrors`|<rtcapi.h>|  
  
 For more information, see [Compatibility](../vs140/compatibility.md).  
  
## Libraries  
 All versions of the [C run-time libraries](../vs140/crt-library-features.md).  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [_RTC_GetErrDesc](../vs140/_rtc_geterrdesc.md)   
 [Run-Time Error Checking](../vs140/run-time-error-checking.md)