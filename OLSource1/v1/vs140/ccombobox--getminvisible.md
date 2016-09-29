---
title: "CComboBox::GetMinVisible"
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
  - "CCombobox::GetMinVisible"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetMinVisibleItems method"
ms.assetid: d24382fe-947e-4468-b8db-4139230049c0
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComboBox::GetMinVisible
Gets the minimum number of visible items in the drop-down list of the current combo box control.  
  
## Syntax  
  
```  
int GetMinVisible() const;  
```  
  
## Return Value  
 The minimum number of visible items in the current drop-down list.  
  
## Remarks  
 This method sends the [CB_GETMINVISIBLE](http://msdn.microsoft.com/library/windows/desktop/bb775915) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxwin.h  
  
 This method is supported in Windows XP and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## See Also  
 [CComboBox Class](../vs140/ccombobox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CComboBox::SetMinVisibleItems](../vs140/ccombobox--setminvisibleitems.md)   
 [CComboBox::ShowDropDown](../vs140/ccombobox--showdropdown.md)   
 [CB_GETMINVISIBLE](http://msdn.microsoft.com/library/windows/desktop/bb775915)