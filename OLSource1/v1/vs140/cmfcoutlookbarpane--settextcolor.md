---
title: "CMFCOutlookBarPane::SetTextColor"
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
  - "CMFCOutlookBarPane.SetTextColor"
  - "SetTextColor"
  - "CMFCOutlookBarPane::SetTextColor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetTextColor method"
ms.assetid: 2090e546-5cf3-4be5-8d31-5f895f5aa384
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCOutlookBarPane::SetTextColor
Sets the colors of regular and highlighted text in the Outlook bar pane.  
  
## Syntax  
  
```  
void SetTextColor(  
   COLORREF clrRegText,  
   COLORREF clrSelText=0   
);  
```  
  
#### Parameters  
 [in] `clrRegText`  
 Specifies the new color for non-selected text.  
  
 [in] `clrSelText`  
 Specifies the new color for selected text.  
  
## Requirements  
 **Header:** afxoutlookbarpane.h  
  
## See Also  
 [CMFCOutlookBarPane Class](../vs140/cmfcoutlookbarpane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)