---
title: "CComboBox::FindString"
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
  - "CComboBox::FindString"
  - "CComboBox.FindString"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FindString method"
ms.assetid: 1568ca40-c990-4922-9bba-9532a6bc6610
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComboBox::FindString
Finds, but doesn't select, the first string that contains the specified prefix in the list box of a combo box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Contains the zero-based index of the item before the first item to be searched. When the search reaches the bottom of the list box, it continues from the top of the list box back to the item specified by <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. If –1, the entire list box is searched from the beginning.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Points to the null-terminated string that contains the prefix to search for. The search is case independent, so this string can contain any combination of uppercase and lowercase letters.  
  
## Return Value  
 If the return value is greater than or equal to 0, it is the zero-based index of the matching item. It is **CB_ERR** if the search was unsuccessful.  
  
## Remarks  
 This function is not supported by the Windows **ComboBoxEx** control. For more information on this control, see [ComboBoxEx Controls](http://msdn.microsoft.com/library/windows/desktop/bb775738) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CComboBox#12](../vs140/codesnippet/CPP/ccombobox--findstring_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CComboBox Class](../vs140/ccombobox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CComboBox::SelectString](../vs140/ccombobox--selectstring.md)   
 [CComboBox::SetCurSel](../vs140/ccombobox--setcursel.md)   
 [CB_FINDSTRING](http://msdn.microsoft.com/library/windows/desktop/bb775835)