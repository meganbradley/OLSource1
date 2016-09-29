---
title: "CMFCCaptionBar::GetAlignment"
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
  - "CMFCCaptionBar::GetAlignment"
  - "GetAlignment"
  - "CMFCCaptionBar.GetAlignment"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetAlignment method"
ms.assetid: eee4c88a-bc41-4141-b750-1fceda2b92c8
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCCaptionBar::GetAlignment
Returns the alignment of the specified element.  
  
## Syntax  
  
```  
BarElementAlignment GetAlignment(  
   BarElement elem   
);  
```  
  
#### Parameters  
 [in] `elem`  
 A caption bar element for which to retrieve alignment.  
  
## Return Value  
 The alignment of an element, such as a button, a bitmap, text, or an icon.  
  
## Remarks  
 The alignment of the element can be one of the following values:  
  
-   ALIGN_INVALID  
  
-   ALIGN_LEFT  
  
-   ALIGN_RIGHT  
  
-   ALIGN_CENTER  
  
## Requirements  
 **Header:** afxcaptionbar.h  
  
## See Also  
 [CMFCCaptionBar Class](../vs140/cmfccaptionbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)