---
title: "CListCtrl::SetTileViewInfo"
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
  - "CListCtrl.SetTileViewInfo"
  - "CListCtrl::SetTileViewInfo"
  - "SetTileViewInfo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetTileViewInfo method"
ms.assetid: 91e37826-c065-45b2-8f8e-969658b033b3
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListCtrl::SetTileViewInfo
Sets information that a list view control uses in tile view.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to an [LVTILEVIEWINFO](http://msdn.microsoft.com/library/windows/desktop/bb774768) structure containing the information to set.  
  
## Return Value  
 Returns **TRUE** on success, **FALSE** on failure.  
  
## Remarks  
 This member function emulates the functionality of the [LVM_SETTILEVIEWINFO](http://msdn.microsoft.com/library/windows/desktop/bb761212) message, as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)