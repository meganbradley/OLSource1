---
title: "CComboBox::SetLocale"
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
  - "CComboBox::SetLocale"
  - "CComboBox.SetLocale"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetLocale method"
ms.assetid: 11145c07-afcb-4c31-bb2b-e03bb5d0d53a
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComboBox::SetLocale
Sets the locale identifier for this combo box.  
  
## Syntax  
  
```  
  
      LCID SetLocale(  
   LCID nNewLocale   
);  
```  
  
#### Parameters  
 `nNewLocale`  
 The new locale identifier (LCID) value to set for the combo box.  
  
## Return Value  
 The previous locale identifier (LCID) value for this combo box.  
  
## Remarks  
 If **SetLocale** is not called, the default locale is obtained from the system. This system default locale can be modified by using Control Panel's Regional (or International) application.  
  
## Example  
 [!code[NVC_MFC_CComboBox#39](../vs140/codesnippet/CPP/ccombobox--setlocale_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CComboBox Class](../vs140/ccombobox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CComboBox::GetLocale](../vs140/ccombobox--getlocale.md)