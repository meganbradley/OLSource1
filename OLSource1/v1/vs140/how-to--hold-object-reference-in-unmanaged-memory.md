---
title: "How to: Hold Object Reference in Unmanaged Memory"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "get-started-article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "object references, in native functions"
  - "objects [C++], reference in native functions"
  - "references, to objects in native functions"
  - "gcroot keyword [C++], object reference in native function"
ms.assetid: a61eb8ce-3982-477d-8d3d-2173fd57166d
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Hold Object Reference in Unmanaged Memory
You can use gcroot.h, which wraps \<xref:System.Runtime.InteropServices.GCHandle*>, to hold a CLR object reference in unmanaged memory. Alternatively, you can use <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> directly.  
  
## Example  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **StringWrapper::x == ManagedString**   
## Example  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> gives you a means to hold a managed object reference in unmanaged memory.  You use the \<xref:System.Runtime.InteropServices.GCHandle.Alloc*> method to create an opaque handle to a managed object and \<xref:System.Runtime.InteropServices.GCHandle.Free*> to release it. Also, the \<xref:System.Runtime.InteropServices.GCHandle.Target*> method allows you to obtain the object reference back from the handle in managed code.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **StringWrapper::m_handle == ManagedString**   
## See Also  
 [Using C++ Interop Features](../vs140/using-c---interop--implicit-pinvoke-.md)