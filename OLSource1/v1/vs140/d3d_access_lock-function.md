---
title: "d3d_access_lock Function"
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
ms.assetid: aa6bd716-8adf-4164-9455-c982f4221287
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# d3d_access_lock Function
Acquire a lock on an accelerator_view for the purpose of safely performing D3D operations on resources shared with the accelerator_view. The accelerator_view and all C++ AMP resources associated with this accelerator_view internally take this lock when performing operations and will block while another thread holds the D3D access lock. This lock is non-recursive: It is undefined behavior to call this function from a thread that already holds the lock. It is undefined behavior to perform operations on the accelerator_view or any data container associated with the accelerator_view from the thread that holds the D3D access lock. See also scoped_d3d_access_lock, a RAII-style class for a scope-based D3D access lock.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The accelerator_view to lock.  
  
## Requirements  
 **Header:** amprt.h  
  
 **Namespace:** concurrency::direct3d  
  
## See Also  
 [concurrency::direct3d Namespace](../vs140/concurrency--direct3d-namespace.md)