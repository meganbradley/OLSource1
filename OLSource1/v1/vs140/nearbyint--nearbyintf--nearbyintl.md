---
title: "nearbyint, nearbyintf, nearbyintl"
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
  - "nearbyint"
  - "nearbyintf"
  - "nerabyintl"
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
  - "nearbyint"
  - "nearbyintf"
  - "nearbyintl"
  - "math/nearbyint"
  - "math/narbyintf"
  - "math/narbyintl"
dev_langs: 
  - "C"
  - "C++"
helpviewer_keywords: 
  - "nearbyint function"
  - "nearbyintf function"
  - "nearbyintl function"
ms.assetid: dd39cb68-96b0-434b-820f-6ff2ea65584f
caps.latest.revision: 16
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# nearbyint, nearbyintf, nearbyintl
Rounds the specified floating-point value to an integer, and returns that value in a floating-point format.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The value to round.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, rounded to the nearest integer, using the current rounding format as defined by fegetround. Otherwise, the function may return one of the following values:  
  
|Issue|Return|  
|-----------|------------|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder> = ±INFINITY|±INFINITY, unmodified|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder> = ±0|±0, unmodified|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder> = NaN|NaN|  
  
 Errors are not reported through [_matherr](../vs140/_matherr.md); specifically, this function does not report any FE_INEXACT exceptions.  
  
## Remarks  
 The primary difference between this function and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is that this function does not raise the inexact floating point exception.  
  
 Because the maximum floating-point values are exact integers, this function will never overflow by itself; rather, the output may overflow the return value, depending on which version of the function you use.  
  
## Requirements  
  
|Function|C header|C++ header|  
|--------------|--------------|------------------|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>,                <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>,  <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|\<math.h>|\<cmath>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## See Also  
 [Alphabetical Function Reference](../vs140/crt-alphabetical-function-reference.md)