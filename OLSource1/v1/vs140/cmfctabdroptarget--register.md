---
title: "CMFCTabDropTarget::Register"
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
  - "Register"
  - "CMFCTabDropTarget.Register"
  - "CMFCTabDropTarget::Register"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Register method"
ms.assetid: 2683f8cf-b896-4935-9085-b08e4bc394c0
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCTabDropTarget::Register
Registers the control as one that can be the target of an OLE drag-and-drop operation.  
  
## Syntax  
  
```  
BOOL Register(CMFCBaseTabCtrl *pOwner);  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] `pOwner`|The tab control to register as a drop target.|  
  
## Return Value  
 Nonzero if registration was successful; otherwise 0.  
  
## Remarks  
 This method calls [COleDropTarget::Register](../vs140/coledroptarget--register.md) to register the control for drag-and-drop operations.  
  
## Requirements  
 **Header:** afxbasetabctrl.h  
  
## See Also  
 [CMFCTabDropTarget Class](../vs140/cmfctabdroptarget-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCBaseTabCtrl Class](../vs140/cmfcbasetabctrl-class.md)   
 [COleDropTarget::Register](../vs140/coledroptarget--register.md)