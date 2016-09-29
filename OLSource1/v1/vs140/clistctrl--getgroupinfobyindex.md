---
title: "CListCtrl::GetGroupInfoByIndex"
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
  - "GetGroupInfoByIndex method"
  - "CListCtrl.GetGroupInfoByIndex"
  - "CListCtrl::GetGroupInfoByIndex"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetGroupInfoByIndex method"
ms.assetid: 6da6fae9-98df-432f-be4e-e9592e281c00
caps.latest.revision: 21
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListCtrl::GetGroupInfoByIndex
Retrieves information about a specified group in the current list-view control.  
  
## Syntax  
  
```  
BOOL GetGroupInfoByIndex(  
     int iIndex,   
     PLVGROUP pGroup  
) const;  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] `iIndex`|Zero-based index of a group.|  
|[out] `pGroup`|Pointer to an [LVGROUP](http://msdn.microsoft.com/library/windows/desktop/bb774769) structure that receives information about the group specified by the `iIndex` parameter.<br /><br /> The caller is responsible for initializing the members of the [LVGROUP](http://msdn.microsoft.com/library/windows/desktop/bb774769) structure. Set the `cbSize` member to the size of the structure, and the flags of the `mask` member to specify the information to retrieve.|  
  
## Return Value  
 `true` if this method is successful; otherwise, `false`.  
  
## Remarks  
 This method sends the [LVM_GETGROUPINFOBYINDEX](http://msdn.microsoft.com/library/windows/desktop/bb774933) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
 This control is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## Example  
 The following code example defines a variable, `m_listCtrl`, that is used to access the current list-view control. This variable is used in the next example.  
  
 [!code[NVC_MFC_CListCtrl_s2#6](../vs140/codesnippet/CPP/clistctrl--getgroupinfobyindex_1.h)]  
  
## Example  
 The following code example demonstrates the `GetGroupInfoByIndex` method. In an earlier section of this code example we created a list-view control that displays two columns titled "ClientID" and "Grade" in a report view. The following code example retrieves information about the group whose index is 0, if such a group exists.  
  
 [!code[NVC_MFC_CListCtrl_s2#2](../vs140/codesnippet/CPP/clistctrl--getgroupinfobyindex_2.cpp)]  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [LVM_GETGROUPINFOBYINDEX](http://msdn.microsoft.com/library/windows/desktop/bb774933)   
 [LVGROUP](http://msdn.microsoft.com/library/windows/desktop/bb774769)