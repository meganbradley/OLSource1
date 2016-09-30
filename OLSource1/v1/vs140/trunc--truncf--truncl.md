---
title: "trunc, truncf, truncl"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "cpp"
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
apiname: 
  - "trunc"
  - "truncf"
  - "truncl"
apilocation: 
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
  - "msvcr110.dll"
  - "msvcr110_clr400.dll"
  - "msvcr120.dll"
  - "api-ms-win-crt-math-l1-1-0.dll"
apitype: "DLLExport"
f1_keywords: 
  - "trunc"
  - "truncf"
  - "truncl"
  - "math/trunc"
  - "math/truncf"
  - "math/truncl"
dev_langs: 
  - "C"
  - "C++"
helpviewer_keywords: 
  - "trunc function"
  - "truncf function"
  - "truncl function"
ms.assetid: de2038ac-ac0b-483e-870c-e8992dcd4fd0
caps.latest.revision: 17
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# trunc, truncf, truncl
Determines the nearest integer that is less than or equal to the specified floating-point value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The value to truncate.  
  
## Return Value  
 If successful, returns an integer value of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, rounded towards zero.  
  
 Otherwise, may return one of the following:  
  
|Issue|Return|  
|-----------|------------|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder> = ±INFINITY|x|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder> =  ±0|x|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder> = NaN|NaN|  
  
 Errors are reported as specified in [_matherr](../vs140/_matherr.md).  
  
## Remarks  
 Because C++ allows overloading, you can call overloads of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> that take and return float and long double types. In a C program, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> always takes and returns a double.  
  
 Because the largest floating-point values are exact integers, this function will not overflow on its own. However, you may cause the function to overflow by returning a value into an integer type.  
  
 You can also round down by implicitly converting from floating-point to integral; however, doing so is limited to the values that can be stored in the target type.  
  
## Requirements  
  
|Function|C header|C++ header|  
|--------------|--------------|------------------|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>,                <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>,  <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|\<math.h>|\<cmath>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## See Also  
 [Alphabetical Function Reference](../vs140/crt-alphabetical-function-reference.md)   
 [floor, floorf, floorl](../vs140/floor--floorf--floorl.md)   
 [ceil, ceilf, ceill](../vs140/ceil--ceilf--ceill.md)   
 [round, roundf, roundl](../vs140/round--roundf--roundl.md)