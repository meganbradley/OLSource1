---
title: "isnan, _isnan, _isnanf"
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
  - "_isnan"
  - "_isnanf"
  - "isnan"
apilocation: 
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr110.dll"
  - "msvcr120.dll"
  - "msvcr80.dll"
  - "msvcrt.dll"
  - "msvcr90.dll"
  - "api-ms-win-crt-math-l1-1-0.dll"
  - "msvcr120_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_isnan"
  - "isnan"
  - "math/isnan"
  - "math/_isnan"
  - "math/_isnanf"
  - "_isnanf"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "NAN (not a number)"
  - "_isnan function"
  - "IEEE floating-point representation"
  - "Not a Number (NANs)"
  - "isnan function"
ms.assetid: 391fbc5b-89a4-4fba-997e-68f1131caf82
caps.latest.revision: 15
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# isnan, _isnan, _isnanf
Tests if a floating-point value is not a number (NAN).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *x*  
 The floating-point value to test.  
  
## Return Value  
 In C, the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> macro and the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> functions return a nonzero value if the argument <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is a NAN; otherwise they return 0.  
  
 In C++, the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> template functions return <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> if the argument <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is a NAN; otherwise they return <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Remarks  
 The C <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> macro and the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> functions test floating-point value *x*, returning a nonzero value if *x* is a Not a Number (NAN) value. A NAN is generated when the result of a floating-point operation can't be represented in IEEE-754 floating-point format for the specified type. For information about how a NAN is represented for output, see [printf](../vs140/printf--_printf_l--wprintf--_wprintf_l.md).  
  
 When compiled as C++, the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> macro is not defined, and an <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> template function is defined instead. It returns a value of type <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> instead of an integer.  
  
 The <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> functions are Microsoft specific. The <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> function is only available when compiled for x64.  
  
## Requirements  
  
|Routine|Required header (C)|Required header (C++)|  
|-------------|---------------------------|-------------------------------|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|\<math.h>|\<math.h> or \<cmath>|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|\<float.h>|\<float.h> or \<cfloat>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## See Also  
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [_finite, _finitef](../vs140/_finite--_finitef.md)   
 [_fpclass, _fpclassf](../vs140/_fpclass--_fpclassf.md)