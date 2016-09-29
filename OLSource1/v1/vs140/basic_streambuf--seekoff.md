---
title: "basic_streambuf::seekoff"
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
  - "basic_streambuf::seekoff"
  - "streambuf/std::basic_streambuf::seekoff"
  - "std::basic_streambuf::seekoff"
  - "std.basic_streambuf.seekoff"
  - "basic_streambuf.seekoff"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "seekoff method"
ms.assetid: 0b5dbbd5-3442-46a3-a429-01bab3151344
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_streambuf::seekoff
A protected virtual member function that tries to alter the current positions for the controlled streams.  
  
## Syntax  
  
```  
virtual pos_type seekoff(  
    off_type _Off,  
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
 Returns the new position or an invalid stream position ( `seekoff` (_*Off*, `_Way`, `_Which`) ).  
  
## Remarks  
 The new position is determined as follows:  
  
-   If `_Way` == `ios_base::beg`, the new position is the beginning of the stream plus _*Off*.  
  
-   If `_Way` == `ios_base::cur`, the new position is the current stream position plus _*Off*.  
  
-   If `_Way` == `ios_base::end`, the new position is the end of the stream plus _*Off*.  
  
 Typically, if **which & ios_base::in** is nonzero, the input stream is affected, and if **which & ios_base::out** is nonzero, the output stream is affected. Actual use of this parameter varies among derived stream buffers, however.  
  
 If the function succeeds in altering the stream position or positions, it returns the resulting stream position or one of the resulting stream positions. Otherwise, it returns an invalid stream position. The default behavior is to return an invalid stream position.  
  
## Requirements  
 **Header:** <streambuf\>  
  
 **Namespace:** std  
  
## See Also  
 [basic_streambuf Class](../vs140/basic_streambuf-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)