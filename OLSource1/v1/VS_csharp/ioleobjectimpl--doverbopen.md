---
title: "IOleObjectImpl::DoVerbOpen"
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
  - "IOleObjectImpl<T>.DoVerbOpen"
  - "IOleObjectImpl.DoVerbOpen"
  - "IOleObjectImpl<T>::DoVerbOpen"
  - "ATL::IOleObjectImpl<T>::DoVerbOpen"
  - "IOleObjectImpl::DoVerbOpen"
  - "ATL::IOleObjectImpl::DoVerbOpen"
  - "DoVerbOpen"
  - "ATL.IOleObjectImpl<T>.DoVerbOpen"
  - "ATL.IOleObjectImpl.DoVerbOpen"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DoVerbOpen method"
ms.assetid: 79472370-50bc-45f9-ba01-4c5da469469f
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IOleObjectImpl::DoVerbOpen
Causes the control to be open-edited in a separate window.  
  
## Syntax  
  
```  
  
      HRESULT DoVerbOpen(  
   LPCRECT /* prcPosRect */,  
   HWND /* hwndParent */   
);  
```  
  
#### Parameters  
 `prcPosRec`  
 [in] Pointer to the rectangle the container wants the control to draw into.  
  
 *hwndParent*  
 [in] Handle of the window containing the control.  
  
## Return Value  
 Returns `S_OK`.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [IOleObjectImpl Class](../VS_csharp/ioleobjectimpl-class.md)