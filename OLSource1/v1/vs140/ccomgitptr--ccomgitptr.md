---
title: "CComGITPtr::CComGITPtr"
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
  - "CComGITPtr.CComGITPtr"
  - "ATL.CComGITPtr<T>.CComGITPtr"
  - "CComGITPtr<T>.CComGITPtr"
  - "ATL::CComGITPtr<T>::CComGITPtr"
  - "ATL.CComGITPtr.CComGITPtr"
  - "CComGITPtr::CComGITPtr"
  - "CComGITPtr<T>::CComGITPtr"
  - "ATL::CComGITPtr::CComGITPtr"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CComGITPtr class, constructor"
  - "CComGITPtr constructor"
ms.assetid: c0b6edb2-0850-4bbd-8cce-aa6fed370ca1
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComGITPtr::CComGITPtr
The constructor.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 An interface pointer to be stored in the global interface table (GIT).  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A reference to an existing <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A cookie used to identify the interface pointer.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The source <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object to move data from.  
  
## Remarks  
 Creates a new <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object, optionally using an existing <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object.  
  
 The constructor utilizing <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is a move constructor. The data is moved from the source, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, and then <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is cleared.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CComGITPtr Class](../vs140/ccomgitptr-class.md)