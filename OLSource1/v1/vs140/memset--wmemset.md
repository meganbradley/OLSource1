---
title: "memset, wmemset"
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
  - "wmemset"
  - "memset"
apilocation: 
  - "msvcr120.dll"
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr110.dll"
  - "msvcr100.dll"
  - "msvcr90.dll"
  - "msvcr120_clr0400.dll"
  - "api-ms-win-crt-string-l1-1-0.dll"
  - "api-ms-win-core-crt-l1-1-0.dll"
  - "ntdll.dll"
  - "ntoskrnl.exe"
apitype: "DLLExport"
f1_keywords: 
  - "memset"
  - "wmemset"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "wmemset function"
  - "memset function"
ms.assetid: e7ceb01b-df69-49c2-b294-a39358ad4699
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# memset, wmemset
Sets buffers to a specified character.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *dest*  
 Pointer to destination.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Character to set.  
  
 *count*  
 Number of characters.  
  
## Return Value  
 The value of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Remarks  
 Sets the first <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> characters of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to the character <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 **Security Note** Make sure that the destination buffer has enough room for at least <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> characters. For more information, see [Avoiding Buffer Overruns](http://msdn.microsoft.com/library/windows/desktop/ms717795).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|\<memory.h> or \<string.h>|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|\<wchar.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Libraries  
 All versions of the [C run-time libraries](../vs140/crt-library-features.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Here's an example of the use of wmemset:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## .NET Framework Equivalent  
 [System::Buffer::SetByte](https://msdn.microsoft.com/en-us/library/system.buffer.setbyte.aspx)  
  
## See Also  
 [Buffer Manipulation](../vs140/buffer-manipulation.md)   
 [_memccpy](../vs140/_memccpy.md)   
 [memchr, wmemchr](../vs140/memchr--wmemchr.md)   
 [memcmp, wmemcmp](../vs140/memcmp--wmemcmp.md)   
 [memcpy, wmemcpy](../vs140/memcpy--wmemcpy.md)   
 [_strnset, _wcsnset, _mbsnset, _mbsnset_l](../vs140/_strnset--_strnset_l--_wcsnset--_wcsnset_l--_mbsnset--_mbsnset_l.md)