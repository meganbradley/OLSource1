---
title: "CImageList::SetBkColor"
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
  - "CImageList::SetBkColor"
  - "CImageList.SetBkColor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetBkColor method"
ms.assetid: a82a57ff-989e-4d22-8a08-4e44d964da4a
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CImageList::SetBkColor
Call this function to set the background color for an image list.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Background color to set. It can be <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. In that case, images are drawn transparently using the mask.  
  
## Return Value  
 The previous background color if successful; otherwise <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Example  
 [!code[NVC_MFC_CImageList#20](../vs140/codesnippet/CPP/cimagelist--setbkcolor_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CImageList Class](../vs140/cimagelist-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CImageList::GetBkColor](../vs140/cimagelist--getbkcolor.md)   
 [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449)