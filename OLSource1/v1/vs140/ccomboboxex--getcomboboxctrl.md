---
title: "CComboBoxEx::GetComboBoxCtrl"
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
  - "CComboBoxEx::GetComboBoxCtrl"
  - "CComboBoxEx.GetComboBoxCtrl"
  - "GetComboBoxCtrl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetComboBoxCtrl method"
ms.assetid: a992345c-c9cb-404e-8948-d82c85d65e2e
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComboBoxEx::GetComboBoxCtrl
Call this member function to get a pointer to a combo box control within a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A pointer to a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object.  
  
## Remarks  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> control consists of a parent window, which encapsulates a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object pointed to by the return value is a temporary object and is destroyed during the next idle processing time.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CComboBoxEx Class](../vs140/ccomboboxex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CComboBoxEx::GetEditCtrl](../vs140/ccomboboxex--geteditctrl.md)