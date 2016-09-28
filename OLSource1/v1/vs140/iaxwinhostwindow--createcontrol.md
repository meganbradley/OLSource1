---
title: "IAxWinHostWindow::CreateControl"
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
  - "IAxWinHostWindow::CreateControl"
  - "IAxWinHostWindow.CreateControl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateControl method"
ms.assetid: 56f92500-4a98-4b95-865b-4299dbc943b9
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IAxWinHostWindow::CreateControl
Creates a control, initializes it, and hosts it in the window identified by `hWnd`.  
  
## Syntax  
  
```  
  
      STDMETHOD( CreateControl )(  
   LPCOLESTR lpTricsData,  
   HWND hWnd,  
   IStream* pStream   
);  
```  
  
#### Parameters  
 `lpTricsData`  
 [in] A string identifying the control to create. Can be a CLSID (must include the braces), ProgID, URL, or raw HTML (prefixed by **MSHTML:**).  
  
 `hWnd`  
 [in] A handle to the window to be used for hosting.  
  
 `pStream`  
 [in] An interface pointer for a stream containing initialization data for the control. Can be **NULL**.  
  
## Return Value  
 A standard `HRESULT` value.  
  
## Remarks  
 This window will be subclassed by the host object exposing this interface so that messages can be reflected to the control and other container features will work.  
  
 Calling this method is equivalent to calling [IAxWinHostWindow::CreateControlEx](../vs140/iaxwinhostwindow--createcontrolex.md).  
  
 To create a licensed ActiveX control, see [IAxWinHostWindowLic::CreateControlLic](../vs140/iaxwinhostwindowlic--createcontrollicex.md).  
  
## Requirements  
 **Header:** atliface.h  
  
## See Also  
 [IAxWinHostWindow Interface](../vs140/iaxwinhostwindow-interface.md)   
 [IAxWinHostWindow::CreateControlEx](../vs140/iaxwinhostwindow--createcontrolex.md)   
 [IAxWinHostWindow::AttachControl](../vs140/iaxwinhostwindow--attachcontrol.md)   
 [CAxWindow::CreateControl](../vs140/caxwindow--createcontrol.md)   
 [AtlAxCreateControl](../vs140/atlaxcreatecontrol.md)