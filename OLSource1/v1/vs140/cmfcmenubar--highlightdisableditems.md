---
title: "CMFCMenuBar::HighlightDisabledItems"
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
  - "CMFCMenuBar.HighlightDisabledItems"
  - "HighlightDisabledItems"
  - "CMFCMenuBar::HighlightDisabledItems"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "HighlightDisabledItems method"
ms.assetid: 274baef6-796d-48c6-932f-2a54f47e1bd4
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCMenuBar::HighlightDisabledItems
Controls whether the framework highlights disabled menu items.  
  
## Syntax  
  
```  
static void HighlightDisabledItems(  
   BOOL bHighlight = TRUE  
);  
```  
  
#### Parameters  
 [in] `bHighlight`  
 A Boolean parameter that indicates whether the framework highlights unavailable menu items.  
  
## Remarks  
 By default, the framework does not highlight unavailable menu items when the user positions the mouse pointer over them.  
  
## Requirements  
 **Header:** afxmenubar.h  
  
## See Also  
 [CMFCMenuBar Class](../vs140/cmfcmenubar-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCMenuBar::IsHighlightDisabledItems](../vs140/cmfcmenubar--ishighlightdisableditems.md)