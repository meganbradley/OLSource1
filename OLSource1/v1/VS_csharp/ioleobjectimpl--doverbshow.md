---
title: "IOleObjectImpl::DoVerbShow"
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
  - "IOleObjectImpl.DoVerbShow"
  - "ATL.IOleObjectImpl.DoVerbShow"
  - "ATL.IOleObjectImpl<T>.DoVerbShow"
  - "DoVerbShow"
  - "IOleObjectImpl<T>.DoVerbShow"
  - "ATL::IOleObjectImpl<T>::DoVerbShow"
  - "ATL::IOleObjectImpl::DoVerbShow"
  - "IOleObjectImpl::DoVerbShow"
  - "IOleObjectImpl<T>::DoVerbShow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DoVerbShow method"
ms.assetid: 218e3fda-5ce8-49aa-9dfd-71758789e4b5
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IOleObjectImpl::DoVerbShow
Tells the container to make the control visible.  
  
## Syntax  
  
```  
  
      HRESULT DoVerbShow(  
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
 [IOleObjectImpl Class](../VS_csharp/ioleobjectimpl-class.md)   
 [IOleObjectImpl::DoVerbHide](../VS_csharp/ioleobjectimpl--doverbhide.md)