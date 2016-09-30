---
title: "basic_streambuf::setp"
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
  - "basic_streambuf.setp"
  - "setp"
  - "std::basic_streambuf::setp"
  - "SetP"
  - "std.basic_streambuf.setp"
  - "streambuf/std::basic_streambuf::setp"
  - "basic_streambuf::setp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "setp method"
ms.assetid: 6f7d82cb-6410-4c3b-bb6c-e66eb875d915
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_streambuf::setp
A protected function that stores `_Pbeg` in the beginning pointer and `_Pend` in the end pointer for the output buffer.  
  
## Syntax  
  
```  
  
      void setp(  
   char_type *_Pbeg,  
   char_type *_Pend  
);  
```  
  
#### Parameters  
 `_Pbeg`  
 A pointer to the beginning of the buffer.  
  
 `_Pend`  
 A pointer to the end of the buffer.  
  
## Requirements  
 **Header:** \<streambuf>  
  
 **Namespace:** std  
  
## See Also  
 [basic_streambuf Class](../vs140/basic_streambuf-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)