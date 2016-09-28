---
title: "CMFCDropDownToolbarButton::OnCustomizeMenu"
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
  - "CMFCDropDownToolbarButton.OnCustomizeMenu"
  - "CMFCDropDownToolbarButton::OnCustomizeMenu"
  - "OnCustomizeMenu"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnCustomizeMenu method"
ms.assetid: db44ea1c-96c5-484d-b614-dc79f18b7886
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCDropDownToolbarButton::OnCustomizeMenu
Modifies the provided menu when the application displays a shortcut menu on the parent toolbar.  
  
## Syntax  
  
```  
virtual BOOL OnCustomizeMenu(  
   CMenu* pMenu  
);  
```  
  
#### Parameters  
 [in] `pMenu`  
 The menu to customize.  
  
## Return Value  
 This method returns `TRUE`.  
  
## Remarks  
 This method extends the base class implementation ([CMFCToolBarButton::OnCustomizeMenu](../vs140/cmfctoolbarbutton--oncustomizemenu.md)) by disabling the following menu items:  
  
-   **Copy Button Image**  
  
-   **Button Appearance**  
  
-   **Image**  
  
-   **Text**  
  
-   **Image and Text**  
  
 Override this method to modify the shortcut menu that the framework displays in customization mode.  
  
## Requirements  
 **Header:** afxdropdowntoolbar.h  
  
## See Also  
 [CMFCDropDownToolbarButton Class](../vs140/cmfcdropdowntoolbarbutton-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCToolBarButton::OnCustomizeMenu](../vs140/cmfctoolbarbutton--oncustomizemenu.md)