---
title: "Implementation of a Custom String Manager (Basic Method)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
dev_langs: 
  - C++
helpviewer_keywords: 
  - IAtlStringMgr class, using
ms.assetid: eac5d13e-cbb4-4e82-b01e-f5f2dbcb962a
caps.latest.revision: 14
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Implementation of a Custom String Manager (Basic Method)
The easiest way to customize the memory allocation scheme for string data is to use the ATL-provided **CAtlStringMgr** class but provide your own memory allocation routines. The constructor for **CAtlStringMgr** takes a single parameter: a pointer to an `IAtlMemMgr` object. `IAtlMemMgr` is an abstract base class that provides a generic interface to a heap. Using the `IAtlMemMgr` interface, the **CAtlStringMgr** allocates, reallocates, and frees the memory used to store string data. You can either implement the `IAtlMemMgr` interface yourself, or use one of the five ATL-provided memory manager classes. The ATL-provided memory managers simply wrap existing memory allocation facilities:  
  
-   [CCRTHeap](../vs140/ccrtheap-class.md) Wraps the standard CRT heap functions ([malloc](../vs140/malloc.md), [free](../vs140/free.md), and [realloc](../vs140/realloc.md))  
  
-   [CWin32Heap](../vs140/cwin32heap-class.md) Wraps a Win32 heap handle, using [HeapAlloc](http://msdn.microsoft.com/library/windows/desktop/aa366597), [HeapFree](http://msdn.microsoft.com/library/windows/desktop/aa366701), and [HeapRealloc](http://msdn.microsoft.com/library/windows/desktop/aa366704)  
  
-   [CLocalHeap](../vs140/clocalheap-class.md) Wraps the Win32 APIs: [LocalAlloc](http://msdn.microsoft.com/library/windows/desktop/aa366723), [LocalFree](http://msdn.microsoft.com/library/windows/desktop/aa366730), and [LocalRealloc](http://msdn.microsoft.com/library/windows/desktop/aa366742)  
  
-   [CGlobalHeap](../vs140/cglobalheap-class.md) Wraps the Win32 APIs: [GlobalAlloc](http://msdn.microsoft.com/library/windows/desktop/aa366574), [GlobalFree](http://msdn.microsoft.com/library/windows/desktop/aa366579), and [GlobalRealloc](http://msdn.microsoft.com/library/windows/desktop/aa366590).  
  
-   [CComHeap](../vs140/ccomheap-class.md) Wraps the COM Task Allocator APIs: [CoTaskMemAlloc](http://msdn.microsoft.com/library/windows/desktop/ms692727), [CoTaskMemFree](http://msdn.microsoft.com/library/windows/desktop/ms680722), and [CoTaskMemRealloc](http://msdn.microsoft.com/library/windows/desktop/ms687280)  
  
 For the purpose of string memory management, the most useful class is `CWin32Heap` because it allows you to create multiple independent heaps. For example, if you wanted to use a separate heap just for strings, you could do the following:  
  
 [!code[NVC_ATLMFC_Utilities#180](../vs140/codesnippet/CPP/implementation-of-a-custom-string-manager--basic-method-_1.cpp)]
  
  
 To use this private string manager to manage memory for a `CString` variable, pass a pointer to the manager as a parameter to the `CString` variable's constructor:  
  
 [!code[NVC_ATLMFC_Utilities#181](../vs140/codesnippet/CPP/implementation-of-a-custom-string-manager--basic-method-_2.cpp)]
  
  
## See Also  
 [Memory Management with CStringT](../vs140/memory-management-with-cstringt.md)