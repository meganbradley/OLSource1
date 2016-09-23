---
title: "strstreambuf::seekpos"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - strstreambuf::seekpos
  - seekpos
  - std::strstreambuf::seekpos
  - std.strstreambuf.seekpos
  - strstreambuf.seekpos
dev_langs: 
  - C++
helpviewer_keywords: 
  - seekpos method
ms.assetid: 7e54f904-4a66-4414-8109-dbd79fd2178e
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# strstreambuf::seekpos
A protected virtual member function that tries to alter the current positions for the controlled streams.  
  
## Syntax  
  
```  
  
      virtual streampos seekpos(  
   streampos _Sp,  
   ios_base::openmode _Which = ios_base::in | ios_base::out  
);  
```  
  
#### Parameters  
 `_Sp`  
 The position to seek for.  
  
 `_Which`  
 Specifies the mode for the pointer position. The default is to allow you to modify the read and write positions.  
  
## Return Value  
 If the function succeeds in altering either or both stream positions, it returns the resultant stream position. Otherwise, it fails and returns an invalid stream position. To determine if the stream position is invalid, compare the return value with `pos_type(off_type(-1))`.  
  
## Remarks  
 The protected virtual member function endeavors to alter the current positions for the controlled streams. For an object of class strstreambuf, a stream position consists purely of a stream offset. Offset zero designates the first element of the controlled sequence. The new position is determined by _*Sp*.  
  
 If `_Which` & **ios_base::in** is nonzero and the input buffer exists, the function alters the next position to read in the input buffer. If `_Which` & `ios_base::out` is nonzero and the output buffer exists, the function also sets the next position to write to match the next position to read. Otherwise, if `_Which` & `ios_base::out` is nonzero and the output buffer exists, the function alters the next position to write in the output buffer. Otherwise, the positioning operation fails. For a positioning operation to succeed, the resulting stream position must lie within the controlled sequence.  
  
## Requirements  
 **Header:** <strstream\>  
  
 **Namespace:** std  
  
## See Also  
 [strstreambuf Class](../vs140/strstreambuf-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)