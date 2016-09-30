---
title: "CPropertySheet::GetPageIndex"
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
  - "GetPageIndex"
  - "CPropertySheet.GetPageIndex"
  - "CPropertySheet::GetPageIndex"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetPageIndex method"
  - "CPropertySheet class, attributes"
ms.assetid: 1a7f7c96-7faf-4f91-9dbc-d880aa93d5e3
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPropertySheet::GetPageIndex
Retrieves the index number of the specified page in the property sheet.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Points to the page with the index to be found. Cannot be **NULL**.  
  
## Return Value  
 The index number of a page.  
  
## Remarks  
 For example, you would use <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to get the page index in order to use [SetActivePage](../vs140/cpropertysheet--setactivepage.md) or [GetPage](../vs140/cpropertysheet--getpage.md).  
  
## Example  
 See the example for [CPropertySheet::GetActivePage](../vs140/cpropertysheet--getactivepage.md).  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CPropertySheet Class](../vs140/cpropertysheet-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPropertySheet::SetActivePage](../vs140/cpropertysheet--setactivepage.md)   
 [CPropertySheet::GetPage](../vs140/cpropertysheet--getpage.md)