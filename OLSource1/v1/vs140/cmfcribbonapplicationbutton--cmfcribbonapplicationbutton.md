---
title: "CMFCRibbonApplicationButton::CMFCRibbonApplicationButton"
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
  - CMFCRibbonApplicationButton.CMFCRibbonApplicationButton
  - CMFCRibbonApplicationButton::CMFCRibbonApplicationButton
  - CMFCRibbonApplicationButton
dev_langs: 
  - C++
helpviewer_keywords: 
  - CMFCRibbonApplicationButton class, constructor
ms.assetid: 5da433d5-2fa8-4dc5-b1dc-09b5fbbdcc32
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCRibbonApplicationButton::CMFCRibbonApplicationButton
Constructs and initializes a [CMFCRibbonApplicationButton](../vs140/cmfcribbonapplicationbutton-class.md) object.  
  
## Syntax  
  
```  
CMFCRibbonApplicationButton();  
CMFCRibbonApplicationButton(  
   UINT uiBmpResID   
);  
CMFCRibbonApplicationButton(  
   HBITMAP hBmp   
);  
```  
  
#### Parameters  
 `uiBmpResID`  
 The resource ID of the image to display on the application button.  
  
 `hBmp`  
 A handle to a bitmap to display on the application button.  
  
## Remarks  
 The ribbon application button is a special button that is located in the upper-left corner of the application window. When a user clicks this button, the application opens a menu that usually contains common **File** commands, such as **Open**, **Save**, and **Exit**.  
  
## Requirements  
 **Header:** afxRibbonBar.h  
  
## See Also  
 [CMFCRibbonApplicationButton Class](../vs140/cmfcribbonapplicationbutton-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)