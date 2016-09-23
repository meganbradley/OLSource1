---
title: "CDragListBox::Dragging"
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
  - DL_STOPCURSOR
  - DL_COPYCURSOR
  - CDragListBox::Dragging
  - CDragListBox.Dragging
  - Dragging
  - DL_MOVECURSOR
dev_langs: 
  - C++
helpviewer_keywords: 
  - CDragListBox class, overridables
  - Dragging method
  - DL_STOPCURSOR
  - DL_MOVECURSOR
  - DL_COPYCURSOR
ms.assetid: 2e4fad60-4016-41fc-afd7-187e718a467d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDragListBox::Dragging
Called by the framework when a list box item is being dragged within the `CDragListBox` object.  
  
## Syntax  
  
```  
  
      virtual UINT Dragging(  
   CPoint pt   
);  
```  
  
#### Parameters  
 `pt`  
 A [CPoint](../vs140/cpoint-class.md) object that contains the x and y screen coordinates of the cursor.  
  
## Return Value  
 The resource ID of the cursor to be displayed. The following values are possible:  
  
-   `DL_COPYCURSOR` Indicates that the item will be copied.  
  
-   `DL_MOVECURSOR` Indicates that the item will be moved.  
  
-   `DL_STOPCURSOR` Indicates that the current drop target is not acceptable.  
  
## Remarks  
 The default behavior returns `DL_MOVECURSOR`. Override this function if you want to provide additional functionality.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CDragListBox Class](../vs140/cdraglistbox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDragListBox::BeginDrag](../vs140/cdraglistbox--begindrag.md)   
 [CDragListBox::CancelDrag](../vs140/cdraglistbox--canceldrag.md)