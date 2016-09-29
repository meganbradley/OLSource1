---
title: "CStockPropImpl::put_Window"
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
  - "put_Window"
  - "CStockPropImpl::put_Window"
  - "ATL.CStockPropImpl.put_Window"
  - "CStockPropImpl.put_Window"
  - "ATL::CStockPropImpl::put_Window"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "put_Window method"
ms.assetid: 317ad228-fea2-45fb-8fe9-de040cd6068f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStockPropImpl::put_Window
This method calls [CStockPropImpl::put_HWND](../vs140/cstockpropimpl--put_hwnd.md), which returns E_FAIL.  
  
## Syntax  
  
```  
  
      HRESULT STDMETHODCALLTYPE put_Window(  
   LONG_PTR hWnd   
);  
```  
  
#### Parameters  
 `hWnd`  
 The window handle.  
  
## Return Value  
 Returns E_FAIL.  
  
## Remarks  
 The window handle is a read-only value.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CStockPropImpl Class](../vs140/cstockpropimpl-class.md)   
 [CStockPropImpl::get_Window](../vs140/cstockpropimpl--get_window.md)