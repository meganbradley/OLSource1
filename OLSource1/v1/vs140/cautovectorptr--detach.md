---
title: "CAutoVectorPtr::Detach"
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
  - "ATL.CAutoVectorPtr.Detach"
  - "ATL.CAutoVectorPtr<T>.Detach"
  - "CAutoVectorPtr<T>.Detach"
  - "CAutoVectorPtr::Detach"
  - "CAutoVectorPtr.Detach"
  - "ATL::CAutoVectorPtr::Detach"
  - "ATL::CAutoVectorPtr<T>::Detach"
  - "CAutoVectorPtr<T>::Detach"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Detach method"
ms.assetid: 1c47735c-ba10-46af-b35d-5c570375e46d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAutoVectorPtr::Detach
Call this method to release ownership of a pointer.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Returns a copy of the pointer.  
  
## Remarks  
 Releases ownership of a pointer, sets the [CAutoVectorPtr::m_p](../vs140/cautovectorptr--m_p.md) member variable to NULL, and returns a copy of the pointer. After calling **Detach**, it is up to the programmer to free any allocated resources over which the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object may have previously assumed responsibility.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CAutoVectorPtr Class](../vs140/cautovectorptr-class.md)   
 [CAutoVectorPtr::Attach](../vs140/cautovectorptr--attach.md)