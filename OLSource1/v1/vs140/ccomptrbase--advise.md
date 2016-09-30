---
title: "CComPtrBase::Advise"
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
  - "ATL.CComPtrBase.Advise"
  - "CComPtrBase::Advise"
  - "CComPtrBase.Advise"
  - "CComPtrBase<T>.Advise"
  - "ATL.CComPtrBase<T>.Advise"
  - "Advise"
  - "CComPtrBase<T>::Advise"
  - "ATL::CComPtrBase::Advise"
  - "ATL::CComPtrBase<T>::Advise"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Advise method [ATL]"
ms.assetid: c5828188-639b-44f3-b7cf-c923a6910d4e
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComPtrBase::Advise
Call this method to create a connection between the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>'s connection point and a client's sink.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *pUnk*  
 A pointer to the client's **IUnknown**.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The GUID of the connection point. Typically, this is the same as the outgoing interface managed by the connection point.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to the cookie that uniquely identifies the connection.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 See [AtlAdvise](../vs140/atladvise.md) for more information.  
  
## Requirements  
 **Header:** atlcomcli.h  
  
## See Also  
 [CComPtrBase Class](../vs140/ccomptrbase-class.md)