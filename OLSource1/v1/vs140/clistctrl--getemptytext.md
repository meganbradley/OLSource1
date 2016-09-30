---
title: "CListCtrl::GetEmptyText"
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
  - "CListCtrl::GetEmptyText"
  - "GetEmptyText method"
  - "CListCtrl.GetEmptyText"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetEmptyText method"
ms.assetid: 8949ba0c-c3fe-4570-b913-e86240905f7e
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListCtrl::GetEmptyText
Retrieves the string to display if the current list-view control is empty.  
  
## Syntax  
  
```  
CString GetEmptyText() const;  
```  
  
## Return Value  
 A [CString](../vs140/using-cstring.md) that contains the text to display if the control is empty.  
  
## Remarks  
 This method sends the [LVM_GETEMPTYTEXT](http://msdn.microsoft.com/library/windows/desktop/bb774921) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
 This control is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [LVM_GETEMPTYTEXT](http://msdn.microsoft.com/library/windows/desktop/bb774921)   
 [CString](../vs140/using-cstring.md)