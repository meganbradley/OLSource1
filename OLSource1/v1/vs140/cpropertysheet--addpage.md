---
title: "CPropertySheet::AddPage"
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
  - "AddPage"
  - "CPropertySheet.AddPage"
  - "CPropertySheet::AddPage"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CPropertySheet class, operations"
  - "AddPage method"
ms.assetid: 98d45386-f4d0-4fa1-b589-682902f770e8
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPropertySheet::AddPage
Adds the supplied page with the rightmost tab in the property sheet.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Points to the page to be added to the property sheet. Cannot be **NULL**.  
  
## Remarks  
 Add pages to the property sheet in the left-to-right order you want them to appear.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> adds the [CPropertyPage](../vs140/cpropertypage--cpropertypage.md) object to the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object's list of pages but does not actually create the window for the page. The framework postpones creation of the window for the page until the user selects that page.  
  
 When you add a property page using <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is the parent of the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. To gain access to the property sheet from the property page, call [CWnd::GetParent](../vs140/cwnd--getparent.md).  
  
 It is not necessary to wait until creation of the property sheet window to call <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. Typically, you will call <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> before calling [DoModal](../vs140/cpropertysheet--domodal.md) or [Create](../vs140/cpropertysheet--create.md).  
  
 If you call <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> after displaying the property page, the tab row will reflect the newly added page.  
  
## Example  
 [!code[NVC_MFCDocView#129](../vs140/codesnippet/CPP/cpropertysheet--addpage_1.cpp)]  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CPropertySheet Class](../vs140/cpropertysheet-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPropertySheet::RemovePage](../vs140/cpropertysheet--removepage.md)