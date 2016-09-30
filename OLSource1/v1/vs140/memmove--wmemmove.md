---
title: "memmove, wmemmove"
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
  - "memmove"
  - "wmemmove"
apilocation: 
  - "msvcr90.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr110.dll"
  - "msvcr120.dll"
  - "msvcr80.dll"
  - "msvcrt.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "memmove"
  - "wmemmove"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "wmemmove function"
  - "memmove function"
ms.assetid: 3a906114-9cf3-40d7-bd99-ee452004f218
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# memmove, wmemmove
Moves one buffer to another. More secure versions of these functions are available; see [memmove_s, wmemmove_s](../vs140/memmove_s--wmemmove_s.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Destination object.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Source object.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Number of bytes (<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>) or characters (<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>) to copy.  
  
## Return Value  
 The value of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>*.*  
  
## Remarks  
 Copies <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> bytes (<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>) or characters (<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>) from <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>*.* If some regions of the source area and the destination overlap, both functions ensure that the original source bytes in the overlapping region are copied before being overwritten.  
  
 **Security Note** Make sure that the destination buffer is the same size or larger than the source buffer. For more information, see [Avoiding Buffer Overruns](http://msdn.microsoft.com/library/windows/desktop/ms717795).  
  
 The <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> functions will only be deprecated if the constant <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is defined prior to the inclusion statement in order for the functions to be deprecated, such as in the example below:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|\<string.h>|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|\<wchar.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **The string: aabbcc**  
**New string: aaaabb**  
**The string: aabbcc**  
**New string: aaaabb**   
## .NET Framework Equivalent  
 [System::Buffer::BlockCopy](https://msdn.microsoft.com/en-us/library/system.buffer.blockcopy.aspx)  
  
## See Also  
 [Buffer Manipulation](../vs140/buffer-manipulation.md)   
 [_memccpy](../vs140/_memccpy.md)   
 [memcpy, wmemcpy](../vs140/memcpy--wmemcpy.md)   
 [strcpy, wcscpy, _mbscpy](../vs140/strcpy--wcscpy--_mbscpy.md)   
 [strncpy, _strncpy_l, wcsncpy, _wcsncpy_l, _mbsncpy, _mbsncpy_l](../vs140/strncpy--_strncpy_l--wcsncpy--_wcsncpy_l--_mbsncpy--_mbsncpy_l.md)