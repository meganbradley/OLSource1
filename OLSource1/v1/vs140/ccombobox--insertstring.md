---
title: "CComboBox::InsertString"
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
  - "CComboBox.InsertString"
  - "CComboBox::InsertString"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "InsertString method"
ms.assetid: a0a5f935-2b4f-4363-a7e4-e1b66716b495
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComboBox::InsertString
Inserts a string into the list box of a combo box.  
  
## Syntax  
  
```  
  
      int InsertString(  
   int nIndex,  
   LPCTSTR lpszString   
);  
```  
  
#### Parameters  
 `nIndex`  
 Contains the zero-based index to the position in the list box that will receive the string. If this parameter is –1, the string is added to the end of the list.  
  
 `lpszString`  
 Points to the null-terminated string that is to be inserted.  
  
## Return Value  
 The zero-based index of the position at which the string was inserted. The return value is **CB_ERR** if an error occurs. The return value is **CB_ERRSPACE** if insufficient space is available to store the new string.  
  
## Remarks  
 Unlike the [AddString](../vs140/ccombobox--addstring.md) member function, the `InsertString` member function does not cause a list with the [CBS_SORT](../vs140/combo-box-styles.md) style to be sorted.  
  
> [!NOTE]
>  This function is not supported by the Windows **ComboBoxEx** control. For more information on this control, see [ComboBoxEx Controls](http://msdn.microsoft.com/library/windows/desktop/bb775738) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CComboBox#27](../vs140/codesnippet/CPP/ccombobox--insertstring_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CComboBox Class](../vs140/ccombobox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CComboBox::AddString](../vs140/ccombobox--addstring.md)   
 [CComboBox::DeleteString](../vs140/ccombobox--deletestring.md)   
 [CComboBox::ResetContent](../vs140/ccombobox--resetcontent.md)   
 [CB_INSERTSTRING](http://msdn.microsoft.com/library/windows/desktop/bb775875)