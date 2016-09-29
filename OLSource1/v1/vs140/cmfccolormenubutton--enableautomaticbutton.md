---
title: "CMFCColorMenuButton::EnableAutomaticButton"
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
  - "CMFCColorMenuButton.EnableAutomaticButton"
  - "EnableAutomaticButton"
  - "CMFCColorMenuButton::EnableAutomaticButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnableAutomaticButton method"
ms.assetid: 68fc5d76-bd97-4120-a659-2d29f4f5c0c9
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCColorMenuButton::EnableAutomaticButton
Enables and disables an "automatic" button that is positioned above the regular color buttons. (The standard system automatic button is labeled **Automatic**.)  
  
## Syntax  
  
```  
void EnableAutomaticButton(  
   LPCTSTR lpszLabel,  
   COLORREF colorAutomatic,  
   BOOL bEnable=TRUE   
);  
```  
  
#### Parameters  
 [in] `lpszLabel`  
 Specifies the button text that is displayed when the button becomes automatic.  
  
 [in] `colorAutomatic`  
 Specifies a new automatic color.  
  
 [in] `bEnable`  
 Specifies whether the button is automatic or not.  
  
## Remarks  
 The automatic button applies the current default color.  
  
## Requirements  
 **Header:** afxcolormenubutton.h  
  
## See Also  
 [CMFCColorMenuButton Class](../vs140/cmfccolormenubutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449)