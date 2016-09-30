---
title: "_rotl, _rotl64, _rotr, _rotr64"
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
  - "_rotr64"
  - "_rotl"
  - "_rotr"
  - "_rotl64"
apilocation: 
  - "msvcr110.dll"
  - "msvcr120.dll"
  - "msvcrt.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr80.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_rotr64"
  - "rotl64"
  - "_rotl64"
  - "rotr64"
  - "rotr"
  - "_rotr"
  - "_rotl"
  - "rotl"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "rotl64 function"
  - "_rotl function"
  - "rotr function"
  - "rotr64 function"
  - "_rotr function"
  - "rotl function"
  - "_rotl64 function"
  - "rotating bits"
  - "_rotr64 function"
  - "bits, rotating"
ms.assetid: cfce439b-366f-4584-8ab1-d527b13fcfc6
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _rotl, _rotl64, _rotr, _rotr64
Rotates bits to the left (<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>) or right (<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *value*  
 Value to be rotated.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Number of bits to shift.  
  
## Return Value  
 The rotated value. There is no error return.  
  
## Remarks  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> functions rotate the unsigned *value* by <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> bits. <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> rotates the value left. <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> rotates the value right. Both functions wrap bits rotated off one end of *value* to the other end.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|**_rotl, _rotl64**|\<stdlib.h>|  
|**_rotr, _rotr64**|\<stdlib.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Libraries  
 All versions of the [C run-time libraries](../vs140/crt-library-features.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [_lrotl, _lrotr](../vs140/_lrotl--_lrotr.md)