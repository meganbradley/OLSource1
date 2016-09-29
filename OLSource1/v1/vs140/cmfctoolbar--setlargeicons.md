---
title: "CMFCToolBar::SetLargeIcons"
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
  - "CMFCToolBar::SetLargeIcons"
  - "SetLargeIcons"
  - "CMFCToolBar.SetLargeIcons"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetLargeIcons method"
ms.assetid: 5acbb98a-4ccc-4cab-939b-6b96bf92c198
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::SetLargeIcons
Specifies whether toolbar buttons display large icons.  
  
## Syntax  
  
```  
static void SetLargeIcons(  
   BOOL bLargeIcons=TRUE   
);  
```  
  
#### Parameters  
 [in] `bLargeIcons`  
 A Boolean value that specifies which icons to use. If this parameter is `TRUE`, the framework displays large icons. Otherwise, the framework displays regular icons.  
  
## Remarks  
 The framework calls this method when the user changes the state of the **Large Icons** check box in the **Options** tab of the **Customize** dialog box. This method resizes all toolbars in the application.  
  
 By default, the framework displays regular icons.  
  
 For more information about the **Customize** dialog box, see [CMFCToolBarsCustomizeDialog Class](../vs140/cmfctoolbarscustomizedialog-class.md).  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCToolBarsCustomizeDialog Class](../vs140/cmfctoolbarscustomizedialog-class.md)