---
title: "CComboBoxEx::GetItem"
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
  - "CComboBoxEx::GetItem"
  - "CComboBoxEx.GetItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetItem method [MFC]"
ms.assetid: f2daa854-6962-4ac8-824d-92f8fdcf8232
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComboBoxEx::GetItem
Retrieves item information for a given **ComboBoxEx** item.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a [COMBOBOXEXITEM](http://msdn.microsoft.com/library/windows/desktop/bb775746) structure that will receive the item information.  
  
## Return Value  
 Nonzero if the operation was successful; otherwise 0.  
  
## Remarks  
 This member function implements the functionality of the message [CBEM_GETITEM](http://msdn.microsoft.com/library/windows/desktop/bb775779), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CComboBoxEx Class](../vs140/ccomboboxex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CComboBoxEx::SetItem](../vs140/ccomboboxex--setitem.md)   
 [CComboBoxEx::InsertItem](../vs140/ccomboboxex--insertitem.md)