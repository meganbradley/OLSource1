---
title: "_status87, _statusfp, _statusfp2"
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
  - "_statusfp2"
  - "_statusfp"
  - "_status87"
apilocation: 
  - "msvcr90.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr110.dll"
  - "msvcr80.dll"
  - "msvcrt.dll"
  - "msvcr100.dll"
  - "msvcr120.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_statusfp2"
  - "_statusfp"
  - "statusfp2"
  - "_status87"
  - "status87"
  - "statusfp"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "floating-point functions, getting status word"
  - "floating-point numbers, status word"
  - "status87 function"
  - "status word, getting floating point"
  - "statusfp function"
  - "_statusfp function"
  - "_statusfp2 function"
  - "statusfp2 function"
  - "_status87 function"
  - "floating-point functions"
  - "status word"
ms.assetid: 7ef963fa-b1fb-429d-94d6-fbf282ab7432
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _status87, _statusfp, _statusfp2
Gets the floating-point status word.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 This address is filled with the status word for the x87 floating-point unit.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 This address is filled with the status word for the SSE2 floating-point unit.  
  
## Return Value  
 For <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, the bits in the value that's returned indicate the floating-point status. See the FLOAT.H include file for a definition of the bits that are returned by <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. Many math library functions modify the floating-point status word, with unpredictable results. Optimization can reorder, combine, and eliminate floating-point operations around calls to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, and related functions. Use the [/Od](../vs140/-od--disable--debug--.md) compiler option or the [fenv_access](../vs140/fenv_access.md) pragma directive to prevent optimizations that reorder floating-point operations. Return values from <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, and also the return parameters of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, are more reliable if fewer floating-point operations are performed between known states of the floating-point status word.  
  
## Remarks  
 The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> function gets the floating-point status word. The status word is a combination of the floating-point processor status and other conditions detected by the floating-point exception handler—for example, floating-point stack overflow and underflow. Unmasked exceptions are checked for before the contents of the status word are returned. This means that the caller is informed of pending exceptions. On x86 platforms, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> returns a combination of the x87 and SSE2 floating-point status. On x64 platforms, the status that's returned is based on the SSE’s MXCSR status. On ARM platforms, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> returns status from the FPSCR register.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is a platform-independent, portable version of <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. It is identical to <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> on Intel (x86) platforms and is also supported by the x64 and ARM platforms. To ensure that your floating-point code is portable to all architectures, use <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>. If you are only targeting x86 platforms, you can use either <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.  
  
 We recommend <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> for chips (such as the Pentium IV) that have both an x87 and an SSE2 floating-point processor. For <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, the addresses are filled by using the floating-point status word for both the x87 or the SSE2 floating-point processor. For a chip that supports x87 and SSE2 floating-point processors, EM_AMBIGUOUS is set to 1 if <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is used and the action was ambiguous because it could refer to the x87 or the SSE2 floating-point status word. The <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> function is only supported on x86 platforms.  
  
 These functions are not useful for [/clr](../vs140/-clr--common-language-runtime-compilation-.md) or <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> compilation because the common language runtime (CLR) only supports the default floating-point precision.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|\<float.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Status = 0x00000000 - clear**  
**Status = 0x00000003 - inexact, underflow**  
**Status = 0x00080003 - inexact, underflow, denormal**   
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [_clear87, _clearfp](../vs140/_clear87--_clearfp.md)   
 [_control87, _controlfp, \__control87_2](../vs140/_control87--_controlfp--__control87_2.md)