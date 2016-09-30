---
title: "CMFCTabCtrl::SetResizeMode"
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
  - "CMFCTabCtrl.SetResizeMode"
  - "SetResizeMode"
  - "CMFCTabCtrl::SetResizeMode"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetResizeMode method"
ms.assetid: 89c71347-52b9-43b6-b66b-8462d5dd0426
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCTabCtrl::SetResizeMode
Specifies how the current tab control can be resized and then redisplays the control.  
  
## Syntax  
  
```  
void SetResizeMode(  
   ResizeMode resizeMode  
);  
```  
  
#### Parameters  
 [in] `resizeMode`  
 One of the `CMFCTabCtrl::ResizeMode` enumeration values that specifies how the tab control can be resized. For a list of possible values, see the table in Remarks.  
  
## Remarks  
 The `resizeMode` parameter can be one of the following `ResizeMode` enumeration values.  
  
|Name|Description|  
|----------|-----------------|  
|RESIZE_NO|The tab control cannot be resized.|  
|RESIZE_VERT|The tab control can be resized vertically but not horizontally.|  
|RESIZE_HORIZ|The tab control can be resized horizontally but not vertically.|  
  
## Requirements  
 **Header:** afxtabctrl.h  
  
## See Also  
 [CMFCTabCtrl Class](../vs140/cmfctabctrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCTabCtrl::SetResizeMode](../vs140/cmfctabctrl--setresizemode.md)