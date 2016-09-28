---
title: "CMFCToolBar::EnableTextLabels"
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
  - "CMFCToolBar::EnableTextLabels"
  - "EnableTextLabels"
  - "CMFCToolBar.EnableTextLabels"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnableTextLabels method"
ms.assetid: e0cfab66-8f9a-467e-92a6-7c198d9eede0
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::EnableTextLabels
Enables or disables text labels under toolbar button images.  
  
## Syntax  
  
```  
void EnableTextLabels(  
   BOOL bEnable=TRUE   
);  
```  
  
#### Parameters  
 `bEnable`  
 `TRUE` if text labels appear under toolbar button images; otherwise `FALSE`.  
  
## Remarks  
 If text labels are enabled, all buttons on the toolbar are enlarged to provide space for the labels to be displayed under the images. The customization dialog box has a **Show text label** check-box on the **Toolbars** page. When the user selects a toolbar and checks this option, the framework calls `EnableTextLabels` for the selected toolbar. You can disable the check-box for an object derived from [CMFCToolBar](../vs140/cmfctoolbar-class.md) by returning `FALSE` from [CMFCToolBar::AllowChangeTextLabels](../vs140/cmfctoolbar--allowchangetextlabels.md) .  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)