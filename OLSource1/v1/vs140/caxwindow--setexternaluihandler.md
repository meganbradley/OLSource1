---
title: "CAxWindow::SetExternalUIHandler"
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
  - CAxWindow.SetExternalUIHandler
  - CAxWindow::SetExternalUIHandler
  - SetExternalUIHandler
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetExternalUIHandler method
ms.assetid: eeb47b39-670e-4ac4-ac08-b01f71519709
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CAxWindow::SetExternalUIHandler
Sets the external [IDocHostUIHandlerDispatch](../vs140/idochostuihandlerdispatch-interface.md) interface for the `CAxWindow` object.  
  
## Syntax  
  
```  
  
      HRESULT SetExternalUIHandler(  
   IDocHostUIHandlerDispatch* pUIHandler   
);  
```  
  
#### Parameters  
 *pUIHandler*  
 [in] A pointer to an **IDocHostUIHandlerDispatch** interface.  
  
## Return Value  
 A standard `HRESULT` value.  
  
## Remarks  
 The external `IDocHostUIHandlerDispatch` interface is used by controls that query the host's site for the `IDocHostUIHandlerDispatch` interface. The WebBrowser control is one control that does this.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CAxWindow Class](../vs140/caxwindow-class.md)   
 [CAxWindow::SetExternalDispatch](../vs140/caxwindow--setexternaldispatch.md)