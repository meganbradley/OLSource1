---
title: "strstreambuf::seekoff"
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
  - "seekoff"
  - "std.strstreambuf.seekoff"
  - "strstreambuf::seekoff"
  - "strstreambuf.seekoff"
  - "std::strstreambuf::seekoff"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "seekoff method"
ms.assetid: 90f10ae2-ecec-4396-ad99-6e0e0988f5ce
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# strstreambuf::seekoff
A protected virtual member function that tries to alter the current positions for the controlled streams.  
  
## Syntax  
  
```  
  
      virtual streampos seekoff(  
   streamoff _Off,  
   ios_base::seekdir _Way,  
   ios_base::openmode _Which = ios_base::in | ios_base::out  
);  
```  
  
#### Parameters  
 `_Off`  
 The position to seek for relative to `_Way`.  
  
 `_Way`  
 The starting point for offset operations. See [seekdir](../vs140/ios_base--seekdir.md) for possible values.  
  
 `_Which`  
 Specifies the mode for the pointer position. The default is to allow you to modify the read and write positions.  
  
## Return Value  
 If the function succeeds in altering either or both stream positions, it returns the resultant stream position. Otherwise, it fails and returns an invalid stream position.  
  
## Remarks  
 The protected virtual member function endeavors to alter the current positions for the controlled streams. For an object of class strstreambuf, a stream position consists purely of a stream offset. Offset zero designates the first element of the controlled sequence.  
  
 The new position is determined as follows:  
  
-   If `_Way` == `ios_base::beg`, the new position is the beginning of the stream plus _*Off*.  
  
-   If `_Way` == `ios_base::cur`, the new position is the current stream position plus _*Off*.  
  
-   If `_Way` == `ios_base::end`, the new position is the end of the stream plus _*Off*.  
  
 If `_Which` & **ios_base::in** is nonzero and the input buffer exist, the function alters the next position to read in the input buffer. If `_Which` & **ios_base::out** is also nonzero, `_Way` != **ios_base::cur**, and the output buffer exists, the function also sets the next position to write to match the next position to read.  
  
 Otherwise, if `_Which` & `ios_base::out` is nonzero and the output buffer exists, the function alters the next position to write in the output buffer. Otherwise, the positioning operation fails. For a positioning operation to succeed, the resulting stream position must lie within the controlled sequence.  
  
## Requirements  
 **Header:** <strstream\>  
  
 **Namespace:** std  
  
## See Also  
 [strstreambuf Class](../vs140/strstreambuf-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)