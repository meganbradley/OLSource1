---
title: "CListCtrl::SetGroupInfo"
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
  - "CListCtrl::SetGroupInfo"
  - "SetGroupInfo"
  - "CListCtrl.SetGroupInfo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetGroupInfo method"
ms.assetid: 76a0807b-b4c6-4ddf-8a6b-0d12a58ad369
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListCtrl::SetGroupInfo
Sets the information that describes the specified group of the current list-view control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The identifier of the group whose information is set.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to an [LVGROUP](http://msdn.microsoft.com/library/windows/desktop/bb774769) structure that contains the information to set. The caller is responsible for allocating this structure and setting its members.  
  
## Return Value  
 The ID of the group if the method is successful; otherwise, -1.  
  
## Remarks  
 This method sends the [LVM_SETGROUPINFO](http://msdn.microsoft.com/library/windows/desktop/bb761167) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
 This control is supported in Windows XP and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [LVM_SETGROUPINFO](http://msdn.microsoft.com/library/windows/desktop/bb761167)   
 [CListCtrl::GetGroupInfo](../vs140/clistctrl--getgroupinfo.md)