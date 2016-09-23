---
title: "fpos::fpos"
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
  - std.fpos.fpos
  - iosfwd/std::fpos::fpos
  - fpos::fpos
  - fpos.fpos
  - fpos
  - std::fpos::fpos
dev_langs: 
  - C++
helpviewer_keywords: 
  - fpos method
  - fpos class, constructor
ms.assetid: e0d7e379-3bf2-47a2-a0a0-de1dcde47889
caps.latest.revision: 16
translation.priority.ht: 
  - de-de
  - ja-jp
---
# fpos::fpos
Create an object that contains information about a position (offset) in a stream.  
  
## Syntax  
  
```  
  
      fpos(  
   streamoff _Off=0  
);  
fpos(  
   Statetype _State,  
   fpos_t _Filepos  
);  
```  
  
#### Parameters  
 `_Off`  
 The offset into the stream.  
  
 `_State`  
 The starting state of the `fpos` object.  
  
 *_Filepos*  
 The offset into the stream.  
  
## Remarks  
 The first constructor stores the offset `_Off`, relative to the beginning of file and in the initial conversion state (if that matters). If `_Off` is -1, the resulting object represents an invalid stream position.  
  
 The second constructor stores a zero offset and the object `_State`.  
  
## Requirements  
 **Header:** <ios\>  
  
 **Namespace:** std  
  
## See Also  
 [fpos Class](../vs140/fpos-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)