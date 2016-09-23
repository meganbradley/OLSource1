---
title: "CPropertySheet::GetActivePage"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CPropertySheet::GetActivePage
  - GetActivePage
  - CPropertySheet.GetActivePage
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetActivePage method
  - CPropertySheet class, attributes
ms.assetid: 179ad165-dff9-4eb9-955e-f841e836bd46
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CPropertySheet::GetActivePage
Retrieves the property sheet window's active page.  
  
## Syntax  
  
```  
  
CPropertyPage* GetActivePage( ) const;  
  
```  
  
## Return Value  
 The pointer to the active page.  
  
## Remarks  
 Use this member function to perform some action on the active page.  
  
## Example  
 [!code[NVC_MFCDocView#135](../vs140/codesnippet/CPP/cpropertysheet--getactivepage_1.cpp)]
  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CPropertySheet Class](../vs140/cpropertysheet-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPropertySheet::GetPage](../vs140/cpropertysheet--getpage.md)