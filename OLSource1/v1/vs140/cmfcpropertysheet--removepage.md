---
title: "CMFCPropertySheet::RemovePage"
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
  - "CMFCPropertySheet::RemovePage"
  - "CMFCPropertySheet.RemovePage"
  - "RemovePage"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RemovePage method"
ms.assetid: 6d532685-b4e4-47bb-9416-5f2bea73ac40
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPropertySheet::RemovePage
Removes a property page from the property sheet.  
  
## Syntax  
  
```  
void RemovePage(  
   CPropertyPage* pPage   
);  
void RemovePage(  
   int nPage   
);  
```  
  
#### Parameters  
 [in] `pPage`  
 Pointer to property page object that represents the property page to remove. Cannot be `NULL`.  
  
 [in] `nPage`  
 Zero-based index of the page to remove.  
  
## Remarks  
 This method removes the specified property page and destroys its associated window. The property page object that the `pPage` parameter specifies is not destroyed until the [CMFCPropertySheet](../vs140/cmfcpropertysheet-class.md) window is closed.  
  
## Requirements  
 **Header:** afxpropertysheet.h  
  
## See Also  
 [CMFCPropertySheet Class](../vs140/cmfcpropertysheet-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPropertySheet::RemovePage](../vs140/cpropertysheet--removepage.md)