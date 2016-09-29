---
title: "IAxWinHostWindow::AttachControl"
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
  - "IAxWinHostWindow::AttachControl"
  - "IAxWinHostWindow.AttachControl"
  - "AttachControl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AttachControl method"
ms.assetid: e657ab5a-b598-437d-888f-3c30def1f60f
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IAxWinHostWindow::AttachControl
Attaches an existing (and previously initialized) control to the host object using the window identified by `hWnd`.  
  
## Syntax  
  
```  
  
      STDMETHOD( AttachControl )(  
   IUnknown* pUnkControl,  
   HWND hWnd   
);  
```  
  
#### Parameters  
 *pUnkControl*  
 [in] A pointer to the **IUnknown** interface of the control to be attached to the host object.  
  
 `hWnd`  
 [in] A handle to the window to be used for hosting.  
  
## Return Value  
 A standard `HRESULT` value.  
  
## Requirements  
 **Header:** atliface.h  
  
## See Also  
 [IAxWinHostWindow Interface](../VS_csharp/iaxwinhostwindow-interface.md)   
 [IAxWinHostWindow::CreateControl](../VS_csharp/iaxwinhostwindow--createcontrol.md)   
 [IAxWinHostWindow::CreateControlEx](../VS_csharp/iaxwinhostwindow--createcontrolex.md)   
 [CAxWindow::AttachControl](../Topic/CAxWindow::AttachControl.md)   
 [AtlAxAttachControl](../VS_csharp/atlaxattachcontrol.md)