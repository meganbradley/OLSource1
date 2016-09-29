---
title: "CComboBox::GetDroppedWidth"
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
  - "CComboBox.GetDroppedWidth"
  - "CComboBox::GetDroppedWidth"
  - "GetDroppedWidth"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetDroppedWidth method"
ms.assetid: d136d097-3c26-4db6-94f2-be8349a63ac3
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComboBox::GetDroppedWidth
Call this function to retrieve the minimum allowable width, in pixels, of the list box of a combo box.  
  
## Syntax  
  
```  
  
int GetDroppedWidth( ) const;  
  
```  
  
## Return Value  
 If successful, the minimum allowable width, in pixels; otherwise, **CB_ERR**.  
  
## Remarks  
 This function only applies to combo boxes with the [CBS_DROPDOWN](../vs140/combo-box-styles.md) or [CBS_DROPDOWNLIST](../vs140/combo-box-styles.md) style.  
  
 By default, the minimum allowable width of the drop-down list box is 0. The minimum allowable width can be set by calling [SetDroppedWidth](../vs140/ccombobox--setdroppedwidth.md). When the list-box portion of the combo box is displayed, its width is the larger of the minimum allowable width or the combo box width.  
  
## Example  
 See the example for [SetDroppedWidth](../vs140/ccombobox--setdroppedwidth.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CComboBox Class](../vs140/ccombobox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CComboBox::SetDroppedWidth](../vs140/ccombobox--setdroppedwidth.md)   
 [CB_GETDROPPEDWIDTH](http://msdn.microsoft.com/library/windows/desktop/bb775851)