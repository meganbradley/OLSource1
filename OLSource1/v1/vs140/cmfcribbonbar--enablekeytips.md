---
title: "CMFCRibbonBar::EnableKeyTips"
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
  - "CMFCRibbonBar::EnableKeyTips"
  - "EnableKeyTips"
  - "CMFCRibbonBar.EnableKeyTips"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnableKeyTips method"
ms.assetid: 4a908df4-9144-463f-810b-f042d889a6cd
caps.latest.revision: 20
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonBar::EnableKeyTips
Enables or disables the keytip feature for the ribbon bar.  
  
## Syntax  
  
```  
void EnableKeyTips(  
   BOOL bEnable = TRUE   
);  
```  
  
#### Parameters  
 [in] `bEnable`  
 `TRUE` to enable the keytips feature; `FALSE` to disable the keytips feature.  
  
## Remarks  
 When you enable this feature, key tips are displayed when the user presses the ALT or F10 button. When the user presses ALT key, key tips are displayed with a 200 millisecond delay. This delay allows for shortcuts to be executed so that the pressed ALT key does not interfere with other combinations that include the ALT key.  
  
## Requirements  
 **Header:** afxribbonbar.h  
  
## See Also  
 [CMFCRibbonBar Class](../vs140/cmfcribbonbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)