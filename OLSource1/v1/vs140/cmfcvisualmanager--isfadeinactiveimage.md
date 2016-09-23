---
title: "CMFCVisualManager::IsFadeInactiveImage"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CMFCVisualManager.IsFadeInactiveImage
  - IsFadeInactiveImage
  - CMFCVisualManager::IsFadeInactiveImage
dev_langs: 
  - C++
helpviewer_keywords: 
  - IsFadeInactiveImage method
ms.assetid: 37205b88-9054-4b47-9250-d68360217ded
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCVisualManager::IsFadeInactiveImage
The framework calls this method when it draws inactive images on the toolbar or in a menu.  
  
## Syntax  
  
```  
BOOL IsFadeInactiveImage() const;  
```  
  
## Return Value  
 Nonzero if the framework uses the lighting effect when it draws inactive images on the toolbar or in a menu; otherwise 0.  
  
## Remarks  
 You can activate or deactivate the lighting effect by calling [CMFCVisualManager::SetFadeInactiveImage](../vs140/cmfcvisualmanager--setfadeinactiveimage.md). The lighting effect is what makes unavailable images appear faded.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCVisualManager::SetFadeInactiveImage](../vs140/cmfcvisualmanager--setfadeinactiveimage.md)