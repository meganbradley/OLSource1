---
title: "CPropertySheet::GetPage"
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
  - "CPropertySheet::GetPage"
  - "GetPage"
  - "CPropertySheet.GetPage"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetPage method"
  - "CPropertySheet class, attributes"
ms.assetid: 915d4bfd-b19e-469b-a60e-c44382fd2922
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPropertySheet::GetPage
Returns a pointer to the specified page in this property sheet.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Index of the desired page, starting at 0. Must be between 0 and one less than the number of pages in the property sheet, inclusive.  
  
## Return Value  
 The pointer to the page corresponding to the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> parameter.  
  
## Example  
 See the example for [CPropertyPage::OnWizardFinish](../vs140/cpropertypage--onwizardfinish.md).  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CPropertySheet Class](../vs140/cpropertysheet-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPropertySheet::AddPage](../vs140/cpropertysheet--addpage.md)   
 [CPropertySheet::GetActivePage](../vs140/cpropertysheet--getactivepage.md)   
 [CPropertySheet::GetPageCount](../vs140/cpropertysheet--getpagecount.md)   
 [CPropertySheet::RemovePage](../vs140/cpropertysheet--removepage.md)   
 [CPropertySheet::SetTitle](../vs140/cpropertysheet--settitle.md)   
 [CPropertyPage Class](../vs140/cpropertypage-class.md)