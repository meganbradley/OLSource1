---
title: "CComboBox::LimitText"
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
  - "CComboBox::LimitText"
  - "CComboBox.LimitText"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LimitText method"
ms.assetid: 52397da7-7c13-4643-b6df-83ba49697032
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComboBox::LimitText
Limits the length in bytes of the text that the user can enter into the edit control of a combo box.  
  
## Syntax  
  
```  
  
      BOOL LimitText(  
   int nMaxChars   
);  
```  
  
#### Parameters  
 `nMaxChars`  
 Specifies the length (in bytes) of the text that the user can enter. If this parameter is 0, the text length is set to 65,535 bytes.  
  
## Return Value  
 Nonzero if successful. If called for a combo box with the style [CBS_DROPDOWNLIST](../vs140/combo-box-styles.md) or for a combo box without an edit control, the return value is **CB_ERR**.  
  
## Remarks  
 If the combo box does not have the style [CBS_AUTOHSCROLL](../vs140/combo-box-styles.md), setting the text limit to be larger than the size of the edit control will have no effect.  
  
 `LimitText` only limits the text the user can enter. It has no effect on any text already in the edit control when the message is sent, nor does it affect the length of the text copied to the edit control when a string in the list box is selected.  
  
## Example  
 [!code[NVC_MFC_CComboBox#28](../vs140/codesnippet/CPP/ccombobox--limittext_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CComboBox Class](../vs140/ccombobox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CB_LIMITTEXT](http://msdn.microsoft.com/library/windows/desktop/bb775877)