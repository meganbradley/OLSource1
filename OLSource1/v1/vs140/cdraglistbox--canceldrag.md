---
title: "CDragListBox::CancelDrag"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CDragListBox::CancelDrag
  - CancelDrag
  - CDragListBox.CancelDrag
dev_langs: 
  - C++
helpviewer_keywords: 
  - CDragListBox class, overridables
  - CancelDrag method
ms.assetid: ec2bf084-4dd3-450e-98bf-d17110a19cc0
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDragListBox::CancelDrag
Called by the framework when a drag operation has been canceled.  
  
## Syntax  
  
```  
  
      virtual void CancelDrag(  
   CPoint pt   
);  
```  
  
#### Parameters  
 `pt`  
 A [CPoint](../vs140/cpoint-class.md) object that contains the coordinates of the item being dragged.  
  
## Remarks  
 Override this function to handle any special processing for your list box control.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CDragListBox Class](../vs140/cdraglistbox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDragListBox::BeginDrag](../vs140/cdraglistbox--begindrag.md)   
 [CDragListBox::Dragging](../vs140/cdraglistbox--dragging.md)