---
title: "Macros for Reporting"
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
  - "vs.debug.macros"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
  - "C++"
helpviewer_keywords: 
  - "macros, CRT reporting macros"
  - "macros, debugging with"
  - "_RPTFn macro"
  - "CRT, reporting macros"
  - "debugging [CRT], reporting macros"
  - "_RPTn macro"
ms.assetid: f2085314-a3a8-4caf-a5a4-2af9ad5aad05
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Macros for Reporting
You can use the **_RPTn**, and **_RPTFn** macros, defined in CRTDBG.H, to replace the use of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> statements for debugging. These macros automatically disappear in your release build when **_DEBUG** is not defined, so there is no need to enclose them in **#ifdef**s.  
  
|Macro|Description|  
|-----------|-----------------|  
|**_RPT0**, **_RPT1**, **_RPT2**, **_RPT3**, **_RPT4**|Outputs a message string and zero to four arguments. For _RPT1 through **_RPT4**, the message string serves as a printf-style formatting string for the arguments.|  
|**_RPTF0**, **_RPTF1**, **,_RPTF2**, **_RPTF4**|Same as **_RPTn** , but these macros also output the file name and line number where the macro is located.|  
  
 Consider the following example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This code outputs the values of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to **stdout**. You can use the following call to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to report these same values and, additionally, the file name and line number:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 If you find that a particular application needs debug reporting that the macros supplied with the C run-time library do not provide, you can write a macro designed specifically to fit your own requirements. In one of your header files, for example, you could include code like the following to define a macro called **ALERT_IF2**:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 One call to **ALERT_IF2** could perform all the functions of the **printf** code at the start of this topic:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Because a custom macro can easily be changed to report more or less information to different destinations (depending on what is more convenient), this approach can be particularly useful as your debugging requirements evolve.  
  
## See Also  
 [CRT Debugging Techniques](../vs140/crt-debugging-techniques.md)