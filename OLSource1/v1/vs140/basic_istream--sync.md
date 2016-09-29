---
title: "basic_istream::sync"
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
  - "std::basic_istream::sync"
  - "std.basic_istream.sync"
  - "istream/std::basic_istream::sync"
  - "basic_istream::sync"
  - "sync"
  - "basic_istream.sync"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "sync method"
ms.assetid: 35444a9c-2324-4e6d-ac34-c76c4ce7bf7e
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_istream::sync
Synchronizes the input device associated with the stream with the stream's buffer.  
  
## Syntax  
  
```  
  
int sync( );  
  
```  
  
## Return Value  
 If [rdbuf](../vs140/basic_ios--rdbuf.md) is a null pointer, the function returns -1. Otherwise, it calls `rdbuf` ->[pubsync](../vs140/basic_streambuf--pubsync.md). If that returns -1, the function calls [setstate](../vs140/basic_ios--setstate.md)(**badbit**) and returns -1. Otherwise, the function returns zero.  
  
## Requirements  
 **Header:** \<istream>  
  
 **Namespace:** std  
  
## See Also  
 [basic_istream Class](../vs140/basic_istream-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)