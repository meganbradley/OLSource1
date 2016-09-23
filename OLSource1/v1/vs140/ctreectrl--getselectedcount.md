---
title: "CTreeCtrl::GetSelectedCount"
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
  - GetSelectedCount method
  - CTreeCtrl.GetSelectedCount
  - CTreeCtrl::GetSelectedCount
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetSelectedCount method
ms.assetid: 4975e71d-6e9b-4411-9ff8-4f8011306ded
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CTreeCtrl::GetSelectedCount
Retrieves the number of selected items in the current tree-view control.  
  
## Syntax  
  
```  
UINT GetSelectedCount();  
```  
  
## Return Value  
 The number of selected items.  
  
## Remarks  
 This method sends the [TVM_GETSELECTEDCOUNT](http://msdn.microsoft.com/library/windows/desktop/bb773629) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
 This method is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## See Also  
 [CTreeCtrl Class](../vs140/ctreectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [TVM_GETSELECTEDCOUNT](http://msdn.microsoft.com/library/windows/desktop/bb773629)