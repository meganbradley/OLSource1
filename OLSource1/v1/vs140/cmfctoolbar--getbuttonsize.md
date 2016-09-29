---
title: "CMFCToolBar::GetButtonSize"
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
  - "GetButtonSize"
  - "CMFCToolBar::GetButtonSize"
  - "CMFCToolBar.GetButtonSize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetButtonSize method"
ms.assetid: f710a4b6-4aa7-4370-8e48-b7cd8ae1885b
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::GetButtonSize
Returns the dimensions of each button on the toolbar.  
  
## Syntax  
  
```  
CSize GetButtonSize() const;  
```  
  
## Return Value  
 A [CSize](../vs140/csize-class.md) object that specifies the dimensions of each button on the toolbar.  
  
## Remarks  
 Call [CMFCToolBar::SetSizes](../vs140/cmfctoolbar--setsizes.md) or [CMFCToolBar::SetLockedSizes](../vs140/cmfctoolbar--setlockedsizes.md) to set the dimensions of each button on the toolbar.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)