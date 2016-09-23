---
title: "CComboBox::SetDroppedWidth"
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
  - CComboBox.SetDroppedWidth
  - CComboBox::SetDroppedWidth
  - SetDroppedWidth
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetDroppedWidth method
ms.assetid: 759462e0-4b4f-4cfe-a068-e876e4996852
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CComboBox::SetDroppedWidth
Call this function to set the minimum allowable width, in pixels, of the list box of a combo box.  
  
## Syntax  
  
```  
  
      int SetDroppedWidth(  
   UINT nWidth   
);  
```  
  
#### Parameters  
 `nWidth`  
 The minimum allowable width of the list-box portion of the combo box, in pixels.  
  
## Return Value  
 If successful, the new width of the list box, otherwise **CB_ERR**.  
  
## Remarks  
 This function only applies to combo boxes with the [CBS_DROPDOWN](../vs140/combo-box-styles.md) or [CBS_DROPDOWNLIST](../vs140/combo-box-styles.md) style.  
  
 By default, the minimum allowable width of the drop-down list box is 0. When the list-box portion of the combo box is displayed, its width is the larger of the minimum allowable width or the combo box width.  
  
## Example  
 [!code[NVC_MFC_CComboBox#34](../vs140/codesnippet/CPP/ccombobox--setdroppedwidth_1.cpp)]
  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CComboBox Class](../vs140/ccombobox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CComboBox::GetDroppedWidth](../vs140/ccombobox--getdroppedwidth.md)   
 [CB_SETDROPPEDWIDTH](http://msdn.microsoft.com/library/windows/desktop/bb775901)