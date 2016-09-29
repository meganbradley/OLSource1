---
title: "CListCtrl::GetGroupRect"
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
  - "CListCtrl.GetGroupRect"
  - "GetGroupRect method"
  - "CListCtrl::GetGroupRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetGroupRect method"
ms.assetid: 73d6f93f-72d4-4126-8a87-7742ff1bbfbd
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListCtrl::GetGroupRect
Retrieves the bounding rectangle for a specified group in the current list-view control.  
  
## Syntax  
  
```  
BOOL GetGroupRect(  
     int iGroupId,   
     LPRECT lpRect,   
     int iCoords = LVGGR_GROUP  
) const;  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] `iGroupId`|Specifies a group.|  
|[in, out] `lpRect`|Pointer to a [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure. If this method is successful, the structure receives the rectangle coordinates of the group that is specified by `iGroupId`.|  
|[in] `iCoords`|Specifies the rectangle coordinates to retrieve. Use one of these values:<br /><br /> -   `LVGGR_GROUP` - (Default) Coordinates of the entire expanded group.<br />-   `LVGGR_HEADER` - Coordinates of only the header (collapsed group).<br />-   `LVGGR_SUBSETLINK` - Coordinates of only the subset link (markup subset).|  
  
## Return Value  
 `true` if this method is successful; otherwise, `false`.  
  
## Remarks  
 The caller is responsible for allocating the [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure pointed to by the `pRect` parameter.  
  
 This method sends the [LVM_GETGROUPRECT](http://msdn.microsoft.com/library/windows/desktop/bb774935) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
 This control is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## Example  
 The following code example defines a variable, `m_listCtrl`, that is used to access the current list-view control. This variable is used in the next example.  
  
 [!code[NVC_MFC_CListCtrl_s2#6](../vs140/codesnippet/CPP/clistctrl--getgrouprect_1.h)]  
  
## Example  
 The following code example demonstrates the `GetGroupRect` method. In an earlier section of this code example, we created a list-view control that displays two columns titled "ClientID" and "Grade" in a report view. The following code example draws a 3D rectangle around the group whose index is 0, if such a group exists.  
  
 [!code[NVC_MFC_CListCtrl_s2#5](../vs140/codesnippet/CPP/clistctrl--getgrouprect_2.cpp)]  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [LVM_GETGROUPRECT](http://msdn.microsoft.com/library/windows/desktop/bb774935)   
 [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897)