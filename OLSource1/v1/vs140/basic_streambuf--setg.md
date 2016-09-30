---
title: "basic_streambuf::setg"
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
  - "basic_streambuf::setg"
  - "setg"
  - "std::basic_streambuf::setg"
  - "streambuf/std::basic_streambuf::setg"
  - "std.basic_streambuf.setg"
  - "SetG"
  - "basic_streambuf.setg"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "setg method"
ms.assetid: 1c5dd011-dd7c-4808-9688-ee75d0f1c84b
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_streambuf::setg
A protected function that stores _*Gbeg* in the beginning pointer, `_Gnext` in the next pointer, and `_Gend` in the end pointer for the input buffer.  
  
## Syntax  
  
```  
  
      void setg(  
   char_type *_Gbeg,  
   char_type *_Gnext,  
   char_type *_Gend  
);  
```  
  
#### Parameters  
 *_Gbeg*  
 A pointer to the beginning of the buffer.  
  
 `_Gnext`  
 A pointer to somewhere in the middle of the buffer.  
  
 `_Gend`  
 A pointer to the end of the buffer.  
  
## Requirements  
 **Header:** \<streambuf>  
  
 **Namespace:** std  
  
## See Also  
 [basic_streambuf Class](../vs140/basic_streambuf-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)