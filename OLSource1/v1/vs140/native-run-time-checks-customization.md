---
title: "Native Run-Time Checks Customization"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vs.debug.crt"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
  - "JScript"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "runtime_checks pragma"
  - "debugger, native run-time checks"
  - "/RTC compiler option [C++], native run-time checks"
  - "customizing CRT error checking"
  - "native run-time checks, customizing"
ms.assetid: 76a365fe-6439-49db-8603-34058b78e5a8
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Native Run-Time Checks Customization
When you compile with **/RTC** (run-time checks) or use the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> pragma, the C run-time library provides native run-time checks. In some cases, you might want to customize run-time checking:  
  
-   To route run-time check messages to a file or destination other than the default.  
  
-   To specify an output destination for run-time check messages under a third-party debugger.  
  
-   To report run-time check messages from a program compiled with a release version of the C run-time library. Release versions of the library do not use <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> to report run-time errors. Instead, they display an **Assert** dialog box for each run-time error.  
  
 To customize run-time error checking, you can:  
  
-   Write a run-time error reporting function. For more information, see [How to: Write a Run-Time Error Reporting Function](../vs140/how-to--write-a-run-time-error-reporting-function.md).  
  
-   Customize the error message destination.  
  
-   Query for information about run-time check errors.  
  
## Customize the Error Message Destination  
 If you use <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to report errors, you can use <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to specify the destination of error messages.  
  
 If you use a custom reporting function, use <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to associate an error with a report type.  
  
## Query for Information About Run-Time Checks  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> returns the number of error types detected by run-time error checks. To get a brief description of each error, you can loop from 0 to the return value of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, passing the iteration value to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> on each loop. For more information, see [_RTC_NumErrors](../vs140/_rtc_numerrors.md) and [_RTC_GetErrDesc](../vs140/_rtc_geterrdesc.md).  
  
## See Also  
 [How to: Use Native Run-Time Checks](../vs140/how-to--use-native-run-time-checks.md)   
 [runtime_checks](../vs140/runtime_checks.md)   
 [_CrtDbgReportW](../vs140/_crtdbgreport--_crtdbgreportw.md)