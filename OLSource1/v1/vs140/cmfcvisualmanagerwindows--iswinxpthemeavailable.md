---
title: "CMFCVisualManagerWindows::IsWinXPThemeAvailable"
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
  - "CMFCVisualManagerWindows.IsWindowsThemingAvailable"
  - "IsWindowsThemingAvailable"
  - "CMFCVisualManagerWindows::IsWindowsThemingAvailable"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsWindowsThemingAvailable method"
ms.assetid: 2801b6a1-b957-4aea-b3d7-e7c388d04ccc
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManagerWindows::IsWinXPThemeAvailable
Determines whether a Windows XP or [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)] theme is available.  
  
## Syntax  
  
```  
static BOOL IsWinXPThemeAvailible();  
```  
  
## Return Value  
 Nonzero if a theme is available; otherwise 0.  
  
## Remarks  
 This method is valid for both Windows XP and [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)] themes.  
  
 `IsWinXPThemeAvailable` is identical to `CMFCVisualManagerWindows::IsWindowsThemingAvailable` except that `IsWinXPThemeAvailable` is a static method. Therefore, it will create a temporary visual manager if one does not exist.  
  
 `IsWinXPThemeAvailable` always return 0s for versions of Windows earlier than Windows XP.  
  
## Requirements  
 **Header:** afxvisualmanagerwindows.h  
  
## See Also  
 [CMFCVisualManagerWindows Class](../vs140/cmfcvisualmanagerwindows-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)