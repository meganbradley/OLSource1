---
title: "ostrstream::ostrstream"
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
  - "ostrstream"
  - "std.ostrstream.ostrstream"
  - "ostrstream.ostrstream"
  - "std::ostrstream::ostrstream"
  - "ostrstream::ostrstream"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ostrstream method"
  - "ostrstream class, constructor"
ms.assetid: 40712f12-47db-4353-9b8f-e2ca7169e8da
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ostrstream::ostrstream
Constructs an object of type `ostrstream`.  
  
## Syntax  
  
```  
  
      ostrstream( );  
ostrstream(  
   char *_Ptr,   
   streamsize _Count,  
   ios_base::openmode _Mode = ios_base::out  
);  
```  
  
#### Parameters  
 `_Ptr`  
 The buffer.  
  
 `_Count`  
 The size of the buffer in bytes.  
  
 `_Mode`  
 The input and output mode of the buffer. See [ios_base::openmode](../vs140/ios_base--openmode.md) for more information.  
  
## Remarks  
 Both constructors initialize the base class by calling [ostream](../vs140/ostream.md)(**sb**), where **sb** is the stored object of class [strstreambuf](../vs140/strstreambuf-class.md). The first constructor also initializes **sb** by calling `strstreambuf`. The second constructor initializes the base class one of two ways:  
  
-   If `_Mode` & **ios_base::app**== 0, then `_Ptr` must designate the first element of an array of `_Count` elements, and the constructor calls `strstreambuf`(`_Ptr`, `_Count`, `_Ptr`).  
  
-   Otherwise, `_Ptr` must designate the first element of an array of count elements that contains a C string whose first element is designated by `_Ptr`, and the constructor calls `strstreambuf`( `_Ptr`, `_Count`, `_Ptr` + `strlen`(`_Ptr`) ).  
  
## Requirements  
 **Header:** <strstream\>  
  
 **Namespace:** std  
  
## See Also  
 [ostrstream Class](../vs140/ostrstream-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)