---
title: "CComboBoxEx::GetEditCtrl"
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
  - "CComboBoxEx.GetEditCtrl"
  - "CComboBoxEx::GetEditCtrl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetEditCtrl method"
ms.assetid: 2306afa0-26b7-4a44-a8f7-7f87616e2a17
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComboBoxEx::GetEditCtrl
Call this member function to get a pointer to the edit control for a combo box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A pointer to a [CEdit](../vs140/cedit-class.md) object.  
  
## Remarks  
 A <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> control uses an edit box when it is created with the **CBS_DROPDOWN** style.  
  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object pointed to by the return value is a temporary object and is destroyed during the next idle processing time.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CComboBoxEx Class](../vs140/ccomboboxex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CComboBoxEx::Create](../vs140/ccomboboxex--create.md)   
 [CComboBoxEx::CreateEx](../vs140/ccomboboxex--createex.md)