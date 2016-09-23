---
title: "CMFCToolBarEditBoxButton::GetEditBox"
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
  - CMFCToolBarEditBoxButton.GetEditBox
  - CMFCToolBarEditBoxButton::GetEditBox
  - GetEditBox
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetEditBox method
ms.assetid: 431eb449-3a02-4c12-ae33-f103b38145dc
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCToolBarEditBoxButton::GetEditBox
Returns a pointer to the [CEdit](../vs140/cedit-class.md) control that is embedded in the button.  
  
## Syntax  
  
```  
CEdit* GetEditBox() const;  
```  
  
## Return Value  
 A pointer to the [CEdit](../vs140/cedit-class.md) control that the button contains. It is `NULL` if the `CEdit` control has not been created yet.  
  
## Remarks  
 You create the `CEdit` control by calling [CMFCToolBarEditBoxButton::CreateEdit](../vs140/cmfctoolbareditboxbutton--createedit.md).  
  
## Requirements  
 **Header:** afxtoolbareditboxbutton.h  
  
## See Also  
 [CMFCToolBarEditBoxButton Class](../vs140/cmfctoolbareditboxbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CEdit](../vs140/cedit-class.md)