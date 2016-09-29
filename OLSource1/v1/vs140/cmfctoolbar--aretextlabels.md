---
title: "CMFCToolBar::AreTextLabels"
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
  - "AreTextLabels"
  - "CMFCToolBar.AreTextLabels"
  - "CMFCToolBar::AreTextLabels"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AreTextLabels method"
ms.assetid: 926d2307-902a-48ea-82eb-0cb0dfce0c65
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::AreTextLabels
Specifies whether text labels under images are currently displayed on the toolbar buttons.  
  
## Syntax  
  
```  
BOOL AreTextLabels() const;  
```  
  
## Return Value  
 `TRUE` if the toolbar buttons display text labels below images; otherwise `FALSE`.  
  
## Remarks  
 Use [CMFCToolBar::EnableTextLabels](../vs140/cmfctoolbar--enabletextlabels.md) to specify whether the text is displayed. The default value is `FALSE`. Call [CMFCToolBar::AllowChangeTextLabels](../vs140/cmfctoolbar--allowchangetextlabels.md) to specify whether the user can change this setting in the customization dialog box.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)