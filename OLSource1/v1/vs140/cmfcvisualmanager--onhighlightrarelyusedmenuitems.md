---
title: "CMFCVisualManager::OnHighlightRarelyUsedMenuItems"
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
  - "CMFCVisualManager::OnHighlightRarelyUsedMenuItems"
  - "CMFCVisualManager.OnHighlightRarelyUsedMenuItems"
  - "OnHighlightRarelyUsedMenuItems"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnHighlightRarelyUsedMenuItems method"
ms.assetid: eb578291-30fe-4d99-8bb7-6193e5c1210a
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManager::OnHighlightRarelyUsedMenuItems
The framework calls this method when it draws a highlighted menu command.  
  
## Syntax  
  
```  
virtual void OnHighlightRarelyUsedMenuItems(  
   CDC* pDC,  
   CRect rectRarelyUsed  
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to a device context.  
  
 [in] `rectRarelyUsed`  
 A rectangle that specifies the boundaries of the highlighted command.  
  
## Remarks  
 Override this method in a derived visual manager to customize the appearance of highlighted menu commands.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)