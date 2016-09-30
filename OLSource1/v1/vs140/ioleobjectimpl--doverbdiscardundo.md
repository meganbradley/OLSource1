---
title: "IOleObjectImpl::DoVerbDiscardUndo"
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
  - "ATL::IOleObjectImpl<T>::DoVerbDiscardUndo"
  - "ATL::IOleObjectImpl::DoVerbDiscardUndo"
  - "IOleObjectImpl.DoVerbDiscardUndo"
  - "DoVerbDiscardUndo"
  - "IOleObjectImpl<T>::DoVerbDiscardUndo"
  - "IOleObjectImpl::DoVerbDiscardUndo"
  - "ATL.IOleObjectImpl.DoVerbDiscardUndo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DoVerbDiscardUndo method"
ms.assetid: fe79fe34-1a19-4d4b-a5e0-e25a21c21c4e
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IOleObjectImpl::DoVerbDiscardUndo
Tells the control to discard any undo state it is maintaining.  
  
## Syntax  
  
```  
  
      HRESULT DoVerbDiscardUndo(  
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
 [IOleObjectImpl Class](../vs140/ioleobjectimpl-class.md)