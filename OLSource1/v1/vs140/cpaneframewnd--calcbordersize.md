---
title: "CPaneFrameWnd::CalcBorderSize"
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
  - "CalcBorderSize"
  - "CPaneFrameWnd::CalcBorderSize"
  - "CPaneFrameWnd.CalcBorderSize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CalcBorderSize method"
ms.assetid: b1e09869-ac7a-4e9b-a097-ebb7d3bc7c9c
caps.latest.revision: 11
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPaneFrameWnd::CalcBorderSize
Calculates the size of the borders for a miniframe window.  
  
## Syntax  
  
```  
virtual void CalcBorderSize(  
    CRect& rectBorderSize   
) const;  
```  
  
#### Parameters  
 [out] `rectBorderSize`  
 Contains the size, in pixels, of the border of the miniframe window.  
  
## Remarks  
 This method is called by the framework to calculate the size of the border of a miniframe window. The returned size depends on whether a miniframe window contains a toolbar or a [CDockablePane](../vs140/cdockablepane-class.md).  
  
## Requirements  
 **Header:** afxPaneFrameWnd.h  
  
## See Also  
 [CPaneFrameWnd Class](../vs140/cpaneframewnd-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)