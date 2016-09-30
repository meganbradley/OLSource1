---
title: "CComObjectRootEx::InternalRelease"
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
  - "CComObjectRootEx::InternalRelease"
  - "ATL::CComObjectRootEx<ThreadModel>::InternalRelease"
  - "ATL::CComObjectRootEx<CComSingleThreadModel>::InternalRelease"
  - "ATL.CComObjectRootEx.InternalRelease"
  - "CComObjectRootEx.InternalRelease"
  - "ATL::CComObjectRootEx::InternalRelease"
  - "InternalRelease"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "InternalRelease method"
ms.assetid: dc3af62d-9eb9-4f15-86a4-aaa79843f050
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComObjectRootEx::InternalRelease
Decrements the reference count of a nonaggregated object by 1.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 In both non-debug and debug builds, this function returns a value which may be useful for diagnostics or testing. The exact value returned depends on many factors such as the operating system used, and may, or may not, be the reference count.  
  
## Remarks  
 If the thread model is multithreaded, **InterlockedDecrement** is used to prevent more than one thread from changing the reference count at the same time.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComObjectRootEx Class](../vs140/ccomobjectrootex-class.md)   
 [CComObjectRootEx::InternalAddRef](../vs140/ccomobjectrootex--internaladdref.md)   
 [InterlockedDecrement](http://msdn.microsoft.com/library/windows/desktop/ms683580)