---
title: "IOleInPlaceObjectWindowlessImpl::InPlaceDeactivate"
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
  - "InPlaceDeactivate"
  - "IOleInPlaceObjectWindowlessImpl.InPlaceDeactivate"
  - "IOleInPlaceObjectWindowlessImpl::InPlaceDeactivate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "InPlaceDeactivate method"
ms.assetid: ed96e29d-39a1-4274-85db-d73a5bf690ca
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IOleInPlaceObjectWindowlessImpl::InPlaceDeactivate
Called by the container to deactivate an in-place active control.  
  
## Syntax  
  
```  
  
      HRESULT InPlaceDeactivate(  
   HWND* phwnd   
);  
```  
  
## Remarks  
 This method performs a full or partial deactivation depending on the state of the control. If necessary, the control's user interface is deactivated, and the control's window, if any, is destroyed. The container is notified that the control is no longer active in place. The **IOleInPlaceUIWindow** interface used by the container to negotiate menus and border space is released.  
  
 See [IOleInPlaceObject::InPlaceDeactivate](http://msdn.microsoft.com/library/windows/desktop/ms679700) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [IOleInPlaceObjectWindowlessImpl Class](../vs140/ioleinplaceobjectwindowlessimpl-class.md)   
 [CComControlBase::InPlaceActivate](../vs140/ccomcontrolbase--inplaceactivate.md)