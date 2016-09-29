---
title: "CMenu::SetMenuItemInfo"
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
  - "CMenu::SetMenuItemInfo"
  - "CMenu.SetMenuItemInfo"
  - "SetMenuItemInfo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetMenuItemInfo method"
ms.assetid: 0f6ba884-cd93-4794-acba-1a155f7de446
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMenu::SetMenuItemInfo
Changes information about a menu item.  
  
## Syntax  
  
```  
  
      BOOL SetMenuItemInfo(  
   UINT uItem,  
   LPMENUITEMINFO lpMenuItemInfo,  
   BOOL fByPos = FALSE  
);  
```  
  
#### Parameters  
 `uItem`  
 See description of `uItem` in [SetMenuItemInfo](http://msdn.microsoft.com/library/windows/desktop/ms648001) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 `lpMenuItemInfo`  
 See description of `lpmii` in **SetMenuItemInfo** in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 `fByPos`  
 See description of `fByPosition` in **SetMenuItemInfo** in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Remarks  
 This function wraps [SetMenuItemInfo](http://msdn.microsoft.com/library/windows/desktop/ms648001), described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CMenu Class](../vs140/cmenu-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)