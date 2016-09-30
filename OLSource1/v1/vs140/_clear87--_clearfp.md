---
title: "_clear87, _clearfp"
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
  - "_clearfp"
  - "_clear87"
apilocation: 
  - "msvcr90.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
  - "msvcr100.dll"
  - "msvcr110.dll"
  - "msvcrt.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "clearfp"
  - "_clearfp"
  - "_clear87"
  - "clear87"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "clearing floating point status word"
  - "clearfp function"
  - "_clear87 function"
  - "_clearfp function"
  - "clear87 function"
ms.assetid: 72d24a70-7688-4793-ae09-c96d33fcca52
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _clear87, _clearfp
Gets and clears the floating-point status word.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The bits in the value returned indicate the floating-point status before the call to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. For a complete definition of the bits returned by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, see Float.h. Many of the math library functions modify the 8087/80287 status word, with unpredictable results. Return values from <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> become more reliable as fewer floating-point operations are performed between known states of the floating-point status word.  
  
## Remarks  
 The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> function clears the exception flags in the floating-point status word, sets the busy bit to 0, and returns the status word. The floating-point status word is a combination of the 8087/80287 status word and other conditions detected by the 8087/80287 exception handler, such as floating-point stack overflow and underflow.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is a platform-independent, portable version of the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> routine. It is identical to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> on Intel (x86) platforms and is also supported by the x64 and ARM platforms. To ensure that your floating-point code is portable to x64 and ARM, use <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. If you are only targeting x86 platforms, you can use either <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
 These functions are deprecated when compiling with [/clr](../vs140/-clr--common-language-runtime-compilation-.md) or <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> because the common language runtime only supports the default floating-point precision.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|\<float.h>|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|\<float.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Status: 0000 - clear**  
**Status: 0003 - inexact, underflow**  
**Status: 80000 - denormal**   
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [_control87, _controlfp, \__control87_2](../vs140/_control87--_controlfp--__control87_2.md)   
 [_status87, _statusfp, _statusfp2](../vs140/_status87--_statusfp--_statusfp2.md)