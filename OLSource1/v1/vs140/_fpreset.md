---
title: "_fpreset"
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
  - "_fpreset"
apilocation: 
  - "msvcrt.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr110.dll"
  - "msvcr100.dll"
  - "msvcr80.dll"
  - "msvcr120.dll"
  - "msvcr90.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_fpreset"
  - "fpreset"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "fpreset function"
  - "floating-point numbers, resetting math package"
  - "_fpreset function"
ms.assetid: f31c6a04-b464-4f07-a7c4-42133360e328
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _fpreset
Resets the floating-point package.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> function reinitializes the floating-point math package. <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is usually used with <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, or the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> functions. If a program traps floating-point error signals (<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>) with <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, it can safely recover from floating-point errors by invoking <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and using <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
 This function is deprecated when compiling with [/clr](../vs140/-clr--common-language-runtime-compilation-.md) or <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> because the common language runtime only supports the default floating-point precision.  
  
## Requirements  
  
|Function|Required header|  
|--------------|---------------------|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|\<float.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Dividing    5 by    0...**  
**Error 131: Divide by zero**   
## See Also  
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [_exec, _wexec Functions](../vs140/_exec--_wexec-functions.md)   
 [signal](../vs140/signal.md)   
 [_spawn, _wspawn Functions](../vs140/_spawn--_wspawn-functions.md)   
 [system, _wsystem](../vs140/system--_wsystem.md)