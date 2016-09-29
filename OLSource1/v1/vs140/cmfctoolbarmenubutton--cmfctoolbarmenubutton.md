---
title: "CMFCToolBarMenuButton::CMFCToolBarMenuButton"
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
  - "CMFCToolBarMenuButton::CMFCToolBarMenuButton"
  - "CMFCToolBarMenuButton.CMFCToolBarMenuButton"
  - "CMFCToolBarMenuButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCToolBarMenuButton class, constructor"
ms.assetid: 65199590-87e0-4bc8-a79b-70b94c44b007
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarMenuButton::CMFCToolBarMenuButton
Constructs a `CMFCToolBarMenuButton` object.  
  
## Syntax  
  
```  
CMFCToolBarMenuButton();  
CMFCToolBarMenuButton(  
   const CMFCToolBarMenuButton& src   
);  
CMFCToolBarMenuButton(  
   UINT uiID,  
   HMENU hMenu,  
   int iImage,  
   LPCTSTR lpszText=NULL,  
   BOOL bUserButton=FALSE   
);  
```  
  
#### Parameters  
 [in] `src`  
 An existing `CMFCToolBarMenuButton` object to be copied into this `CMFCToolBarMenuButton` object.  
  
 [in] `uiID`  
 The ID of the command to execute when a user clicks the button; or (`UINT`)-1 for a menu button that does not directly execute a command.  
  
 [in] `hMenu`  
 A handle to a menu; or `NULL` if the button does not have a menu.  
  
 [in] `iImage`  
 Index of the image for the button; or -1 if this button does not have an icon or uses the icon for the command specified by `uiID`. The index is the same for each `CMFCToolBarImages` object in your application.  
  
 [in] `lpszText`  
 The text of the toolbar menu button.  
  
 [in] `bUserButton`  
 `TRUE` if the button displays a user-defined image; `FALSE` if the button displays a predefined image associated with the command specified by `uiID`.  
  
## Remarks  
 If `uiID` is a valid command ID, the button performs that command when the user clicks it. If `hMenu` is a valid menu handle, the button provides a drop-down menu when it appears in a toolbar or a submenu when it appears in a menu. If both `uiID` and `hMenu` are valid, the button is a split-button with a portion that will perform the command when the user clicks on it and a portion with a down arrow that will drop-down a menu when the user clicks on it. However, if `hMenu` is valid, a user will not be able to click the button to perform a command when the button is inserted into a menu.  
  
## Example  
 The following example demonstrates how to construct an object of the `CMFCToolBarMenuButton` class. This code snippet is part of the [Word Pad sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_WordPad#9](../vs140/codesnippet/CPP/cmfctoolbarmenubutton--cmfctoolbarmenubutton_1.cpp)]  
  
## Requirements  
 **Header:** afxtoolbarmenubutton.h  
  
## See Also  
 [CMFCToolBarMenuButton Class](../vs140/cmfctoolbarmenubutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCToolBarImages Class](../vs140/cmfctoolbarimages-class.md)