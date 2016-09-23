---
title: "CMFCRibbonButton::FindSubItemIndexByID"
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
  - CMFCRibbonButton.FindSubItemIndexByID
  - CMFCRibbonButton::FindSubItemIndexByID
  - FindSubItemIndexByID
dev_langs: 
  - C++
helpviewer_keywords: 
  - FindSubItemIndexByID method
ms.assetid: 8b0af68c-acc5-452f-b823-e607b413937a
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCRibbonButton::FindSubItemIndexByID
Returns the index of a pop-up menu item that is associated with the specified command ID.  
  
## Syntax  
  
```  
int FindSubItemIndexByID(  
   UINT uiID   
) const;  
```  
  
#### Parameters  
 [in] `uiID`  
 Specifies the command ID of the pop-up menu item.  
  
## Return Value  
 The zero-based index of the sub-item that is associated with the `uiID`. -1 if there is no such sub-item.  
  
## Requirements  
 **Header:** afxribbonbutton.h  
  
## See Also  
 [CMFCRibbonButton Class](../vs140/cmfcribbonbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)