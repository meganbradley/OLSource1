---
title: "How to: Write a Run-Time Error Reporting Function"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
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
  - "run-time errors, reporting functions"
  - "reporting function"
ms.assetid: 989bf312-5038-44f3-805f-39a34d18760e
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Write a Run-Time Error Reporting Function
A custom reporting function for run-time errors must have the same declaration as <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. It should return a value of 1 to the debugger.  
  
 The following example shows how to define a custom reporting function.  
  
## Example  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 The following example shows a more complex custom reporting function. In this example, the switch statement handles various error types, as defined by the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> parameter of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. Because you are replacing <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, you cannot use <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. Your function must handle the output. The first variable argument in this function takes a run-time error number. For more information, see [_RTC_SetErrorType](../vs140/_rtc_seterrortype.md).  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 Use <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to install your custom function in place of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. For more information, see [_RTC_SetErrorFuncW](../vs140/_rtc_seterrorfuncw.md). The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> return value is the previous reporting function, which you can save and restore if necessary.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [Native Run-Time Check Customization](../vs140/native-run-time-checks-customization.md)