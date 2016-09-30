---
title: "CPropertySheet::RemovePage"
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
  - "CPropertySheet::RemovePage"
  - "CPropertySheet.RemovePage"
  - "RemovePage"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CPropertySheet class, operations"
  - "RemovePage method"
ms.assetid: 2a48edeb-107f-40ad-9279-0629eed89749
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPropertySheet::RemovePage
Removes a page from the property sheet and destroys the associated window.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Points to the page to be removed from the property sheet. Cannot be <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Index of the page to be removed. Must be between 0 and one less than the number of pages in the property sheet, inclusive.  
  
## Remarks  
 The [CPropertyPage](../vs140/cpropertypage-class.md) object itself is not destroyed until the owner of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> window is closed.  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CPropertySheet Class](../vs140/cpropertysheet-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPropertySheet::AddPage](../vs140/cpropertysheet--addpage.md)