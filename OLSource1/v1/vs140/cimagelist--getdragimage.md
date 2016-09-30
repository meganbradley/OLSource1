---
title: "CImageList::GetDragImage"
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
  - "GetDragImage"
  - "CImageList.GetDragImage"
  - "CImageList::GetDragImage"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetDragImage method"
ms.assetid: 3fe7cea9-e3d0-4165-9c7d-a2762da2fda0
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CImageList::GetDragImage
Gets the temporary image list that is used for dragging.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Address of a [POINT](http://msdn.microsoft.com/library/windows/desktop/dd162805) structure that receives the current drag position.  
  
 *lpPointHotSpot*  
 Address of a **POINT** structure that receives the offset of the drag image relative to the drag position.  
  
## Return Value  
 If successful, a pointer to the temporary image list that is used for dragging; otherwise, **NULL**.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CImageList Class](../vs140/cimagelist-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CImageList::SetDragCursorImage](../vs140/cimagelist--setdragcursorimage.md)