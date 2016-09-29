---
title: "Memory Management with CStringT"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "CStringT"
  - "ATL::CStringT"
  - "ATL.CStringT"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CString objects, memory management"
  - "memory [C++], usage"
  - "IAtlStringMgr class, using"
  - "strings [C++], custom memory management"
  - "CFixedStringT class, description of"
  - "strings [C++], memory management"
  - "CStringT class, memory management"
ms.assetid: 88b8342d-19b5-48c4-9cf6-e4c44cece21e
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Memory Management with CStringT
Class [CStringT](../vs140/cstringt-class.md) is a template class used to manipulate variable-length character strings. The memory to hold these strings is allocated and released through a string manager object, associated with each instance of `CStringT`. MFC and ATL provide default instantiations of `CStringT`, called `CString`, `CStringA`, and `CStringW`, which manipulate strings of different character types. These character types are of type **TCHAR**, `char`, and `wchar_t`, respectively. These default string types use a string manager that allocates memory from the process heap (in ATL) or the CRT heap (in MFC). For typical applications, this memory allocation scheme is sufficient. However, for code making intensive use of strings (or multithreaded code) the default memory managers may not perform optimally. This topic describes how to override the default memory management behavior of `CStringT`, creating allocators specifically optimized for the task at hand.  
  
-   [Implementation of a Custom String Manager (Basic Method)](../vs140/implementation-of-a-custom-string-manager--basic-method-.md)  
  
-   [Avoidance of Heap Contention](../vs140/avoidance-of-heap-contention.md)  
  
-   [Implementation of a Custom String Manager (Advanced Method)](../vs140/implementation-of-a-custom-string-manager--advanced-method-.md)  
  
-   [CFixedStringT: An Example of a Custom String Manager](../vs140/cfixedstringt--example-of-a-custom-string-manager.md)  
  
## See Also  
 [CustomString sample](../vs140/visual-c---samples.md)