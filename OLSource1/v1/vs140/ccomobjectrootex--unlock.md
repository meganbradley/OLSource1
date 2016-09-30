---
title: "CComObjectRootEx::Unlock"
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
  - "CComObjectRootEx::Unlock"
  - "ATL.CComObjectRootEx<ThreadModel>.Unlock"
  - "ATL::CComObjectRootEx::Unlock"
  - "CComObjectRootEx<ThreadModel>::Unlock"
  - "ATL::CComObjectRootEx<CComSingleThreadModel>::Unlock"
  - "CComObjectRootEx<CComSingleThreadModel>::Unlock"
  - "ATL.CComObjectRootEx.Unlock"
  - "CComObjectRootEx.Unlock"
  - "ATL::CComObjectRootEx<ThreadModel>::Unlock"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Unlock method"
ms.assetid: 05e82bdf-bb98-4178-a570-01485685454d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComObjectRootEx::Unlock
If the thread model is multithreaded, this method calls the Win32 API function [LeaveCriticalSection](http://msdn.microsoft.com/library/windows/desktop/ms684169), which releases ownership of the critical section object obtained through a private data member.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 To obtain ownership, the thread must call <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>. Each call to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> requires a corresponding call to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to release ownership of the critical section.  
  
 If the thread model is single-threaded, this method does nothing.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComObjectRootEx Class](../vs140/ccomobjectrootex-class.md)   
 [CComObjectRootEx::Lock](../vs140/ccomobjectrootex--lock.md)