---
title: "CComboBox::GetLBTextLen"
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
  - "CComboBox::GetLBTextLen"
  - "CComboBox.GetLBTextLen"
  - "GetLBTextLen"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetLBTextLen method"
ms.assetid: c1a75548-907a-4e43-a179-85cd08e94c0c
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComboBox::GetLBTextLen
Gets the length of a string in the list box of a combo box.  
  
## Syntax  
  
```  
  
      int GetLBTextLen(  
   int nIndex   
) const;  
```  
  
#### Parameters  
 `nIndex`  
 Contains the zero-based index of the list-box string.  
  
## Return Value  
 The length of the string in bytes, excluding the terminating null character. If `nIndex` does not specify a valid index, the return value is **CB_ERR**.  
  
## Example  
 See the example for [CComboBox::GetLBText](../vs140/ccombobox--getlbtext.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CComboBox Class](../vs140/ccombobox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CComboBox::GetLBText](../vs140/ccombobox--getlbtext.md)   
 [CB_GETLBTEXTLEN](http://msdn.microsoft.com/library/windows/desktop/bb775864)