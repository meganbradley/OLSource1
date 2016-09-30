---
title: "CMFCToolBarImages::PrepareDrawImage"
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
  - "PrepareDrawImage"
  - "CMFCToolBarImages.PrepareDrawImage"
  - "CMFCToolBarImages::PrepareDrawImage"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PrepareDrawImage method"
ms.assetid: 07e47392-d163-4734-a6e5-7b7f9ae8635f
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarImages::PrepareDrawImage
Allocates the resources that are required to draw a toolbar image at a specified size.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A reference to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> structure, which stores the allocated resources between image rendering stages.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the size of a destination image.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if you want inactive images to be drawn faded.  
  
## Return Value  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> if the resources required to draw the toolbar image were allocated successfully, otherwise <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Remarks  
 After you call this method, you can call [CMFCToolBarImages::Draw](../vs140/cmfctoolbarimages--draw.md) any number of times. After you finished drawing, you must call [CMFCToolBarImages::EndDrawImage](../vs140/cmfctoolbarimages--enddrawimage.md) to release the resources allocated by <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxtoolbarimages.h  
  
## See Also  
 [CMFCToolBarImages Class](../vs140/cmfctoolbarimages-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)