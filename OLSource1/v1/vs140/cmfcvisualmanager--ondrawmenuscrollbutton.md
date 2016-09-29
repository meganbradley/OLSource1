---
title: "CMFCVisualManager::OnDrawMenuScrollButton"
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
  - "OnDrawMenuScrollButton"
  - "CMFCVisualManager.OnDrawMenuScrollButton"
  - "CMFCVisualManager::OnDrawMenuScrollButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawMenuScrollButton method"
ms.assetid: 231c5345-e288-4b98-80c9-eed99b75c8e5
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManager::OnDrawMenuScrollButton
The framework calls this method when it draws a menu scroll button.  
  
## Syntax  
  
```  
virtual void OnDrawMenuScrollButton(  
   CDC* pDC,  
   CRect rect,  
   BOOL bIsScrollDown,  
   BOOL bIsHighlited,  
   BOOL bIsPressed,  
   BOOL bIsDisabled  
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to a device context.  
  
 [in] `rect`  
 A rectangle that specifies the boundaries of the scroll button.  
  
 [in] `bIsScrollDown`  
 A Boolean that indicates which type of button the visual manager draws. A value of `TRUE` indicates the visual manager draws a down button.  
  
 [in] `bIsHighlited`  
 A Boolean that indicates whether the button is highlighted.  
  
 [in] `bIsPressed`  
 A Boolean that indicates whether the button is pressed.  
  
 [in] `bIsDisabled`  
 A Boolean that indicates whether the button is disabled.  
  
## Remarks  
 Override this method in a derived visual manager to customize the appearance of menu scroll buttons. Menu scroll buttons appear on the edge of pop-up menus when the total height of the menu items exceeds the height of the pop-up menu.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)