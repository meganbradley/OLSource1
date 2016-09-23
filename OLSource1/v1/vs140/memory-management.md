---
title: "Memory Management"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - C++
helpviewer_keywords: 
  - memory
  - MFC, memory management
  - memory allocation
  - memory, managing
  - memory allocation, MFC
ms.assetid: 934ac81b-d630-4232-88e5-ea74f7187987
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Memory Management
This group of articles describes how to take advantage of the general-purpose services of the Microsoft Foundation Class Library (MFC) related to memory management. Memory allocation can be divided into two main categories: frame allocations and heap allocations.  
  
 One main difference between the two allocation techniques is that with frame allocation you typically work with the actual memory block itself, while with heap allocation you are always given a pointer to the memory block. Another major difference between the two schemes is that frame objects are automatically deleted, while heap objects must be explicitly deleted by the programmer.  
  
 For non-MFC information about memory management in programs for Windows, see [Memory Management](http://msdn.microsoft.com/library/windows/desktop/aa366779) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## What do you want to know more about?  
  
-   [Frame allocation](../vs140/memory-management--frame-allocation.md)  
  
-   [Heap allocation](../vs140/memory-management--heap-allocation.md)  
  
-   [Allocating memory for an array](../vs140/memory-management--examples.md)  
  
-   [Deallocating memory for an array from the heap](../vs140/memory-management--examples.md)  
  
-   [Allocating memory for a data structure](../vs140/memory-management--examples.md)  
  
-   [Allocating memory for an object](../vs140/memory-management--examples.md)  
  
-   [Resizable memory blocks](../vs140/memory-management--resizable-memory-blocks.md)  
  
## See Also  
 [Concepts](../vs140/mfc-concepts.md)   
 [General MFC Topics](../vs140/general-mfc-topics.md)