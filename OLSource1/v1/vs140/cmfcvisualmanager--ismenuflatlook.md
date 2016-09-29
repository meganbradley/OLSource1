---
title: "CMFCVisualManager::IsMenuFlatLook"
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
  - "CMFCVisualManager::IsMenuFlatLook"
  - "CMFCVisualManager.IsMenuFlatLook"
  - "IsMenuFlatLook"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsMenuFlatLook method"
ms.assetid: c1efd408-a181-486c-bb49-56ab738bf8a5
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManager::IsMenuFlatLook
Indicates whether menu buttons appear flat.  
  
## Syntax  
  
```  
BOOL IsMenuFlatLook() const;  
```  
  
## Return Value  
 Nonzero if menu buttons appear flat; 0 otherwise.  
  
## Remarks  
 By default, menu buttons do not appear flat. Use the [CMFCVisualManager::SetMenuFlatLook](../vs140/cmfcvisualmanager--setmenuflatlook.md) method to change this behavior. When menu buttons appear flat, they do not change appearance when the user clicks on them.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCVisualManager::SetMenuFlatLook](../vs140/cmfcvisualmanager--setmenuflatlook.md)