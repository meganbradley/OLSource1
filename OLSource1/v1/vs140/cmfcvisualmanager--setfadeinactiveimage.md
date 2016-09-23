---
title: "CMFCVisualManager::SetFadeInactiveImage"
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
  - SetFadeInactiveImage
  - CMFCVisualManager::SetFadeInactiveImage
  - CMFCVisualManager.SetFadeInactiveImage
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetFadeInactiveImage method
ms.assetid: aa97ba7c-4729-4b9c-9fcf-d83e229687a3
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCVisualManager::SetFadeInactiveImage
Enables or disables the lighting effect for inactive images on a menu or toolbar.  
  
## Syntax  
  
```  
void SetFadeInactiveImage(  
   BOOL bFade = TRUE  
);  
```  
  
#### Parameters  
 [in] `bFade`  
 A Boolean parameter that specifies whether to enable the lighting effect.  
  
## Remarks  
 This feature controls whether inactive images appear faded on a menu or toolbar. Use the method [CMFCVisualManager::IsFadeInactiveImage](../vs140/cmfcvisualmanager--isfadeinactiveimage.md) to determine whether this feature is enabled.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCVisualManager::IsFadeInactiveImage](../vs140/cmfcvisualmanager--isfadeinactiveimage.md)