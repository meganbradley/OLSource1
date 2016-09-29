---
title: "IOleObjectImpl::OnPreVerbInPlaceActivate"
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
  - "OnPreVerbInPlaceActivate"
  - "ATL::IOleObjectImpl::OnPreVerbInPlaceActivate"
  - "ATL.IOleObjectImpl.OnPreVerbInPlaceActivate"
  - "IOleObjectImpl.OnPreVerbInPlaceActivate"
  - "ATL::IOleObjectImpl<T>::OnPreVerbInPlaceActivate"
  - "IOleObjectImpl::OnPreVerbInPlaceActivate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnPreVerbInPlaceActivate method"
ms.assetid: 854be84e-85be-4a38-95a9-927d44a3b5f5
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IOleObjectImpl::OnPreVerbInPlaceActivate
Called by [DoVerbInPlaceActivate](../VS_csharp/ioleobjectimpl--doverbinplaceactivate.md) before the control is activated in place.  
  
## Syntax  
  
```  
  
HRESULT OnPreVerbInPlaceActivate( );  
  
```  
  
## Return Value  
 Returns `S_OK`.  
  
## Remarks  
 To prevent the control from being activated in place, override this method to return an error HRESULT.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [IOleObjectImpl Class](../VS_csharp/ioleobjectimpl-class.md)   
 [IOleObjectImpl::DoVerbInPlaceActivate](../VS_csharp/ioleobjectimpl--doverbinplaceactivate.md)   
 [IOleObjectImpl::OnPostVerbInPlaceActivate](../VS_csharp/ioleobjectimpl--onpostverbinplaceactivate.md)