---
title: "IAxWinHostWindow::QueryControl"
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
  - IAxWinHostWindow::QueryControl
  - IAxWinHostWindow.QueryControl
  - QueryControl
dev_langs: 
  - C++
helpviewer_keywords: 
  - QueryControl method
ms.assetid: 8bd6e411-52f3-41af-a67e-12d6a31fc5e8
caps.latest.revision: 14
translation.priority.ht: 
  - de-de
  - ja-jp
---
# IAxWinHostWindow::QueryControl
Returns the specified interface pointer provided by the hosted control.  
  
## Syntax  
  
```  
  
      STDMETHOD( QueryControl )(  
   REFIID riid,  
   void** ppvObject   
);  
```  
  
#### Parameters  
 `riid`  
 [in] The ID of an interface on the control being requested.  
  
 `ppvObject`  
 [out] The address of a pointer that will receive the specified interface of the created control.  
  
## Return Value  
 A standard `HRESULT` value.  
  
## Requirements  
 **Header:** atliface.h  
  
## See Also  
 [IAxWinHostWindow Interface](../vs140/iaxwinhostwindow-interface.md)   
 [CAxWindow::QueryControl](../vs140/caxwindow--querycontrol.md)   
 [AtlAxGetControl](../vs140/atlaxgetcontrol.md)