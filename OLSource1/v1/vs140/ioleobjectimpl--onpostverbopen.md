---
title: "IOleObjectImpl::OnPostVerbOpen"
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
  - "IOleObjectImpl::OnPostVerbOpen"
  - "IOleObjectImpl.OnPostVerbOpen"
  - "ATL::IOleObjectImpl<T>::OnPostVerbOpen"
  - "ATL::IOleObjectImpl::OnPostVerbOpen"
  - "OnPostVerbOpen"
  - "ATL.IOleObjectImpl.OnPostVerbOpen"
  - "IOleObjectImpl<T>::OnPostVerbOpen"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnPostVerbOpen method"
ms.assetid: 5a1e5a83-0b62-4808-96f9-1a59ec9eea0a
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IOleObjectImpl::OnPostVerbOpen
Called by [DoVerbOpen](../vs140/ioleobjectimpl--doverbopen.md) after the control has been opened for editing in a separate window.  
  
## Syntax  
  
```  
  
HRESULT OnPostVerbOpen( );  
  
```  
  
## Return Value  
 Returns `S_OK`.  
  
## Remarks  
 Override this method with code you want executed after the control has been opened for editing in a separate window.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [IOleObjectImpl Class](../vs140/ioleobjectimpl-class.md)   
 [IOleObjectImpl::DoVerbOpen](../vs140/ioleobjectimpl--doverbopen.md)   
 [IOleObjectImpl::OnPreVerbOpen](../vs140/ioleobjectimpl--onpreverbopen.md)