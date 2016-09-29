---
title: "IOleObjectImpl::DoVerbUIActivate"
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
  - "ATL.IOleObjectImpl.DoVerbUIActivate"
  - "IOleObjectImpl.DoVerbUIActivate"
  - "ATL::IOleObjectImpl::DoVerbUIActivate"
  - "ATL::IOleObjectImpl<T>::DoVerbUIActivate"
  - "IOleObjectImpl<T>::DoVerbUIActivate"
  - "DoVerbUIActivate"
  - "IOleObjectImpl::DoVerbUIActivate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DoVerbUIActivate method"
ms.assetid: bc05755f-8934-49b7-a862-77a3a0eadef9
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IOleObjectImpl::DoVerbUIActivate
Activates the control's user interface and notifies the container that its menus are being replaced by composite menus.  
  
## Syntax  
  
```  
  
      HRESULT DoVerbUIActivate(  
   LPCRECT prcPosRect,  
   HWND /* hwndParent */  
);  
```  
  
#### Parameters  
 `prcPosRec`  
 [in] Pointer to the rectangle the container wants the control to draw into.  
  
 *hwndParent*  
 [in] Handle of the window containing the control. Not used in the ATL implementation.  
  
## Return Value  
 One of the standard `HRESULT` values.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [IOleObjectImpl Class](../vs140/ioleobjectimpl-class.md)   
 [CComControlBase::InPlaceActivate](../vs140/ccomcontrolbase--inplaceactivate.md)   
 [IOleObjectImpl::DoVerbInPlaceActivate](../vs140/ioleobjectimpl--doverbinplaceactivate.md)