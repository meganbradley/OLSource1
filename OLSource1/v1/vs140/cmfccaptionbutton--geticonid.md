---
title: "CMFCCaptionButton::GetIconID"
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
  - "CMFCCaptionButton.GetIconID"
  - "CMFCCaptionButton::GetIconID"
  - "GetIconID"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetIconID method"
ms.assetid: 924cbe58-a675-4ecb-87e4-9c0fe0a367d6
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCCaptionButton::GetIconID
Returns the image ID associated with the button.  
  
## Syntax  
  
```  
virtual CMenuImages::IMAGES_IDS GetIconID(  
   BOOL bHorz,  
   BOOL bMaximized = FALSE  
) const;  
```  
  
#### Parameters  
 [in] `bHorz`  
 `TRUE` for left or right arrow image IDs; `FALSE` for up or down arrow image IDs.  
  
 [in] `bMaximized`  
 `TRUE` for a maximize image ID; `FALSE` for a minimize image ID.  
  
## Return Value  
 The image ID.  
  
## Remarks  
 The parameters specify image IDs for minimize or maximize caption buttons.  
  
## Requirements  
 **Header:** afxcaptionbutton.h  
  
## See Also  
 [CMFCCaptionButton Class](../vs140/cmfccaptionbutton-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)