---
title: "CComboBoxEx::GetImageList"
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
  - "CComboBoxEx::GetImageList"
  - "CComboBoxEx.GetImageList"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetImageList method"
ms.assetid: b10fe333-c8e4-4009-9ecf-50f38b7be6cb
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComboBoxEx::GetImageList
Call this member function to get a pointer to the image list used by a `CComboBoxEx` control.  
  
## Syntax  
  
```  
  
CImageList* GetImageList( ) const;  
  
```  
  
## Return Value  
 A pointer to a [CImageList](../vs140/cimagelist-class.md) object. If it fails, this member function returns **NULL**.  
  
## Remarks  
 The `CImageList` object pointed to by the return value is a temporary object and is destroyed during the next idle processing time.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CComboBoxEx Class](../vs140/ccomboboxex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CComboBoxEx::SetImageList](../vs140/ccomboboxex--setimagelist.md)   
 [COMBOBOXEXITEM](http://msdn.microsoft.com/library/windows/desktop/bb775746)