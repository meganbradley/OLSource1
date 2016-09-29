---
title: "CMFCVisualManager::GetCaptionBarTextColor"
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
  - "CMFCVisualManager.GetCaptionBarTextColor"
  - "CMFCVisualManager::GetCaptionBarTextColor"
  - "GetCaptionBarTextColor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetCaptionBarTextColor method"
ms.assetid: 49c8c028-070a-40ce-a3a4-59ff9ea5d535
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManager::GetCaptionBarTextColor
The framework calls this method to retrieve the color of the text in the caption bar.  
  
## Syntax  
  
```  
virtual COLORREF GetCaptionBarTextColor(  
   CMFCCaptionBar* pBar   
);  
```  
  
#### Parameters  
 [in] `pBar`  
 A pointer to a caption bar.  
  
## Return Value  
 A [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) parameter that indicates the color of the text in `pBar`.  
  
## Remarks  
 Override this method in your derived class to customize the text color for a caption bar. In your overridden method, return the desired color.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCCaptionBar Class](../vs140/cmfccaptionbar-class.md)