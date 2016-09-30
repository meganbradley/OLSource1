---
title: "CComboBoxEx::DeleteItem"
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
  - "CComboBoxEx.DeleteItem"
  - "CComboBoxEx::DeleteItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DeleteItem method"
ms.assetid: 69ef3362-e93c-4f98-a35f-450ee495282c
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComboBoxEx::DeleteItem
Removes an item from a **ComboBoxEx** control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Zero-based index of the item to be removed.  
  
## Return Value  
 The number of items remaining in the control. If <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is invalid, the function returns **CB_ERR**.  
  
## Remarks  
 This member function implements the functionality of the message [CBEM_DELETEITEM](http://msdn.microsoft.com/library/windows/desktop/bb775768), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. When you call DeleteItem, a [WM_NOTIFY](http://msdn.microsoft.com/library/windows/desktop/bb775583) message with **CBEN_DELETEITEM** notification will be sent to the parent window.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CComboBoxEx Class](../vs140/ccomboboxex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)