---
title: "CMFCRibbonPanel::FindByID"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CMFCRibbonPanel::FindByID
  - FindByID
  - CMFCRibbonPanel.FindByID
dev_langs: 
  - C++
helpviewer_keywords: 
  - FindByID method
ms.assetid: 9c29ea9c-84f0-432a-bb80-6483e4d31e6e
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCRibbonPanel::FindByID
Retrieves the ribbon element that is identified by the specified command ID.  
  
## Syntax  
  
```  
CMFCRibbonBaseElement* FindByID(  
    UINT uiCmdID   
) const;  
```  
  
#### Parameters  
 [in] `uiCmdID`  
 The command ID of a ribbon element.  
  
## Return Value  
 The ribbon element that is identified by the specified command ID; otherwise `NULL` if no ribbon element is identified with the specified command ID.  
  
## Requirements  
 **Header:** afxRibbonPanel.h  
  
## See Also  
 [CMFCRibbonPanel Class](../vs140/cmfcribbonpanel-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)