---
title: "IOleInPlaceObjectWindowlessImpl::OnWindowMessage"
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
  - "IOleInPlaceObjectWindowlessImpl.OnWindowMessage"
  - "OnWindowMessage"
  - "IOleInPlaceObjectWindowlessImpl::OnWindowMessage"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnWindowMessage method"
ms.assetid: 400b2b20-51f0-414c-a436-031431887c68
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IOleInPlaceObjectWindowlessImpl::OnWindowMessage
Dispatches a message from a container to a windowless control that is in-place active.  
  
## Syntax  
  
```  
  
      HRESULT OnWindowMessage(  
   UINT msg,  
   WPARAM WParam,  
   LPARAM LParam,  
   LRESULT plResultParam   
);  
```  
  
## Remarks  
 See [IOleInPlaceObjectWindowless::OnWindowMessage](http://msdn.microsoft.com/library/windows/desktop/ms693783) in the [!INCLUDE[winSDK](../VS_csharp/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [IOleInPlaceObjectWindowlessImpl Class](../VS_csharp/ioleinplaceobjectwindowlessimpl-class.md)