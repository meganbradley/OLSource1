---
title: "CStockPropImpl::get_Window"
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
  - "ATL::CStockPropImpl::get_Window"
  - "CStockPropImpl.get_Window"
  - "ATL.CStockPropImpl.get_Window"
  - "CStockPropImpl::get_Window"
  - "get_Window"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "get_Window method"
ms.assetid: c7ee8cfa-619c-4dc8-9c64-08e3a17674b0
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStockPropImpl::get_Window
Call this method to get the window handle associated with the control. Identical to [CStockPropImpl::get_HWND](../vs140/cstockpropimpl--get_hwnd.md).  
  
## Syntax  
  
```  
  
      HRESULT STDMETHODCALLTYPE get_Window(  
   LONG_PTR* phWnd   
);  
```  
  
#### Parameters  
 `phWnd`  
 The window handle associated with the control.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CStockPropImpl Class](../vs140/cstockpropimpl-class.md)   
 [CStockPropImpl::put_Window](../vs140/cstockpropimpl--put_window.md)