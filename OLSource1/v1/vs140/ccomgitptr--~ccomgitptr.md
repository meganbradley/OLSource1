---
title: "CComGITPtr::~CComGITPtr"
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
  - "~CComGITPtr"
  - "CComGITPtr<T>.~CComGITPtr"
  - "ATL::CComGITPtr::~CComGITPtr"
  - "CComGITPtr<T>::~CComGITPtr"
  - "CComGITPtr.~CComGITPtr"
  - "ATL::CComGITPtr<T>::~CComGITPtr"
  - "ATL.CComGITPtr.~CComGITPtr"
  - "ATL.CComGITPtr<T>.~CComGITPtr"
  - "CComGITPtr::~CComGITPtr"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "~CComGITPtr destructor"
  - "CComGITPtr class, destructor"
ms.assetid: 272c818d-4d89-4107-a0af-fc0a93780a26
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComGITPtr::~CComGITPtr
The destructor.  
  
## Syntax  
  
```  
  
~CComGITPtr( ) throw( );  
  
```  
  
## Remarks  
 Removes the interface from the global interface table (GIT), using [CComGITPtr::Revoke](../vs140/ccomgitptr--revoke.md).  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CComGITPtr Class](../vs140/ccomgitptr-class.md)