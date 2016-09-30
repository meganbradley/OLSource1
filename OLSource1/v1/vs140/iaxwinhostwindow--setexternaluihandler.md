---
title: "IAxWinHostWindow::SetExternalUIHandler"
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
  - "IAxWinHostWindow.SetExternalUIHandler"
  - "IAxWinHostWindow::SetExternalUIHandler"
  - "SetExternalUIHandler"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetExternalUIHandler method"
ms.assetid: c0cf464b-d49d-43e4-af35-61abb4c9ed3f
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IAxWinHostWindow::SetExternalUIHandler
Call this function to set the external [IDocHostUIHandlerDispatch](../vs140/idochostuihandlerdispatch-interface.md) interface for the `CAxWindow` object.  
  
## Syntax  
  
```  
  
      STDMETHOD( SetExternalUIHandler )(  
   IDocHostUIHandlerDispatch* pDisp   
);  
```  
  
#### Parameters  
 `pDisp`  
 [in] A pointer to an **IDocHostUIHandlerDispatch** interface.  
  
## Return Value  
 A standard `HRESULT` value.  
  
## Remarks  
 This function is used by controls (such as the Web browser control) that query the host's site for the `IDocHostUIHandlerDispatch` interface.  
  
## Requirements  
 **Header:** atliface.h  
  
## See Also  
 [IAxWinHostWindow Interface](../vs140/iaxwinhostwindow-interface.md)   
 [CAxWindow::SetExternalUIHandler](../vs140/caxwindow--setexternaluihandler.md)