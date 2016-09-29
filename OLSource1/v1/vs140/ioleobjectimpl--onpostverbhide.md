---
title: "IOleObjectImpl::OnPostVerbHide"
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
  - "ATL.IOleObjectImpl.OnPostVerbHide"
  - "IOleObjectImpl<T>::OnPostVerbHide"
  - "IOleObjectImpl::OnPostVerbHide"
  - "OnPostVerbHide"
  - "ATL::IOleObjectImpl<T>::OnPostVerbHide"
  - "ATL::IOleObjectImpl::OnPostVerbHide"
  - "IOleObjectImpl.OnPostVerbHide"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnPostVerbHide method"
ms.assetid: b866d1a6-597b-4321-bc7c-24bd7993766c
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IOleObjectImpl::OnPostVerbHide
Called by [DoVerbHide](../vs140/ioleobjectimpl--doverbhide.md) after the control is hidden.  
  
## Syntax  
  
```  
  
HRESULT OnPostVerbHide( );  
  
```  
  
## Return Value  
 Returns `S_OK`.  
  
## Remarks  
 Override this method with code you want executed after the control is hidden.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [IOleObjectImpl Class](../vs140/ioleobjectimpl-class.md)   
 [IOleObjectImpl::DoVerbHide](../vs140/ioleobjectimpl--doverbhide.md)   
 [IOleObjectImpl::OnPreVerbHide](../vs140/ioleobjectimpl--onpreverbhide.md)