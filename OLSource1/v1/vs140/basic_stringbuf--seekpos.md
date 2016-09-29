---
title: "basic_stringbuf::seekpos"
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
  - "basic_stringbuf.seekpos"
  - "seekpos"
  - "std::basic_stringbuf::seekpos"
  - "basic_stringbuf::seekpos"
  - "sstream/std::basic_stringbuf::seekpos"
  - "std.basic_stringbuf.seekpos"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "seekpos method"
ms.assetid: e3e50797-f450-4567-a072-c33a56b00f56
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_stringbuf::seekpos
The protected virtual member function tries to alter the current positions for the controlled streams.  
  
## Syntax  
  
```  
  
      virtual pos  
      _  
      type seekpos(  
   pos_type _Sp,  
   ios_base::openmode _Mode = ios_base::in | ios_base::out  
);  
```  
  
#### Parameters  
 `_Sp`  
 The position to seek for.  
  
 `_Mode`  
 Specifies the mode for the pointer position. The default is to allow you to modify the read and write positions.  
  
## Return Value  
 If the function succeeds in altering either or both of the stream positions, it returns the resultant stream position. Otherwise, it fails and returns an invalid stream position. To determine if the stream position is invalid, compare the return value with `pos_type(off_type(-1))`.  
  
## Remarks  
 For an object of class basic_stringbuf<**Elem**, **Tr**, `Alloc`>, a stream position consists purely of a stream offset. Offset zero designates the first element of the controlled sequence. The new position is determined by _*Sp*.  
  
 If **mode & ios_base::in** is nonzero, the function alters the next position to read in the input buffer. If **mode & ios_base::out** is nonzero, the function alters the next position to write in the output buffer. For a stream to be affected, its buffer must exist. For a positioning operation to succeed, the resulting stream position must lie within the controlled sequence. Otherwise (or if neither position is affected), the positioning operation fails.  
  
## Requirements  
 **Header:** <sstream\>  
  
 **Namespace:** std  
  
## See Also  
 [basic_stringbuf Class](../vs140/basic_stringbuf-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)