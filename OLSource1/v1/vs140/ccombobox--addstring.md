---
title: "CComboBox::AddString"
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
  - "CComboBox.AddString"
  - "CComboBox::AddString"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddString method"
ms.assetid: 15cc6381-36d1-44be-a383-d7ca84faed44
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComboBox::AddString
Adds a string to the list box of a combo box.  
  
## Syntax  
  
```  
  
      int AddString(  
   LPCTSTR lpszString   
);  
```  
  
#### Parameters  
 `lpszString`  
 Points to the null-terminated string that is to be added.  
  
## Return Value  
 If the return value is greater than or equal to 0, it is the zero-based index to the string in the list box. The return value is **CB_ERR** if an error occurs; the return value is **CB_ERRSPACE** if insufficient space is available to store the new string.  
  
## Remarks  
 If the list box was not created with the [CBS_SORT](../vs140/combo-box-styles.md) style, the string is added to the end of the list. Otherwise, the string is inserted into the list, and the list is sorted.  
  
> [!NOTE]
>  This function is not supported by the Windows **ComboBoxEx** control. For more information on this control, see [ComboBoxEx Controls](http://msdn.microsoft.com/library/windows/desktop/bb775738) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 To insert a string into a specific location within the list, use the [InsertString](../vs140/ccombobox--insertstring.md) member function.  
  
## Example  
 [!code[NVC_MFC_CComboBox#3](../vs140/codesnippet/CPP/ccombobox--addstring_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CComboBox Class](../vs140/ccombobox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CComboBox::InsertString](../vs140/ccombobox--insertstring.md)   
 [CComboBox::DeleteString](../vs140/ccombobox--deletestring.md)   
 [CB_ADDSTRING](http://msdn.microsoft.com/library/windows/desktop/bb775828)