---
title: "CListCtrl::SetSelectionMark"
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
  - "CListCtrl.SetSelectionMark"
  - "SetSelectionMark"
  - "CListCtrl::SetSelectionMark"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetSelectionMark method"
ms.assetid: cc5ddcd6-974c-4e0c-a463-3a04d230f48a
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListCtrl::SetSelectionMark
Sets the selection mark of a list view control.  
  
## Syntax  
  
```  
  
      int SetSelectionMark(  
   int iIndex   
);  
```  
  
#### Parameters  
 `iIndex`  
 The zero-based index of the first item in a multiple selection.  
  
## Return Value  
 The previous selection mark, or -1 if there was no selection mark.  
  
## Remarks  
 This member function implements the behavior of the Win32 macro, [ListView_SetSelectionMark](http://msdn.microsoft.com/library/windows/desktop/bb775112), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 See the example for [CListCtrl::GetSelectionMark](../vs140/clistctrl--getselectionmark.md).  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListCtrl::GetSelectionMark](../vs140/clistctrl--getselectionmark.md)