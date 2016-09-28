---
title: "basic_streambuf::seekpos"
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
  - "seekpos"
  - "streambuf/std::basic_streambuf::seekpos"
  - "basic_streambuf.seekpos"
  - "std::basic_streambuf::seekpos"
  - "basic_streambuf::seekpos"
  - "std.basic_streambuf.seekpos"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "seekpos method"
ms.assetid: ad427f8c-7be8-4af7-aebe-11184622bc97
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_streambuf::seekpos
A protected virtual member function that tries to alter the current positions for the controlled streams.  
  
## Syntax  
  
```  
  
      virtual pos  
      _  
      type seekpos(  
   pos_type _Sp,  
   ios_base::openmode _Which = ios_base::in | ios_base::out  
);  
```  
  
#### Parameters  
 `_Sp`  
 The position to seek for.  
  
 `_Which`  
 Specifies the mode for the pointer position. The default is to allow you to modify the read and write positions.  
  
## Return Value  
 The new position, or an invalid stream position. To determine if the stream position is invalid, compare the return value with `pos_type(off_type(-1))`.  
  
## Remarks  
 The new position is _*Sp*.  
  
 Typically, if **which & ios_base::in** is nonzero, the input stream is affected, and if **which & ios_base::out** is nonzero, the output stream is affected. Actual use of this parameter varies among derived stream buffers, however.  
  
 If the function succeeds in altering the stream position or positions, it returns the resulting stream position or one of the resulting stream positions. Otherwise, it returns an invalid stream position (-1). The default behavior is to return an invalid stream position.  
  
## Requirements  
 **Header:** <streambuf\>  
  
 **Namespace:** std  
  
## See Also  
 [basic_streambuf Class](../vs140/basic_streambuf-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)