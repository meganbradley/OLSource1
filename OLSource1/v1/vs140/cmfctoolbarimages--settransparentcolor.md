---
title: "CMFCToolBarImages::SetTransparentColor"
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
  - "CMFCToolBarImages::SetTransparentColor"
  - "SetTransparentColor"
  - "CMFCToolBarImages.SetTransparentColor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetTransparentColor method"
ms.assetid: 2892ddb1-eef9-48db-be53-a6409d742367
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarImages::SetTransparentColor
Sets the transparent color of the toolbar images.  
  
## Syntax  
  
```  
COLORREF SetTransparentColor(  
   COLORREF clrTransparent   
);  
```  
  
#### Parameters  
 [in] `clrTransparent`  
 An RGB value.  
  
## Return Value  
 The previous transparent color.  
  
## Remarks  
 When you or the framework call [CMFCToolBarImages::Draw](../vs140/cmfctoolbarimages--draw.md), the method does not draw any pixel that matches the color specified by `clrTransparent`.  
  
## Requirements  
 **Header:** afxtoolbarimages.h  
  
## See Also  
 [CMFCToolBarImages Class](../vs140/cmfctoolbarimages-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)