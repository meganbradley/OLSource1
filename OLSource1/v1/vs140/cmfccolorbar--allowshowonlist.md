---
title: "CMFCColorBar::AllowShowOnList"
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
  - "CMFCColorBar.AllowShowOnList"
  - "AllowShowOnList"
  - "CMFCColorBar::AllowShowOnList"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AllowShowOnList method"
ms.assetid: 2d382cd7-f6f8-4fb5-9091-aadf0fd20f51
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCColorBar::AllowShowOnList
Indicates whether the color bar control object can appear in a toolbar list during the customization process.  
  
## Syntax  
  
```  
virtual BOOL AllowShowOnList() const;  
```  
  
## Return Value  
 Always `TRUE`.  
  
## Remarks  
 By default, this method always returns `TRUE`, which means the framework can display the color bar control during the customization process. Override this method to implement a different behavior.  
  
## Requirements  
 **Header:** afxcolorbar.h  
  
## See Also  
 [CMFCColorBar Class](../vs140/cmfccolorbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)