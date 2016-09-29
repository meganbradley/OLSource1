---
title: "CMFCVisualManager::SetEmbossDisabledImage"
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
  - "CMFCVisualManager.SetEmbossDisabledImage"
  - "CMFCVisualManager::SetEmbossDisabledImage"
  - "SetEmbossDisabledImage"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetEmbossDisabledImage method"
ms.assetid: a7efcfbe-c98c-4949-8a88-ca17244eb7e3
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManager::SetEmbossDisabledImage
Enables or disables the embossed mode for disabled toolbar images.  
  
## Syntax  
  
```  
void SetEmbossDisabledImage (  
   BOOL bEmboss = TRUE  
);  
```  
  
#### Parameters  
 [in] `bEmboss`  
 A Boolean parameter that indicates whether to enable embossed mode for disabled toolbar images.  
  
## Remarks  
 Use the function [CMFCVisualManager::IsEmbossDisabledImage](../vs140/cmfcvisualmanager--isembossdisabledimage.md) to determine whether embossed mode is enabled.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCVisualManager::IsEmbossDisabledImage](../vs140/cmfcvisualmanager--isembossdisabledimage.md)