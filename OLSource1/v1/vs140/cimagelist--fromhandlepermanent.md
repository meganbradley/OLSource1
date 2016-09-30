---
title: "CImageList::FromHandlePermanent"
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
  - "CImageList.FromHandlePermanent"
  - "CImageList::FromHandlePermanent"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FromHandlePermanent method"
ms.assetid: a1bef964-a759-49a1-b27d-f4bc697a30d2
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CImageList::FromHandlePermanent
Returns a pointer to a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object when given a handle to an image list.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the image list.  
  
## Return Value  
 A pointer to a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object if successful; otherwise **NULL**.  
  
## Remarks  
 If a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object is not attached to the handle, **NULL** is returned.  
  
## Example  
 [!code[NVC_MFC_CImageList#14](../vs140/codesnippet/CPP/cimagelist--fromhandlepermanent_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CImageList Class](../vs140/cimagelist-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CImageList::FromHandle](../vs140/cimagelist--fromhandle.md)