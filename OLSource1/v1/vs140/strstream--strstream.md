---
title: "strstream::strstream"
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
  - "strstream.strstream"
  - "strstream::strstream"
  - "std.strstream.strstream"
  - "std::strstream::strstream"
  - "strstream"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "strstream class, constructor"
  - "strstream method"
ms.assetid: 3cc2cb49-a017-458f-9810-3c73d009317a
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# strstream::strstream
Constructs an object of type `strstream`.  
  
## Syntax  
  
```  
  
      strstream( );  
strstream(  
   char *_Ptr,   
   streamsize _Count,  
   ios_base::openmode _Mode = ios_base::in | ios_base::out  
);  
```  
  
#### Parameters  
 `_Count`  
 The size of the buffer.  
  
 `_Mode`  
 The input and output mode of the buffer. See [ios_base::openmode](../vs140/ios_base--openmode.md) for more information.  
  
 `_Ptr`  
 The buffer.  
  
## Remarks  
 Both constructors initialize the base class by calling [streambuf](../vs140/streambuf.md)(**sb**), where **sb** is the stored object of class [strstreambuf](../vs140/strstreambuf-class.md). The first constructor also initializes **sb** by calling [strstreambuf](../vs140/strstreambuf--strstreambuf.md). The second constructor initializes the base class one of two ways:  
  
-   If `_Mode` & **ios_base::app**== 0, then `_Ptr` must designate the first element of an array of `_Count` elements, and the constructor calls `strstreambuf`(`_Ptr`, `_Count`, `_Ptr`).  
  
-   Otherwise, `_Ptr` must designate the first element of an array of count elements that contains a C string whose first element is designated by `_Ptr`, and the constructor calls `strstreambuf`( `_Ptr`, `_Count`, `_Ptr` + `strlen`(`_Ptr`) ).  
  
## Requirements  
 **Header:** \<strstream>  
  
 **Namespace:** std  
  
## See Also  
 [strstream Class](../vs140/strstream-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)