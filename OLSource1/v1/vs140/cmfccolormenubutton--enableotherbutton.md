---
title: "CMFCColorMenuButton::EnableOtherButton"
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
  - "EnableOtherButton"
  - "CMFCColorMenuButton::EnableOtherButton"
  - "CMFCColorMenuButton.EnableOtherButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnableOtherButton method"
ms.assetid: c6ff2af4-50f1-4ede-8b79-4d0f855f2ea8
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCColorMenuButton::EnableOtherButton
Enables and disables an "other" button that is positioned below the regular color buttons. (The standard system "other" button is labeled **More Colors…**.)  
  
## Syntax  
  
```  
void EnableOtherButton(  
   LPCTSTR lpszLabel,  
   BOOL bAltColorDlg=TRUE,  
   BOOL bEnable=TRUE   
);  
```  
  
#### Parameters  
 [in] `lpszLabel`  
 Specifies the button text.  
  
 [in] `bAltColorDlg`  
 Specify `TRUE` to display the `CMFCColorDialog` dialog box, or `FALSE` to display the standard system color dialog box.  
  
 [in] `bEnable`  
 Specify `TRUE` to display the "other" button; otherwise, `FALSE`. The default is `TRUE`.  
  
## Remarks  
  
## Requirements  
 **Header:** afxcolormenubutton.h  
  
## See Also  
 [CMFCColorMenuButton Class](../vs140/cmfccolormenubutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)