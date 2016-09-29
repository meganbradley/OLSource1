---
title: "CToolBarCtrl::SetOwner"
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
  - "CToolBarCtrl::SetOwner"
  - "CToolBarCtrl.SetOwner"
  - "SetOwner"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetOwner method"
ms.assetid: 992de464-6c0b-4fcb-9838-ebed1569dc7e
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolBarCtrl::SetOwner
Sets the owner window for the toolbar control.  
  
## Syntax  
  
```  
  
      void SetOwner(  
   CWnd* pWnd   
);  
```  
  
#### Parameters  
 `pWnd`  
 Pointer to the `CWnd` or `CWnd`-derived object that will be the new owner window for the toolbar control.  
  
## Remarks  
 The owner window is the window that receives notifications from the toolbar.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolBarCtrl Class](../vs140/ctoolbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolBarCtrl::Create](../vs140/ctoolbarctrl--create.md)