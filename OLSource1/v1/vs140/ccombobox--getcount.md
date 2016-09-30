---
title: "CComboBox::GetCount"
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
  - "CComboBox.GetCount"
  - "CComboBox::GetCount"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetCount method [MFC]"
ms.assetid: 6a624746-d346-438b-b53a-e54d390b6f16
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComboBox::GetCount
Call this member function to retrieve the number of items in the list-box portion of a combo box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The number of items. The returned count is one greater than the index value of the last item (the index is zero-based). It is **CB_ERR** if an error occurs.  
  
## Example  
 [!code[NVC_MFC_CComboBox#14](../vs140/codesnippet/CPP/ccombobox--getcount_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CComboBox Class](../vs140/ccombobox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CB_GETCOUNT](http://msdn.microsoft.com/library/windows/desktop/bb775841)