---
title: "CMFCToolBarEditBoxButton::GetByCmd"
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
  - GetByCmd
  - CMFCToolBarEditBoxButton::GetByCmd
  - CMFCToolBarEditBoxButton.GetByCmd
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetByCmd method
ms.assetid: 9351db54-ce90-44b4-9e87-a0bc8e6c6490
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCToolBarEditBoxButton::GetByCmd
Retrieves the first `CMFCToolBarEditBoxButton` object in the application that has the specified command ID.  
  
## Syntax  
  
```  
static CMFCToolBarEditBoxButton* __stdcall GetByCmd(  
   UINT uiCmd  
);  
```  
  
#### Parameters  
 [in] `uiCmd`  
 The command ID of the button to retrieve.  
  
## Return Value  
 The first `CMFCToolBarEditBoxButton` object in the application that has the specified command ID, or `NULL` if no such object exists.  
  
## Remarks  
 This shared utility method is used by methods such as [CMFCToolBarEditBoxButton::SetContentsAll](../vs140/cmfctoolbareditboxbutton--setcontentsall.md) and [CMFCToolBarEditBoxButton::GetContentsAll](../vs140/cmfctoolbareditboxbutton--getcontentsall.md) to set or get the text of the first edit box toolbar control that has the specified command ID.  
  
## Requirements  
 **Header:** afxtoolbareditboxbutton.h  
  
## See Also  
 [CMFCToolBarEditBoxButton Class](../vs140/cmfctoolbareditboxbutton-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCToolBarEditBoxButton::SetContentsAll](../vs140/cmfctoolbareditboxbutton--setcontentsall.md)   
 [CMFCToolBarEditBoxButton::GetContentsAll](../vs140/cmfctoolbareditboxbutton--getcontentsall.md)