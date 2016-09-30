---
title: "CListCtrl::SetHotCursor"
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
  - "CListCtrl::SetHotCursor"
  - "CListCtrl.SetHotCursor"
  - "SetHotCursor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetHotCursor method"
ms.assetid: 166bdf64-790a-4614-9e7c-1a46cc93f6fe
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListCtrl::SetHotCursor
Sets the cursor used when hot tracking is enabled for a list view control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *hc*  
 A handle to a cursor resource, used to represent the hot cursor.  
  
## Return Value  
 The handle to the previous hot cursor resource being used by the list view control.  
  
## Remarks  
 This member function implements the behavior of the Win32 macro, [ListView_SetHotCursor](http://msdn.microsoft.com/library/windows/desktop/bb775082), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 The hot cursor, only visible when hover selection is enabled, appears as the cursor passes over any list view item. Hover selection is enabled by setting the **LVS_EX_TRACKSELECT** extended style.  
  
## Example  
 See the example for [CListCtrl::GetHotCursor](../vs140/clistctrl--gethotcursor.md).  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListCtrl::GetHotCursor](../vs140/clistctrl--gethotcursor.md)   
 [CListCtrl::GetHotItem](../vs140/clistctrl--gethotitem.md)