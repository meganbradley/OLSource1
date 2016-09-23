---
title: "basic_streambuf::xsputn"
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
  - xsputn
  - basic_streambuf::xsputn
  - std::basic_streambuf::xsputn
  - basic_streambuf.xsputn
  - streambuf/std::basic_streambuf::xsputn
  - std.basic_streambuf.xsputn
dev_langs: 
  - C++
helpviewer_keywords: 
  - xsputn method
ms.assetid: af19c1ab-c406-420d-9eac-b3f04317709c
caps.latest.revision: 17
translation.priority.ht: 
  - de-de
  - ja-jp
---
# basic_streambuf::xsputn
Protected, virtual function to insert elements into the output stream.  
  
## Syntax  
  
```  
  
      virtual streamsize xsputn(  
   const char_type *_Ptr,  
   streamsize _Count  
);  
```  
  
#### Parameters  
 `_Ptr`  
 Pointer to elements to insert.  
  
 `_Count`  
 Number of elements to insert.  
  
## Return Value  
 The number of elements actually inserted into the stream.  
  
## Remarks  
 The protected virtual member function inserts up to `_Count` elements into the output stream, as if by repeated calls to [sputc](../vs140/basic_streambuf--sputc.md), from the array beginning at `_Ptr`. The insertion of characters into the output stream stops once all `_Count` characters have been written, or if calling `sputc(_Count)` would return `traits::eof()`. It returns the number of elements actually inserted.  
  
## Requirements  
 **Header:** <streambuf\>  
  
 **Namespace:** std  
  
## See Also  
 [basic_streambuf Class](../vs140/basic_streambuf-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)