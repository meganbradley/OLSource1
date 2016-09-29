---
title: "CMFCColorPopupMenu::CreateTearOffBar"
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
  - "CreateTearOffBar"
  - "CMFCColorPopupMenu.CreateTearOffBar"
  - "CMFCColorPopupMenu::CreateTearOffBar"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateTearOffBar method"
ms.assetid: 48d8d08e-4b5d-452c-bd3a-89c5588e43ca
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCColorPopupMenu::CreateTearOffBar
Creates a dockable tear-off color bar.  
  
## Syntax  
  
```  
virtual CPane* CreateTearOffBar(  
   CFrameWnd* pWndMain,  
   UINT uiID,  
   LPCTSTR lpszName  
);  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] `pWndMain`|Pointer to the parent window of the tear-off bar.|  
|[in] `uiID`|The command ID of the tear-off bar.|  
|[in] `lpszName`|The window text of the tear-off bar.|  
  
## Return Value  
 A pointer to the new tear-off control bar object.  
  
## Remarks  
 This method creates a [CMFCColorBar](../vs140/cmfccolorbar-class.md) object and casts it to a [CPane](../vs140/cpane-class.md) pointer. You can cast this value back to a [CMFCColorBar](../vs140/cmfccolorbar-class.md) pointer by using one of the casting macros described in [Type Casting of MFC Class Objects](../vs140/type-casting-of-mfc-class-objects.md).  
  
## Requirements  
 **Header:** afxcolorpopupmenu.h  
  
## See Also  
 [CMFCColorPopupMenu Class](../vs140/cmfccolorpopupmenu-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CFrameWnd Class](../vs140/cframewnd-class.md)   
 [CMFCColorBar](../vs140/cmfccolorbar-class.md)   
 [Type Casting of MFC Class Objects](../vs140/type-casting-of-mfc-class-objects.md)