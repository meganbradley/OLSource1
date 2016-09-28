---
title: "CAutoPtr::~CAutoPtr"
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
  - "ATL::CAutoPtr<T>::~CAutoPtr"
  - "ATL::CAutoPtr::~CAutoPtr"
  - "CAutoPtr.~CAutoPtr"
  - "CAutoPtr::~CAutoPtr"
  - "ATL.CAutoPtr<T>.~CAutoPtr"
  - "CAutoPtr<T>.~CAutoPtr"
  - "ATL.CAutoPtr.~CAutoPtr"
  - "~CAutoPtr"
  - "CAutoPtr<T>::~CAutoPtr"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CAutoPtr class, destructor"
  - "~CAutoPtr destructor"
ms.assetid: e7c0da08-5f29-436c-9b06-63d83c744601
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAutoPtr::~CAutoPtr
The destructor.  
  
## Syntax  
  
```  
  
~CAutoPtr( ) throw( );  
  
```  
  
## Remarks  
 Frees any allocated resources. Calls [CAutoPtr::Free](../vs140/cautoptr--free.md).  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CAutoPtr Class](../vs140/cautoptr-class.md)   
 [CAutoPtr::CAutoPtr](../vs140/cautoptr--cautoptr.md)