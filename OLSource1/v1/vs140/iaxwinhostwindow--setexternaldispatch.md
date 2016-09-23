---
title: "IAxWinHostWindow::SetExternalDispatch"
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
  - IAxWinHostWindow.SetExternalDispatch
  - IAxWinHostWindow::SetExternalDispatch
  - SetExternalDispatch
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetExternalDispatch method
ms.assetid: 68e24362-96b5-44ae-aa6b-9a021b4ecce9
caps.latest.revision: 14
translation.priority.ht: 
  - de-de
  - ja-jp
---
# IAxWinHostWindow::SetExternalDispatch
Sets the external dispinterface, which is available to contained controls through the [IDocHostUIHandlerDispatch::GetExternal](../vs140/idochostuihandlerdispatch-interface.md) method.  
  
## Syntax  
  
```  
  
      STDMETHOD( SetExternalDispatch )(  
   IDispatch* pDisp   
);  
```  
  
#### Parameters  
 `pDisp`  
 [in] A pointer to an `IDispatch` interface.  
  
## Return Value  
 A standard `HRESULT` value.  
  
## Requirements  
 **Header:** atliface.h  
  
## See Also  
 [IAxWinHostWindow Interface](../vs140/iaxwinhostwindow-interface.md)   
 [CAxWindow::SetExternalDispatch](../vs140/caxwindow--setexternaldispatch.md)