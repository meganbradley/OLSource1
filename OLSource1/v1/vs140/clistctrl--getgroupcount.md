---
title: "CListCtrl::GetGroupCount"
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
  - "GetGroupCount method"
  - "CListCtrl::GetGroupCount"
  - "CListCtrl.GetGroupCount"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetGroupCount method"
ms.assetid: 9748262f-449e-4449-95e7-2285325f5ea1
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListCtrl::GetGroupCount
Retrieves the number of groups in the current list-view control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The number of groups in the list-view control.  
  
## Remarks  
 This method sends the [LVM_GETGROUPCOUNT](http://msdn.microsoft.com/library/windows/desktop/bb774931) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
 This control is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [LVM_GETGROUPCOUNT](http://msdn.microsoft.com/library/windows/desktop/bb774931)