---
title: "CMFCRibbonBar::HitTest"
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
  - "CMFCRibbonBar.HitTest"
  - "HitTest"
  - "CMFCRibbonBar::HitTest"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "HitTest method"
ms.assetid: 235c032a-727d-4608-a90c-1f28b6639975
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonBar::HitTest
Retrieves a pointer to the ribbon element specified by the location of the point.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Location of the point in ribbon bar coordinates.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to search the active category; <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> not to search the active category.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to test the caption of the ribbon panel with the point located in it; <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> not to test the caption of the ribbon panel with the point located in it. See the Remarks section for more information.  
  
## Return Value  
 A pointer to the ribbon element located at the specified point; otherwise <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> if the point is not located in a ribbon element.  
  
## Remarks  
 The caption of the ribbon panel with the point located in it is not tested unless the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> parameter is <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxribbonbar.h  
  
## See Also  
 [CMFCRibbonBar Class](../vs140/cmfcribbonbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)