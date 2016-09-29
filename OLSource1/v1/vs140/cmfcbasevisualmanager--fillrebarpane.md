---
title: "CMFCBaseVisualManager::FillReBarPane"
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
  - "CMFCBaseVisualManager.FillReBarPane"
  - "FillReBarPane"
  - "CMFCBaseVisualManager::FillReBarPane"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FillReBarPane method"
ms.assetid: 5b4c321a-6ee9-4de0-b734-8cc17cfe3a66
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCBaseVisualManager::FillReBarPane
Fills the background of the rebar control by using the current Windows theme.  
  
## Syntax  
  
```  
virtual void FillReBarPane(  
   CDC* pDC,   
   CBasePane* pBar,   
   CRect rectClient  
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to a device context.  
  
 [in] `pBar`  
 A pointer to a pane whose background should be drawn.  
  
 [in] `rectClient`  
 The bounding rectangle of the area to be filled.  
  
## Return Value  
 `TRUE` if Theme API is enabled; otherwise `FALSE`.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCBaseVisualManager Class](../vs140/cmfcbasevisualmanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)