---
title: "CMFCVisualManager::OnDrawDefaultRibbonImage"
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
  - "OnDrawDefaultRibbonImage"
  - "CMFCVisualManager::OnDrawDefaultRibbonImage"
  - "CMFCVisualManager.OnDrawDefaultRibbonImage"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawDefaultRibbonImage method"
ms.assetid: 29a72b2e-fadc-42e1-936d-7b04ef56b964
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManager::OnDrawDefaultRibbonImage
The framework calls this method when it draws the default image that is used for the ribbon button.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the default image.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether the ribbon button is unavailable.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether the ribbon button is pressed.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether the ribbon button is highlighted.  
  
## Remarks  
 Override this method in a derived visual manager if you want to customize the image that is used for the ribbon button.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)