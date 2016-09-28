---
title: "istrstream::istrstream"
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
  - "istrstream"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "istrstream method"
  - "istrstream class, constructor"
ms.assetid: fccaf0fa-7769-47f9-9884-7a286a61a130
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# istrstream::istrstream
Constructs an object of type `istrstream`.  
  
## Syntax  
  
```  
explicit istrstream(  
    const char *_Ptr  
);  
explicit istrstream(  
    char *_Ptr  
);  
istrstream(  
    const char *_Ptr,   
    streamsize _Count  
);  
istrstream(  
    char *_Ptr,   
    int _Count  
);  
```  
  
#### Parameters  
 `_Count`  
 The length of the buffer (`_Ptr`).  
  
 `_Ptr`  
 The contents with which the buffer is initialized.  
  
## Remarks  
 All the constructors initialize the base class by calling [istream](../vs140/istream.md)(**sb**), where **sb** is the stored object of class [strstreambuf](../vs140/strstreambuf-class.md). The first two constructors also initialize **sb** by calling `strstreambuf`( (**const** `char` \*)`_Ptr`, 0 ). The remaining two constructors instead call `strstreambuf`( (**const** `char` *)`_Ptr`, `_Count` ).  
  
## Requirements  
 **Header:** <strstream\>  
  
 **Namespace:** std  
  
## See Also  
 [istrstream Class](../vs140/istrstream-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)