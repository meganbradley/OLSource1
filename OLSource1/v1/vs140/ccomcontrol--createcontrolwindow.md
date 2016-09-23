---
title: "CComControl::CreateControlWindow"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - ATL.CComControl.CreateControlWindow
  - CreateControlWindow
  - CComControl::CreateControlWindow
  - ATL::CComControl::CreateControlWindow
  - CComControl.CreateControlWindow
dev_langs: 
  - C++
helpviewer_keywords: 
  - CreateControlWindow method
ms.assetid: 3095c7b7-b35e-4d5b-8b3e-1eab7dc2ad62
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CComControl::CreateControlWindow
By default, creates a window for the control by calling `CWindowImpl::Create`.  
  
## Syntax  
  
```  
  
      virtual HWND CreateControlWindow(  
   HWND hWndParent,  
   RECT& rcPos   
);  
```  
  
#### Parameters  
 `hWndParent`  
 [in] Handle to the parent or owner window. A valid window handle must be supplied. The control window is confined to the area of its parent window.  
  
 `rcPos`  
 [in] The initial size and position of the window to be created.  
  
## Remarks  
 Override this method if you want to do something other than create a single window, for example, to create two windows, one of which becomes a toolbar for your control.  
  
## Example  
 [!code[NVC_ATL_COM#16](../vs140/codesnippet/CPP/ccomcontrol--createcontrolwindow_1.cpp)]
  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CComControl Class](../vs140/ccomcontrol-class.md)   
 [CWindowImpl::Create](../vs140/cwindowimpl--create.md)