---
title: "_byteswap_uint64, _byteswap_ulong, _byteswap_ushort"
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
  - "_byteswap_uint64"
  - "_byteswap_ulong"
  - "_byteswap_ushort"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcr90.dll"
  - "msvcr80.dll"
  - "msvcr120.dll"
  - "msvcr100.dll"
  - "msvcrt.dll"
  - "msvcr110.dll"
apitype: "DLLExport"
f1_keywords: 
  - "byteswap_ulong"
  - "_byteswap_ulong"
  - "byteswap_uint64"
  - "_byteswap_ushort"
  - "_byteswap_uint64"
  - "byteswap_ushort"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_byteswap_uint64 function"
  - "byteswap_uint64 function"
  - "swapping bytes"
  - "byte swapping"
  - "byteswap_ushort function"
  - "_byteswap_ushort function"
  - "bytes, swapping"
  - "byteswap_ulong function"
  - "_byteswap_ulong function"
ms.assetid: 83bda211-f02f-4cf0-8a78-d6de1f175970
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _byteswap_uint64, _byteswap_ulong, _byteswap_ushort
Reverses the order of bytes in an integer.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The integer to reverse byte order.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|\<stdlib.h>|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|\<stdlib.h>|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|\<stdlib.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **byteswap of 102030405060708 = 807060504030201**  
**byteswap of 1020304 = 4030201**   
## See Also  
 [Run-Time Routines by Category](../vs140/run-time-routines-by-category.md)