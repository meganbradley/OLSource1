---
title: "CWnd::OnDeleteItem"
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
  - "CWnd.OnDeleteItem"
  - "WM_DELETEITEM"
  - "OnDeleteItem"
  - "CWnd::OnDeleteItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDeleteItem method"
  - "DELETEITEMSTRUCT structure"
  - "WM_DELETEITEM"
ms.assetid: 8d3ca9c7-7496-4520-a35d-0cbcb736251d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnDeleteItem
The framework calls this member function to inform the owner of an owner-draw list box or combo box that the list box or combo box is destroyed or that items have been removed by [CComboBox::DeleteString](../vs140/ccombobox--deletestring.md), [CListBox::DeleteString](../vs140/clistbox--deletestring.md), [CComboBox::ResetContent](../vs140/ccombobox--resetcontent.md), or [CListBox::ResetContent](../vs140/clistbox--resetcontent.md).  
  
## Syntax  
  
```  
  
      afx_msg void OnDeleteItem(  
   int nIDCtl,  
   LPDELETEITEMSTRUCT lpDeleteItemStruct   
);  
```  
  
#### Parameters  
 `nIDCtl`  
 The identifier of the control that sent the `WM_DELETEITEM` message.  
  
 `lpDeleteItemStruct`  
 Specifies a long pointer to a [DELETEITEMSTRUCT](../vs140/deleteitemstruct-structure.md) data structure that contains information about the deleted list box item.  
  
## Remarks  
 If the **hwndItem** member of the `DELETEITEMSTRUCT` structure belongs to a combo box or list box, then the `DeleteItem` virtual function of the appropriate class is called. Override the `DeleteItem` member function of the appropriate control's class to delete item-specific data.  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CComboBox::DeleteString](../vs140/ccombobox--deletestring.md)   
 [CListBox::DeleteString](../vs140/clistbox--deletestring.md)   
 [CComboBox::ResetContent](../vs140/ccombobox--resetcontent.md)   
 [CListBox::ResetContent](../vs140/clistbox--resetcontent.md)   
 [WM_DELETEITEM](http://msdn.microsoft.com/library/windows/desktop/bb761362)   
 [CListBox::DeleteItem](../vs140/clistbox--deleteitem.md)   
 [CComboBox::DeleteItem](../vs140/ccombobox--deleteitem.md)