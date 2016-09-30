---
title: "clock"
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
  - "clock"
apilocation: 
  - "msvcrt.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr110.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
  - "msvcr120.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "clock"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "processor time used, calculating"
  - "time, calculating processor"
  - "clock function"
  - "processor time used"
  - "calculating processor time used"
ms.assetid: 3e1853dd-498f-49ba-b06a-f2315f20904e
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# clock
Calculates the wall-clock time used by the calling process.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The elapsed wall-clock time since the start of the process (elapsed time in seconds times <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>). If the amount of elapsed time is unavailable, the function returns –1, cast as a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Remarks  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> function tells how much wall-clock time the calling process has used. Note that this is not strictly conformant with ISO C99, which specifies net CPU time as the return value. To obtain CPU time, use the Win32 [GetProcessTimes](http://msdn.microsoft.com/library/windows/desktop/ms683223) function.  
  
 A timer tick is approximately equal to 1/<CodeContentPlaceHolder>5\</CodeContentPlaceHolder> seconds. Given enough time, the value returned by <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> can exceed the maximum positive value of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and become negative, or exceed the maximum absolute value and roll over. Do not rely on this value for total elapsed time in processes that run for more than 214,748 seconds, or about 59 hours.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|\<time.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Delay for three seconds**  
**Done!**  
**Time to do 6000000 empty loops is 0.1 seconds**   
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Time Management](../vs140/time-management.md)   
 [difftime, _difftime32, _difftime64](../vs140/difftime--_difftime32--_difftime64.md)   
 [time, _time32, _time64](../vs140/time--_time32--_time64.md)