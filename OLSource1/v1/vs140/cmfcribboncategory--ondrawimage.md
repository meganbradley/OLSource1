---
title: "CMFCRibbonCategory::OnDrawImage"
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
  - "CMFCRibbonCategory::OnDrawImage"
  - "CMFCRibbonCategory.OnDrawImage"
  - "OnDrawImage"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawImage method"
ms.assetid: 8fc7a779-c42d-403c-8b24-83d265c4e3b7
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonCategory::OnDrawImage
Called by the framework to draw the specified image on the ribbon category.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to a device context for the image.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Display rectangle for the image.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Pointer to the ribbon element that contains the image.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if the image is the large size; <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> if the image is the small size.  
  
 [in] <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Zero-based index of the image in the image array that is contained in the ribbon category.  
  
 [in] <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to center the image in the display rectangle; <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to draw the image in the upper-left corner of the display rectangle.  
  
## Return Value  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> if the method was successful; otherwise <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
## Remarks  
  
## Requirements  
 **Header:** afxribboncategory.h  
  
## See Also  
 [CMFCRibbonCategory Class](../vs140/cmfcribboncategory-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)