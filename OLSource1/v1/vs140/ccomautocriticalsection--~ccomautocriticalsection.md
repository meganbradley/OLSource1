---
title: "CComAutoCriticalSection::~CComAutoCriticalSection"
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
  - "ATL::CComAutoCriticalSection::~CComAutoCriticalSection"
  - "ATL.CComAutoCriticalSection.~CComAutoCriticalSection"
  - "CComAutoCriticalSection::~CComAutoCriticalSection"
  - "CComAutoCriticalSection.~CComAutoCriticalSection"
  - "~CComAutoCriticalSection"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "~CComAutoCriticalSection destructor"
  - "CComAutoCriticalSection class, destructor"
ms.assetid: 0930b19d-3b16-4dfd-892e-c002465d08e7
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComAutoCriticalSection::~CComAutoCriticalSection
The destructor.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The destructor calls [DeleteCriticalSection](http://msdn.microsoft.com/library/windows/desktop/ms682552), which releases all system resources used by the critical section object.  
  
## Requirements  
 **Header:** atlcore.h  
  
## See Also  
 [CComAutoCriticalSection Class](../vs140/ccomautocriticalsection-class.md)   
 [CComAutoCriticalSection::CComAutoCriticalSection](../vs140/ccomautocriticalsection--ccomautocriticalsection.md)