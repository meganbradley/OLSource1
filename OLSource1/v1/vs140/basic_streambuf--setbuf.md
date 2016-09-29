---
title: "basic_streambuf::setbuf"
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
  - "setbuf"
  - "basic_streambuf.setbuf"
  - "std.basic_streambuf.setbuf"
  - "streambuf/std::basic_streambuf::setbuf"
  - "std::basic_streambuf::setbuf"
  - "basic_streambuf::setbuf"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "setbuf method"
ms.assetid: 6a71a3e4-e25d-44dc-8366-b6319fe84854
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_streambuf::setbuf
A protected virtual member function that performs an operation particular to each derived stream buffer.  
  
## Syntax  
  
```  
virtual basic_streambuf<Elem, Tr> *setbuf(  
    char_type *_Buffer,  
    streamsize _Count  
);  
```  
  
#### Parameters  
 `_Buffer`  
 Pointer to a buffer.  
  
 `_Count`  
 Size of the buffer.  
  
## Return Value  
 The default behavior is to return **this**.  
  
## Remarks  
 See [basic_filebuf](../vs140/basic_filebuf-class.md). `setbuf` provides an area of memory for the `streambuf` object to use. How the buffer is used in defined in the derived classes.  
  
## Requirements  
 **Header:** <streambuf\>  
  
 **Namespace:** std  
  
## See Also  
 [basic_streambuf Class](../vs140/basic_streambuf-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)