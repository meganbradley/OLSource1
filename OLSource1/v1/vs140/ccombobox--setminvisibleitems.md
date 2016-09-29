---
title: "CComboBox::SetMinVisibleItems"
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
  - "CCombobox::SetMinVisibleIems"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetMinVisibleItems method"
ms.assetid: e7addf4f-a6cb-4df3-bb93-df496154a83a
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComboBox::SetMinVisibleItems
Sets the minimum number of visible items in the drop-down list of the current combo box control.  
  
## Syntax  
  
```  
BOOL SetMinVisibleItems(  
     int iMinVisible  
);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] `iMinVisible`|Specifies the minimum number of visible items.|  
  
## Return Value  
 `true` if this method is successful; otherwise, `false`.  
  
## Requirements  
 **Header:** afxwin.h  
  
 This method is supported in Windows XP and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## Remarks  
 This method sends the [CB_SETMINVISIBLE](http://msdn.microsoft.com/library/windows/desktop/bb775915) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 The following code example defines the variable, `m_combobox`, that is used to programmatically access the combo box control. This variable is used in the next example.  
  
 [!code[NVC_MFC_CComboBox_s1#1](../vs140/codesnippet/CPP/ccombobox--setminvisibleitems_1.h)]  
  
## Example  
 The following code example inserts 20 items into the drop-down list of a combo box control. Then it specifies that a minimum of 10 items be displayed when a user presses the drop-down arrow.  
  
 [!code[NVC_MFC_CComboBox_s1#2](../vs140/codesnippet/CPP/ccombobox--setminvisibleitems_2.cpp)]  
  
## See Also  
 [CComboBox Class](../vs140/ccombobox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CComboBox::GetMinVisibleItems](../vs140/ccombobox--getminvisible.md)   
 [CComboBox::ShowDropDown](../vs140/ccombobox--showdropdown.md)   
 [CB_SETMINVISIBLE](http://msdn.microsoft.com/library/windows/desktop/bb775915)