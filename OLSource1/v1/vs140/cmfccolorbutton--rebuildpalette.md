---
title: "CMFCColorButton::RebuildPalette"
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
  - "RebuildPalette"
  - "CMFCColorButton::RebuildPalette"
  - "CMFCColorButton.RebuildPalette"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RebuildPalette method"
  - "CMFCColorButton::RebuildPalette"
ms.assetid: eac5906d-91b8-44ce-b8a2-736457848fdc
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCColorButton::RebuildPalette
Initializes the `m_pPalette` protected data member to the specified palette or the default system palette.  
  
## Syntax  
  
```  
void RebuildPalette(  
   CPalette* pPal  
);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] `pPal`|A pointer to a logical palette or `NULL`. If `NULL`, the default system palette is used.|  
  
## Requirements  
 **Header:** afxcolorbutton.h  
  
## See Also  
 [CMFCColorButton Class](../vs140/cmfccolorbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPalette Class](../vs140/cpalette-class.md)