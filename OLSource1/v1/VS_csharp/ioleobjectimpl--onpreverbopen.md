---
title: "IOleObjectImpl::OnPreVerbOpen"
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
  - "ATL::IOleObjectImpl<T>::OnPreVerbOpen"
  - "OnPreVerbOpen"
  - "IOleObjectImpl.OnPreVerbOpen"
  - "ATL::IOleObjectImpl::OnPreVerbOpen"
  - "ATL.IOleObjectImpl<T>.OnPreVerbOpen"
  - "ATL.IOleObjectImpl.OnPreVerbOpen"
  - "IOleObjectImpl::OnPreVerbOpen"
  - "IOleObjectImpl<T>::OnPreVerbOpen"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnPreVerbOpen method"
ms.assetid: 294aa0cb-176b-4812-9d74-4ef073003704
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IOleObjectImpl::OnPreVerbOpen
Called by [DoVerbOpen](../VS_csharp/ioleobjectimpl--doverbopen.md) before the control has been opened for editing in a separate window.  
  
## Syntax  
  
```  
  
HRESULT OnPreVerbOpen( );  
  
```  
  
## Return Value  
 Returns `S_OK`.  
  
## Remarks  
 To prevent the control from being opened for editing in a separate window, override this method to return an error HRESULT.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [IOleObjectImpl Class](../VS_csharp/ioleobjectimpl-class.md)   
 [IOleObjectImpl::DoVerbOpen](../VS_csharp/ioleobjectimpl--doverbopen.md)   
 [IOleObjectImpl::OnPostVerbOpen](../VS_csharp/ioleobjectimpl--onpostverbopen.md)