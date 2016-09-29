---
title: "CToolBarCtrl::SetMetrics"
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
  - "CToolBarCtrl.SetMetrics"
  - "CToolBarCtrl::SetMetrics"
  - "SetMetrics"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetMetrics method"
ms.assetid: 67789411-50fc-48fc-aa93-f04b06d6ea23
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolBarCtrl::SetMetrics
Sets the metrics of the `CToolBarCtrl` object.  
  
## Syntax  
  
```  
  
      void SetMetrics(  
   LPTBMETRICS ptbm   
);  
```  
  
#### Parameters  
 `ptbm`  
 A pointer to the [TBMETRICS](http://msdn.microsoft.com/library/windows/desktop/bb760482) structure of the `CToolBarCtrl` object.  
  
## Remarks  
 This member function emulates the functionality of the [TB_SETMETRICS](http://msdn.microsoft.com/library/windows/desktop/bb787446) message, as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolBarCtrl Class](../vs140/ctoolbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolBarCtrl::GetMetrics](../vs140/ctoolbarctrl--getmetrics.md)