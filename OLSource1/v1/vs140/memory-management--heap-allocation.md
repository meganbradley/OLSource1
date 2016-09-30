---
title: "Memory Management: Heap Allocation"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "memory, detecting leaks"
  - "delete operator, using with debug MFC"
  - "heap allocation, described"
  - "memory allocation, heap memory"
  - "memory leaks, detecting"
  - "new operator, using with debug MFC"
  - "heap allocation"
  - "detecting memory leaks"
ms.assetid: a5d949c6-1b79-476e-9c66-513a558203d9
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Memory Management: Heap Allocation
The heap is reserved for the memory allocation needs of the program. It is an area apart from the program code and the stack. Typical C programs use the functions <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> and **free** to allocate and deallocate heap memory. The Debug version of MFC provides modified versions of the C++ built-in operators **new** and **delete** to allocate and deallocate objects in heap memory.  
  
 When you use **new** and **delete** instead of <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> and **free**, you are able to take advantage of the class library's memory-management debugging enhancements, which can be useful in detecting memory leaks. When you build your program with the Release version of MFC, the standard versions of the **new** and **delete** operators provide an efficient way to allocate and deallocate memory (the Release version of MFC does not provide modified versions of these operators).  
  
 Note that the total size of objects allocated on the heap is limited only by your system's available virtual memory.  
  
## See Also  
 [Memory Management](../vs140/memory-management.md)