---
title: "Buffer Manipulation"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "c.memory"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "buffers, manipulation routines"
  - "buffers"
ms.assetid: 164f4860-ce66-412c-8291-396fbd70f03e
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Buffer Manipulation
Use these routines to work with areas of memory on a byte-by-byte basis.  
  
### Buffer-Manipulation Routines  
  
|Routine|Use|.NET Framework equivalent|  
|-------------|---------|-------------------------------|  
|[_memccpy](../vs140/_memccpy.md)|Copy characters from one buffer to another until given character or given number of characters has been copied|[System::Buffer::BlockCopy](https://msdn.microsoft.com/en-us/library/system.buffer.blockcopy.aspx), [System::String::Copy](https://msdn.microsoft.com/en-us/library/system.string.copy.aspx)|  
|[memchr, wmemchr](../vs140/memchr--wmemchr.md)|Return pointer to first occurrence, within specified number of characters, of given character in buffer|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
|[memcmp, wmemcmp](../vs140/memcmp--wmemcmp.md)|Compare specified number of characters from two buffers|[System::String::Compare](https://msdn.microsoft.com/en-us/library/system.string.compare.aspx), [System::String::Equals](https://msdn.microsoft.com/en-us/library/system.string.equals.aspx)|  
|[memcpy, wmemcpy](../vs140/memcpy--wmemcpy.md), [memcpy_s, wmemcpy_s](../vs140/memcpy_s--wmemcpy_s.md)|Copy specified number of characters from one buffer to another|[System::Buffer::BlockCopy](https://msdn.microsoft.com/en-us/library/system.buffer.blockcopy.aspx), [System::String::Copy](https://msdn.microsoft.com/en-us/library/system.string.copy.aspx)|  
|[_memicmp, _memicmp_l](../vs140/_memicmp--_memicmp_l.md)|Compare specified number of characters from two buffers without regard to case|[System::String::Compare](https://msdn.microsoft.com/en-us/library/system.string.compare.aspx), [System::String::Equals](https://msdn.microsoft.com/en-us/library/system.string.equals.aspx)|  
|[memmove, wmemmove](../vs140/memmove--wmemmove.md),[memmove_s, wmemmove_s](../vs140/memmove_s--wmemmove_s.md)|Copy specified number of characters from one buffer to another|[System::Buffer::BlockCopy](https://msdn.microsoft.com/en-us/library/system.buffer.blockcopy.aspx)|  
|[memset, wmemset](../vs140/memset--wmemset.md)|Use given character to initialize specified number of bytes in the buffer|[System::Buffer::SetByte](https://msdn.microsoft.com/en-us/library/system.buffer.setbyte.aspx)|  
|[_swab](../vs140/_swab.md)|Swap bytes of data and store them at specified location|Not applicable. To call the standard C function, use `PInvoke`. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).|  
  
 When the source and target areas overlap, only `memmove` is guaranteed to copy the full source properly.  
  
## See Also  
 [Run-Time Routines by Category](../vs140/run-time-routines-by-category.md)