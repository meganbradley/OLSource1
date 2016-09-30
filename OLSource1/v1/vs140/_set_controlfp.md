---
title: "_set_controlfp"
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
  - "_set_controlfp"
apilocation: 
  - "msvcr100.dll"
  - "msvcr120.dll"
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr80.dll"
  - "msvcrt.dll"
  - "msvcr90.dll"
apitype: "DLLExport"
f1_keywords: 
  - "set_controlfp"
  - "_set_controlfp"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "set_controlfp function"
  - "floating-point functions, setting control word"
  - "_set_controlfp function"
ms.assetid: e0689d50-f68a-4028-a9c1-fb23eedee4ad
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _set_controlfp
Sets the floating-point control word.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 New control-word bit values.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Mask for new control-word bits to set.  
  
## Return Value  
 None.  
  
## Remarks  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is similar to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, but it only sets the floating-point control word to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. The bits in the values indicate the floating-point control state. The floating-point control state allows the program to change the precision, rounding, and infinity modes in the floating-point math package. You can also mask or unmask floating-point exceptions using <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. For more information, see [_control87, _controlfp, \__control87_2](../vs140/_control87--_controlfp--__control87_2.md).  
  
 This function is deprecated when compiling with [/clr](../vs140/-clr--common-language-runtime-compilation-.md) or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> because the common language runtime only supports the default floating-point precision.  
  
## Requirements  
  
|Routine|Required header|Compatibility|  
|-------------|---------------------|-------------------|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|\<float.h>|x86 processor only|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## See Also  
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [_clear87, _clearfp](../vs140/_clear87--_clearfp.md)   
 [_status87, _statusfp, _statusfp2](../vs140/_status87--_statusfp--_statusfp2.md)