---
title: "CMFCVisualManager::GetAutoHideButtonTextColor"
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
  - "GetAutoHideButtonTextColor"
  - "CMFCVisualManager.GetAutoHideButtonTextColor"
  - "CMFCVisualManager::GetAutoHideButtonTextColor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetAutoHideButtonTextColor method"
ms.assetid: 98103a28-ad00-4b9a-a48c-a734a5005e2d
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManager::GetAutoHideButtonTextColor
The framework calls this method to retrieve the text color of an auto-hide button.  
  
## Syntax  
  
```  
virtual COLORREF GetAutoHideButtonTextColor(  
   CMFCAutoHideButton* pButton   
);  
```  
  
#### Parameters  
 [in] `pButton`  
 A pointer to an auto-hide button.  
  
## Return Value  
 A [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) parameter that specifies the text color of `pButton`.  
  
## Remarks  
 Override this method in a derived class to customize the text color of an auto-hide button in your application. To do this, return the color that you want your application to use as the text color.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)