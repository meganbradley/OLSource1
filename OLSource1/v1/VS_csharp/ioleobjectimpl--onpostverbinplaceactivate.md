---
title: "IOleObjectImpl::OnPostVerbInPlaceActivate"
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
  - "ATL::IOleObjectImpl::OnPostVerbInPlaceActivate"
  - "IOleObjectImpl::OnPostVerbInPlaceActivate"
  - "OnPostVerbInPlaceActivate"
  - "ATL.IOleObjectImpl.OnPostVerbInPlaceActivate"
  - "IOleObjectImpl.OnPostVerbInPlaceActivate"
  - "ATL::IOleObjectImpl<T>::OnPostVerbInPlaceActivate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnPostVerbInPlaceActivate method"
ms.assetid: d5de547c-80e3-4a28-9501-9e02ac52ea1e
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IOleObjectImpl::OnPostVerbInPlaceActivate
Called by [DoVerbInPlaceActivate](../VS_csharp/ioleobjectimpl--doverbinplaceactivate.md) after the control is activated in place.  
  
## Syntax  
  
```  
  
HRESULT OnPostVerbInPlaceActivate( );  
  
```  
  
## Return Value  
 Returns `S_OK`.  
  
## Remarks  
 Override this method with code you want executed after the control is activated in place.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [IOleObjectImpl Class](../VS_csharp/ioleobjectimpl-class.md)   
 [IOleObjectImpl::DoVerbInPlaceActivate](../VS_csharp/ioleobjectimpl--doverbinplaceactivate.md)   
 [IOleObjectImpl::OnPreVerbInPlaceActivate](../VS_csharp/ioleobjectimpl--onpreverbinplaceactivate.md)