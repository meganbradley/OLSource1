---
title: "_lrotl, _lrotr"
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
  - "_lrotl"
  - "_lrotr"
apilocation: 
  - "msvcr100.dll"
  - "msvcr120.dll"
  - "msvcr90.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr110.dll"
  - "msvcr80.dll"
  - "msvcrt.dll"
apitype: "DLLExport"
f1_keywords: 
  - "lrotr"
  - "lrotl"
  - "_lrotr"
  - "_lrotl"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "lrotl function"
  - "bits"
  - "_lrotr function"
  - "lrotr function"
  - "rotating bits"
  - "_lrotl function"
  - "bits, rotating"
ms.assetid: d42f295b-35f9-49d2-9ee4-c66896ffe68e
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _lrotl, _lrotr
Rotates bits to the left (<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>) or right (<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *value*  
 Value to be rotated.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Number of bits to shift *value*.  
  
## Return Value  
 Both functions return the rotated value. There is no error return.  
  
## Remarks  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> functions rotate *value* by <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> bits. <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> rotates the value left. <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> rotates the value right. Both functions wrap bits rotated off one end of *value* to the other end.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|\<stdlib.h>|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|\<stdlib.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Libraries  
 All versions of the [C run-time libraries](../vs140/crt-library-features.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [_rotl, _rotl64, _rotr, _rotr64](../vs140/_rotl--_rotl64--_rotr--_rotr64.md)