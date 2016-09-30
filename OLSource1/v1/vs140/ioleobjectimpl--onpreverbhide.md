---
title: "IOleObjectImpl::OnPreVerbHide"
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
  - "ATL.IOleObjectImpl.OnPreVerbHide"
  - "IOleObjectImpl::OnPreVerbHide"
  - "OnPreVerbHide"
  - "ATL::IOleObjectImpl<T>::OnPreVerbHide"
  - "ATL.IOleObjectImpl<T>.OnPreVerbHide"
  - "IOleObjectImpl<T>::OnPreVerbHide"
  - "IOleObjectImpl.OnPreVerbHide"
  - "ATL::IOleObjectImpl::OnPreVerbHide"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnPreVerbHide method"
ms.assetid: 5536c2c4-c0c9-4c99-8474-c00db6301519
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IOleObjectImpl::OnPreVerbHide
Called by [DoVerbHide](../vs140/ioleobjectimpl--doverbhide.md) before the control is hidden.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Returns <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Remarks  
 To prevent the control from being hidden, override this method to return an error HRESULT.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [IOleObjectImpl Class](../vs140/ioleobjectimpl-class.md)   
 [IOleObjectImpl::DoVerbHide](../vs140/ioleobjectimpl--doverbhide.md)   
 [IOleObjectImpl::OnPostVerbHide](../vs140/ioleobjectimpl--onpostverbhide.md)