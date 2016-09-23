---
title: "CMFCVisualManager::GetNcBtnSize"
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
  - CMFCVisualManager.GetNcBtnSize
  - CMFCVisualManager::GetNcBtnSize
  - GetNcBtnSize
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetNcBtnSize method
ms.assetid: 7d48bc42-9860-4c0d-9062-4eccee989979
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCVisualManager::GetNcBtnSize
Called by the framework when it has to retrieve the size of the system buttons.  
  
## Syntax  
  
```  
virtual CSize GetNcBtnSize(  
   BOOL bSmall   
) const;  
```  
  
#### Parameters  
 [in] `bSmall`  
 A Boolean parameter that indicates whether `GetNcBtnSize` should retrieve the size of a small or large system button. If `bSmall` is `TRUE`, `GetNcBtnSize` returns the size of a small system button. Otherwise, it returns the size of a large system button.  
  
## Return Value  
 A [CSize](../vs140/csize-class.md) parameter that indicate the size of the system buttons.  
  
## Remarks  
 The system buttons are the buttons in the caption of the frame window that map to the commands **Close**, **Minimize**, **Maximize**, and **Restore**. The size of these buttons depends on the current visual manager. Override this method if you want to customize the size of the system buttons in your application.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)