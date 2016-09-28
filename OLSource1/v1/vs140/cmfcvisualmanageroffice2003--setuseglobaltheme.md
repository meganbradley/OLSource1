---
title: "CMFCVisualManagerOffice2003::SetUseGlobalTheme"
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
  - "SetUseGlobalTheme"
  - "CMFCVisualManagerOffice2003.SetUseGlobalTheme"
  - "CMFCVisualManagerOffice2003::SetUseGlobalTheme"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetUseGlobalTheme method"
ms.assetid: e634dc37-d94e-4e9f-acf6-77f051ae2b9f
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManagerOffice2003::SetUseGlobalTheme
Specifies whether the visual manager uses a global theme.  
  
## Syntax  
  
```  
static void SetUseGlobalTheme(  
   BOOL bUseGlobalTheme = TRUE  
);  
```  
  
#### Parameters  
 [in] `bUseGlobalTheme`  
 `TRUE` if you want the visual manager to use a global theme; `FALSE` otherwise.  
  
## Remarks  
 If a `CMFCVisualManagerOffice2003` object uses a global theme, it draws the GUI elements by using the [CMFCVisualManagerWindows Class](../vs140/cmfcvisualmanagerwindows-class.md).  
  
 If a `CMFCVisualManagerOffice2003` object does not use a global theme, it draws the GUI elements by using the [CMFCVisualManagerOfficeXP Class](../vs140/cmfcvisualmanagerofficexp-class.md).  
  
## Requirements  
 **Header:** afxvisualmanageroffice2003.h  
  
## See Also  
 [CMFCVisualManagerOffice2003 Class](../vs140/cmfcvisualmanageroffice2003-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCVisualManagerOfficeXP Class](../vs140/cmfcvisualmanagerofficexp-class.md)   
 [CMFCVisualManagerWindows Class](../vs140/cmfcvisualmanagerwindows-class.md)