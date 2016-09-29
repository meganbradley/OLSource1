---
title: "IOleObjectImpl::OnPostVerbUIActivate"
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
  - "ATL::IOleObjectImpl<T>::OnPostVerbUIActivate"
  - "IOleObjectImpl::OnPostVerbUIActivate"
  - "ATL.IOleObjectImpl.OnPostVerbUIActivate"
  - "ATL::IOleObjectImpl::OnPostVerbUIActivate"
  - "IOleObjectImpl.OnPostVerbUIActivate"
  - "OnPostVerbUIActivate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnPostVerbUIActivate method"
ms.assetid: baab8f7c-2afd-472b-8076-80275b618af4
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IOleObjectImpl::OnPostVerbUIActivate
Called by [DoVerbUIActivate](../VS_csharp/ioleobjectimpl--doverbuiactivate.md) after the control's user interface has been activated.  
  
## Syntax  
  
```  
  
HRESULT OnPostVerbUIActivate( );  
  
```  
  
## Return Value  
 Returns `S_OK`.  
  
## Remarks  
 Override this method with code you want executed after the control's user interface has been activated.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [IOleObjectImpl Class](../VS_csharp/ioleobjectimpl-class.md)   
 [IOleObjectImpl::DoVerbUIActivate](../VS_csharp/ioleobjectimpl--doverbuiactivate.md)   
 [IOleObjectImpl::OnPreVerbUIActivate](../VS_csharp/ioleobjectimpl--onpreverbuiactivate.md)