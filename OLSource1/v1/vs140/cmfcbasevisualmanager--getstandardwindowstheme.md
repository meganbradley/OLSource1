---
title: "CMFCBaseVisualManager::GetStandardWindowsTheme"
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
  - "GetStandardWindowsTheme"
  - "CMFCBaseVisualManager.GetStandardWindowsTheme"
  - "CMFCBaseVisualManager::GetStandardWindowsTheme"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetStandardWindowsTheme method"
ms.assetid: 86ca4981-8f01-4e0b-8590-38ed09165c67
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCBaseVisualManager::GetStandardWindowsTheme
Gets the current Windows theme.  
  
## Syntax  
  
```  
virtual WinXpTheme GetStandardWindowsTheme();  
```  
  
## Return Value  
 The currently selected Windows Theme color. Can be one of the following enumerated values:  
  
-   `WinXpTheme_None` - there is no theme enabled.  
  
-   `WinXpTheme_NonStandard` - non standard theme is selected (meaning a theme is selected, but none from the list below).  
  
-   `WinXpTheme_Blue` - blue theme (Luna).  
  
-   `WinXpTheme_Olive` - olive theme.  
  
-   `WinXpTheme_Silver` - silver theme.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCBaseVisualManager Class](../vs140/cmfcbasevisualmanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)