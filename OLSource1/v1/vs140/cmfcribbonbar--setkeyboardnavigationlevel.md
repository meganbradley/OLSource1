---
title: "CMFCRibbonBar::SetKeyboardNavigationLevel"
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
  - "CMFCRibbonBar::SetKeyboardNavigationLevel"
  - "SetKeyboardNavigationLevel"
  - "CMFCRibbonBar.SetKeyboardNavigationLevel"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetKeyboardNavigationLevel method"
ms.assetid: 90608e57-cdfd-4cd6-8fe5-2c6940d91085
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonBar::SetKeyboardNavigationLevel
Sets the keyboard navigation level as the user presses the keytips that are contained on the ribbon bar.  
  
## Syntax  
  
```  
void SetKeyboardNavigationLevel(  
   CObject* pLevel,  
   BOOL bSetFocus = TRUE  
);  
```  
  
#### Parameters  
 [in] `pLevel`  
 Pointer to the current keyboard navigation object.  
  
 [in] `bSetFocus`  
 `TRUE` to set the keyboard focus to the ribbon bar.  
  
## Remarks  
 Keyboard navigation of the ribbon bar starts when the user presses the ALT or F10 key. The user selects the next navigation level by pressing a keytip on the ribbon bar. The user can return to the previous navigation level by pressing the escape key.  
  
## Requirements  
 **Header:** afxribbonbar.h  
  
## See Also  
 [CMFCRibbonBar Class](../vs140/cmfcribbonbar-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)