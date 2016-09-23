---
title: "_RTC_SetErrorType"
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
  - _RTC_SetErrorType
apilocation: 
  - msvcr90.dll
  - msvcr80.dll
  - msvcr110_clr0400.dll
  - msvcrt.dll
  - msvcr120.dll
  - msvcr100.dll
  - msvcr110.dll
apitype: DLLExport
f1_keywords: 
  - RTC_SetErrorType
  - _RTC_SetErrorType
dev_langs: 
  - C++
  - C
helpviewer_keywords: 
  - run-time errors
  - RTC_SetErrorType function
  - _RTC_SetErrorType function
ms.assetid: f5f99be7-d357-4b11-b8f5-ddd3428f2b06
caps.latest.revision: 17
translation.priority.mt: 
  - de-de
  - ja-jp
---
# _RTC_SetErrorType
Associates an error that is detected by run-time error checks (RTCs) with a type. Your error handler processes how to output errors of the specified type.  
  
## Syntax  
  
```  
  
      int _RTC_SetErrorType(  
   _RTC_ErrorNumber errnum,  
   int ErrType   
);  
```  
  
#### Parameters  
 *errnum*  
 A number between zero and one less than the value returned by [_RTC_NumErrors](../vs140/_rtc_numerrors.md).  
  
 *ErrType*  
 A value to assign to this *errnum*. For example, you might use **_CRT_ERROR**. If you are using `_CrtDbgReport` as your error handler, *ErrType* can only be one of the symbols defined in [_CrtSetReportMode](../vs140/_crtsetreportmode.md). If you have your own error handler ([_RTC_SetErrorFunc](../vs140/_rtc_seterrorfunc.md)), you can have as many *ErrType*s as there are *errnum*s.  
  
 An *ErrType* of _RTC_ERRTYPE_IGNORE has special meaning to `_CrtSetReportMode`; the error is ignored.  
  
## Return Value  
 The previous value for the error type `type`.  
  
## Remarks  
 By default, all errors are set to *ErrType* = 1, which corresponds to **_CRT_ERROR**. For more information about the default error types such as **_CRT_ERROR**, see [_CrtDbgReport](../vs140/_crtdbgreport--_crtdbgreportw.md).  
  
 Before you can call this function, you must first call one of the run-time error check initialization functions; see [Using Run-Time Checks without the C Run-Time Library](../vs140/using-run-time-checks-without-the-c-run-time-library.md)  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|`_RTC_SetErrorType`|<rtcapi.h>|  
  
 For more information, see [Compatibility](../vs140/compatibility.md).  
  
## Libraries  
 All versions of the [C run-time libraries](../vs140/crt-library-features.md).  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [_RTC_GetErrDesc](../vs140/_rtc_geterrdesc.md)   
 [Run-Time Error Checking](../vs140/run-time-error-checking.md)