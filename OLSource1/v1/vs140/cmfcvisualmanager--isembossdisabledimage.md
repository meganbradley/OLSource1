---
title: "CMFCVisualManager::IsEmbossDisabledImage"
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
  - CMFCVisualManager.IsEmbossDisabledImage
  - CMFCVisualManager::IsEmbossDisabledImage
  - IsEmbossDisabledImage
dev_langs: 
  - C++
helpviewer_keywords: 
  - IsEmbossDisabledImage method
ms.assetid: d2b297a1-759e-411d-b8c3-6d1a15ffdd60
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCVisualManager::IsEmbossDisabledImage
Specifies whether the framework embosses images that are unavailable.  
  
## Syntax  
  
```  
BOOL IsEmbossDisabledImage() const;  
```  
  
## Return Value  
 Nonzero if the framework embosses images that are unavailable; otherwise 0.  
  
## Remarks  
 This method is called by [CMFCToolBarImages::Draw](../vs140/cmfctoolbarimages--draw.md) when it draws an image on the toolbar that is unavailable.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCVisualManager::SetEmbossDisabledImage](../vs140/cmfcvisualmanager--setembossdisabledimage.md)