---
title: "CComGITPtr::Attach"
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
  - "CComGITPtr<T>::Attach"
  - "ATL::CComGITPtr<T>::Attach"
  - "CComGITPtr::Attach"
  - "ATL.CComGITPtr<T>.Attach"
  - "CComGITPtr.Attach"
  - "CComGITPtr<T>.Attach"
  - "ATL.CComGITPtr.Attach"
  - "ATL::CComGITPtr::Attach"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Attach method [ATL]"
ms.assetid: fe5b8249-8919-409c-b9c7-1d2f799dfb0b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComGITPtr::Attach
Call this method to register the interface pointer in the global interface table (GIT).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The interface pointer to be added to the GIT.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The cookie used to identify the interface pointer.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 In debug builds, an assertion error will occur if the GIT is not valid, or if the cookie is equal to NULL.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CComGITPtr Class](../vs140/ccomgitptr-class.md)   
 [CComGITPtr::Detach](../vs140/ccomgitptr--detach.md)