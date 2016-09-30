---
title: "CHeaderCtrl::GetItem"
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
  - "HDF_STRING"
  - "HDF_LEFT"
  - "HDI_WIDTH"
  - "HDF_RIGHT"
  - "HDI_TEXT"
  - "HDI_BITMAP"
  - "HDF_BITMAP"
  - "HDI_LPARAM"
  - "CHeaderCtrl.GetItem"
  - "HDF_OWNERDRAW"
  - "HDI_FORMAT"
  - "CHeaderCtrl::GetItem"
  - "HD_ITEM"
  - "HDI_HEIGHT"
  - "HDF_CENTER"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetItem method [MFC]"
  - "HDF_LEFT"
  - "HDF_RIGHT"
  - "HDI_HEIGHT"
  - "HDI_LPARAM"
  - "HDF_STRING"
  - "HD_ITEM"
  - "HDF_BITMAP"
  - "HDI_TEXT"
  - "HDI_WIDTH"
  - "HDF_OWNERDRAW"
  - "HDI_BITMAP"
  - "HDF_CENTER"
  - "HDI_FORMAT"
ms.assetid: 931dc9cc-a41f-484e-8130-724b570311a8
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHeaderCtrl::GetItem
Retrieves information about a header control item.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the zero-based index of the item to retrieve.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to an [HDITEM](http://msdn.microsoft.com/library/windows/desktop/bb775247) structure that receives the new item. This structure is used with the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> member functions. Any flags set in the **mask** element ensure that values in the corresponding elements are properly filled in upon return. If the **mask** element is set to zero, values in the other structure elements are meaningless.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Example  
 [!code[NVC_MFC_CHeaderCtrl#10](../vs140/codesnippet/CPP/cheaderctrl--getitem_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CHeaderCtrl Class](../vs140/cheaderctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CHeaderCtrl::SetItem](../vs140/cheaderctrl--setitem.md)