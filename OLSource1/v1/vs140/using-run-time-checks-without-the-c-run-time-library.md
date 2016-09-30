---
title: "Using Run-Time Checks Without the C Run-Time Library"
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
  - "vs.debug.runtime"
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
  - "run-time errors, error checks"
  - "CRT, run-time checks"
  - "debugger, native run-time checks"
  - "run-time errors, run-time checks"
  - "run-time checks, /RTC option"
  - "debugging [Visual Studio], run-time routines"
ms.assetid: 30ed90f3-9323-4784-80a4-937449eb54f6
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Using Run-Time Checks Without the C Run-Time Library
If you link your program without the C run-time library, using **/NODEFAULTLIB**, and want to use run-time checks, you must link with RunTmChk.lib.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> initializes your program for run-time checks. If you do not link with the C run-time library, you must check to see whether your program is compiled with run-time error checks before calling <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, as follows:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 If you do not link with the C run-time library, you must also define a function called <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> installs your user-defined function as the default error reporting function, as follows:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 After you have installed the default error reporting function, you can install additional error reporting functions with <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. For more information, see [_RTC_SetErrorFuncW](../vs140/_rtc_seterrorfuncw.md).  
  
## See Also  
 [Run-Time Error Checks](../vs140/how-to--use-native-run-time-checks.md)