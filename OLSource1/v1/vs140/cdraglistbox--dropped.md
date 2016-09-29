---
title: "CDragListBox::Dropped"
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
  - "Dropped"
  - "CDragListBox::Dropped"
  - "CDragListBox.Dropped"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Dropped method"
  - "CDragListBox class, overridables"
ms.assetid: abbbd0a7-d5c2-46ba-96a7-b95c3e84e088
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDragListBox::Dropped
Called by the framework when an item is dropped within a `CDragListBox` object.  
  
## Syntax  
  
```  
  
      virtual void Dropped(  
   int nSrcIndex,  
   CPoint pt   
);  
```  
  
#### Parameters  
 *nSrcIndex*  
 Specifies the zero-based index of the dropped string.  
  
 `pt`  
 A [CPoint](../vs140/cpoint-class.md) object that contains the coordinates of the drop site.  
  
## Remarks  
 The default behavior copies the list box item and its data to the new location and then deletes the original item. Override this function to customize the default behavior, such as enabling copies of list box items to be dragged to other locations within the list.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CDragListBox Class](../vs140/cdraglistbox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDragListBox::BeginDrag](../vs140/cdraglistbox--begindrag.md)