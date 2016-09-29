---
title: "CComboBoxEx::HasEditChanged"
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
  - "CComboBoxEx.HasEditChanged"
  - "HasEditChanged"
  - "CComboBoxEx::HasEditChanged"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "HasEditChanged method"
ms.assetid: 3a215f75-790a-44dd-b513-7b1486261bfd
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComboBoxEx::HasEditChanged
Determines if the user has changed the contents of the **ComboBoxEx** edit control by typing.  
  
## Syntax  
  
```  
  
BOOL HasEditChanged( );  
  
```  
  
## Return Value  
 Nonzero if the user has typed in the control's edit box; otherwise 0.  
  
## Remarks  
 This member function implements the functionality of the message [CBEM_HASEDITCHANGED](http://msdn.microsoft.com/library/windows/desktop/bb775782), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CComboBoxEx Class](../vs140/ccomboboxex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)