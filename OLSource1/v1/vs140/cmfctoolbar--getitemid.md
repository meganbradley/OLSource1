---
title: "CMFCToolBar::GetItemID"
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
  - "GetItemID"
  - "CMFCToolBar::GetItemID"
  - "CMFCToolBar.GetItemID"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetItemID method"
ms.assetid: f661871e-c8fe-473c-b508-3acc1ecb57d4
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::GetItemID
Returns the command ID of the toolbar button at a specified index.  
  
## Syntax  
  
```  
UINT GetItemID(  
   int nIndex   
) const;  
```  
  
#### Parameters  
 [in] `nIndex`  
 Specifies the index of the toolbar button.  
  
## Return Value  
 The command ID of the toolbar button; or zero if the button with the specified index does not exist.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)