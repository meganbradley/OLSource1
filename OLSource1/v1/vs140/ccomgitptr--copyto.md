---
title: "CComGITPtr::CopyTo"
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
  - "CComGITPtr.CopyTo"
  - "CComGITPtr<T>.CopyTo"
  - "ATL::CComGITPtr<T>::CopyTo"
  - "CComGITPtr<T>::CopyTo"
  - "ATL.CComGITPtr<T>.CopyTo"
  - "ATL::CComGITPtr::CopyTo"
  - "ATL.CComGITPtr.CopyTo"
  - "CComGITPtr::CopyTo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CopyTo method"
ms.assetid: 5580c156-0e69-400b-85e3-2fc77c9df16f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComGITPtr::CopyTo
Call this method to copy the interface from the global interface table (GIT) to the passed pointer.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The pointer which is to receive the interface.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 The interface from the GIT is copied to the passed pointer. The pointer must be released by the caller when it is no longer required.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CComGITPtr Class](../vs140/ccomgitptr-class.md)