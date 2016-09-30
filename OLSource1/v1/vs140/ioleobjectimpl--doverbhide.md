---
title: "IOleObjectImpl::DoVerbHide"
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
  - "ATL::IOleObjectImpl::DoVerbHide"
  - "IOleObjectImpl<T>::DoVerbHide"
  - "ATL::IOleObjectImpl<T>::DoVerbHide"
  - "IOleObjectImpl<T>.DoVerbHide"
  - "ATL.IOleObjectImpl<T>.DoVerbHide"
  - "IOleObjectImpl.DoVerbHide"
  - "IOleObjectImpl::DoVerbHide"
  - "DoVerbHide"
  - "ATL.IOleObjectImpl.DoVerbHide"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DoVerbHide method"
ms.assetid: 13db0f38-192b-4b50-abd3-7412894763dd
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IOleObjectImpl::DoVerbHide
Deactivates and removes the control's user interface, and hides the control.  
  
## Syntax  
  
```  
  
      HRESULT DoVerbHide(  
   LPCRECT /* prcPosRect */,  
   HWND /* hwndParent */  
);  
```  
  
#### Parameters  
 `prcPosRec`  
 [in] Pointer to the rectangle the container wants the control to draw into.  
  
 *hwndParent*  
 [in] Handle of the window containing the control. Not used in the ATL implementation.  
  
## Return Value  
 Returns `S_OK`.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [IOleObjectImpl Class](../vs140/ioleobjectimpl-class.md)   
 [IOleObjectImpl::DoVerbShow](../vs140/ioleobjectimpl--doverbshow.md)