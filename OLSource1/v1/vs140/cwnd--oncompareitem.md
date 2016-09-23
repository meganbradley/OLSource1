---
title: "CWnd::OnCompareItem"
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
  - CWnd.OnCompareItem
  - OnCompareItem
  - WM_COMPAREITEM
  - CWnd::OnCompareItem
dev_langs: 
  - C++
helpviewer_keywords: 
  - WM_COMPAREITEM
  - OnCompareItem method
  - COMPAREITEMSTRUCT structure
ms.assetid: 78f49cc9-c119-4cfe-b499-e3421f9b0ea0
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWnd::OnCompareItem
The framework calls this member function to specify the relative position of a new item in a child sorted owner-draw combo or list box.  
  
## Syntax  
  
```  
  
      afx_msg int OnCompareItem(  
   int nIDCtl,  
   LPCOMPAREITEMSTRUCT lpCompareItemStruct   
);  
```  
  
#### Parameters  
 `nIDCtl`  
 The identifier of the control that sent the `WM_COMPAREITEM` message.  
  
 `lpCompareItemStruct`  
 Contains a long pointer to a [COMPAREITEMSTRUCT](../vs140/compareitemstruct-structure.md) data structure that contains the identifiers and application-supplied data for two items in the combo or list box.  
  
## Return Value  
 Indicates the relative position of the two items. It may be any of the following values:  
  
|Value|Meaning|  
|-----------|-------------|  
|–1|Item 1 sorts before item 2.|  
|0|Item 1 and item 2 sort the same.|  
|1|Item 1 sorts after item 2.|  
  
## Remarks  
 If a combo or list box is created with the [CBS_SORT](../vs140/combo-box-styles.md) or [LBS_SORT](../vs140/list-box-styles.md) style, Windows sends the combo-box or list-box owner a `WM_COMPAREITEM` message whenever the application adds a new item.  
  
 Two items in the combo or list box are reformed in a `COMPAREITEMSTRUCT` structure pointed to by `lpCompareItemStruct`. `OnCompareItem` should return a value that indicates which of the items should appear before the other. Typically, Windows makes this call several times until it determines the exact position for the new item.  
  
 If the **hwndItem** member of the `COMPAREITEMSTRUCT` structure belongs to a [CListBox](../vs140/clistbox-class.md) or [CComboBox](../vs140/ccombobox-class.md) object, then the `CompareItem` virtual function of the appropriate class is called. Override `CComboBox::CompareItem` or `CListBox::CompareItem` in your derived `CListBox` or `CComboBox` class to do the item comparison.  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COMPAREITEMSTRUCT Structure](../vs140/compareitemstruct-structure.md)   
 [WM_COMPAREITEM](http://msdn.microsoft.com/library/windows/desktop/bb775921)   
 [CListBox::CompareItem](../vs140/clistbox--compareitem.md)   
 [CComboBox::CompareItem](../vs140/ccombobox--compareitem.md)