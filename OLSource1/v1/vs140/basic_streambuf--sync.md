---
title: "basic_streambuf::sync"
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
  - "streambuf/std::basic_streambuf::sync"
  - "std::basic_streambuf::sync"
  - "basic_streambuf.sync"
  - "std.basic_streambuf.sync"
  - "sync"
  - "basic_streambuf::sync"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "sync method"
ms.assetid: 2d4d5e69-cc0e-421c-960a-c37a383c138a
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_streambuf::sync
A protected virtual function that tries to synchronize the controlled streams with any associated external streams.  
  
## Syntax  
  
```  
  
virtual int sync( );  
  
```  
  
## Return Value  
 If the function cannot succeed, it returns -1. The default behavior is to return zero.  
  
## Remarks  
 `sync` involves writing out any elements between the beginning and next pointers for the output buffer. It does not involve putting back any elements between the next and end pointers for the input buffer.  
  
## Requirements  
 **Header:** \<streambuf>  
  
 **Namespace:** std  
  
## See Also  
 [basic_streambuf Class](../vs140/basic_streambuf-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)