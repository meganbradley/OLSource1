---
title: "CListCtrl::GetItemIndexRect"
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
  - CListCtrl::GetItemIndexRect
  - GetItemIndexRect method
  - CListCtrl.GetItemIndexRect
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetItemIndexRect method
ms.assetid: 9616a79c-1cd5-45eb-a263-be355d39ed6c
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CListCtrl::GetItemIndexRect
Retrieves the bounding rectangle for all or part of a subitem in the current list-view control.  
  
## Syntax  
  
```  
BOOL GetItemIndexRect(  
     PLVITEMINDEX pItemIndex,   
     int iColumn,   
     int rectType,   
     LPRECT pRect  
) const;  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] `pItemIndex`|Pointer to an [LVITEMINDEX](http://msdn.microsoft.com/library/windows/desktop/bb774762) structure for the parent item of the subitem.<br /><br /> The caller is responsible for allocating and setting the members of the [LVITEMINDEX](http://msdn.microsoft.com/library/windows/desktop/bb774762) structure. This parameter cannot be `NULL`.|  
|[in] `iColumn`|Zero-based index of a column in the control.|  
|[in] `rectType`|Portion of the list-view subitem for which the bounding rectangle is retrieved. Specify one of the following values:<br /><br /> `LVIR_BOUNDS` - Returns the bounding rectangle of the entire subitem, including the icon and label.<br /><br /> `LVIR_ICON` - Returns the bounding rectangle of the icon or small icon of the subitem.<br /><br /> `LVIR_LABEL` - Returns the bounding rectangle of the subitem text.|  
|[out] `pRect`|Pointer to a [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure that receives information about the bounding rectangle of the subitem.<br /><br /> The caller is responsible for allocating the [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure. This parameter cannot be `NULL`.|  
  
## Return Value  
 `true` if this method is successful; otherwise, `false`.  
  
## Remarks  
 This method sends the [LVM_GETITEMINDEXRECT](http://msdn.microsoft.com/library/windows/desktop/bb761046) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. For more information, see [ListView_GetItemIndexRect Macro](http://msdn.microsoft.com/library/windows/desktop/bb774959).  
  
## Requirements  
 **Header:** afxcmn.h  
  
 This control is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## Example  
 The following code example defines a variable, `m_listCtrl`, that is used to access the current list-view control. This variable is used in the next example.  
  
 [!code[NVC_MFC_CListCtrl_s2#6](../vs140/codesnippet/CPP/clistctrl--getitemindexrect_1.h)]
  
  
## Example  
 The following code example demonstrates the `GetGroupRect` method. Prior to entering this code example we created a list-view control that displays two columns titled "ClientID" and "Grade" in a report view. The following code example draws a 3D rectangle around the second subitem in both columns.  
  
 [!code[NVC_MFC_CListCtrl_s2#4](../vs140/codesnippet/CPP/clistctrl--getitemindexrect_2.cpp)]
  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [LVM_GETITEMINDEXRECT](http://msdn.microsoft.com/library/windows/desktop/bb761046)   
 [LVITEMINDEX](http://msdn.microsoft.com/library/windows/desktop/bb774762)   
 [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897)   
 [ListView_GetItemIndexRect Macro](http://msdn.microsoft.com/library/windows/desktop/bb774959)