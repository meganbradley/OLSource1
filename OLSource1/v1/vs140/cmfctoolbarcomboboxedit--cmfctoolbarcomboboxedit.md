---
title: "CMFCToolBarComboBoxEdit::CMFCToolBarComboBoxEdit"
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
  - "CMFCToolBarComboBoxEdit.CMFCToolBarComboBoxEdit"
  - "CMFCToolBarComboBoxEdit::CMFCToolBarComboBoxEdit"
  - "CMFCToolBarComboBoxEdit"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCToolBarComboBoxEdit, constructor"
ms.assetid: 65427901-6b6c-4424-b604-28653c4863d7
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarComboBoxEdit::CMFCToolBarComboBoxEdit
Constructs a `CMFCToolBarComboBoxEdit` object.  
  
## Syntax  
  
```  
CMFCToolBarComboBoxEdit(  
   CMFCToolBarComboBoxButton& combo  
);  
```  
  
#### Parameters  
 [in] `combo`  
 A reference to a [CMFCToolBarComboBoxButton](../vs140/cmfctoolbarcomboboxbutton-class.md) object, which is a toolbar button that contains a combo box control.  
  
## Example  
 The following example demonstrates how to construct an object of the `CMFCToolBarComboBoxEdit` class. This code snippet is part of the [IE Demo sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_IEDemo#5](../vs140/codesnippet/CPP/cmfctoolbarcomboboxedit--cmfctoolbarcomboboxedit_1.cpp)]  
  
## Requirements  
 **Header:** afxtoolbarcomboboxbutton.h  
  
## See Also  
 [CMFCToolBarComboBoxEdit Class](../vs140/cmfctoolbarcomboboxedit-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCToolBarComboBoxButton Class](../vs140/cmfctoolbarcomboboxbutton-class.md)