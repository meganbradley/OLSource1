---
title: "CStockPropImpl::get_HWND"
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
  - "CStockPropImpl::get_HWND"
  - "ATL::CStockPropImpl::get_HWND"
  - "get_HWND"
  - "ATL.CStockPropImpl.get_HWND"
  - "CStockPropImpl.get_HWND"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "get_HWND method"
ms.assetid: ebc24ea2-6f03-4bfb-8260-f474958bfc4e
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStockPropImpl::get_HWND
Call this method to get the window handle associated with the control.  
  
## Syntax  
  
```  
  
      HRESULT STDMETHODCALLTYPE get_HWND(  
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
 [CStockPropImpl::put_HWND](../vs140/cstockpropimpl--put_hwnd.md)