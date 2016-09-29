---
title: "basic_streambuf::pubseekoff"
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
  - "basic_streambuf.pubseekoff"
  - "pubseekoff"
  - "streambuf/std::basic_streambuf::pubseekoff"
  - "basic_streambuf::pubseekoff"
  - "std::basic_streambuf::pubseekoff"
  - "std.basic_streambuf.pubseekoff"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "pubseekoff method"
ms.assetid: 65ac5c75-512e-4d59-ba2f-6741b821c534
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_streambuf::pubseekoff
Calls [seekoff](../vs140/basic_streambuf--seekoff.md), a protected virtual function that is overridden in a derived class.  
  
## Syntax  
  
```  
  
      pos  
      _  
      type pubseekoff(  
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
 Returns the new position or an invalid stream position ( [seekoff](../vs140/basic_streambuf--seekoff.md)(_*Off*, `_Way`, `_Which`) ).  
  
## Remarks  
 Moves the pointer relative to `_Way`.  
  
## Requirements  
 **Header:** <streambuf\>  
  
 **Namespace:** std  
  
## See Also  
 [basic_streambuf Class](../vs140/basic_streambuf-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)