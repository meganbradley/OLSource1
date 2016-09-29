---
title: "CPropertyPage::CPropertyPage"
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
  - "CPropertyPage::CPropertyPage"
  - "CPropertyPage.CPropertyPage"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "property pages, construction"
  - "CPropertyPage class, construction"
  - "CPropertyPage class, constructor"
ms.assetid: 6c7ff2b8-e412-4eda-8015-e4fb76f3da7f
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPropertyPage::CPropertyPage
Constructs a `CPropertyPage` object.  
  
## Syntax  
  
```  
  
      CPropertyPage( );   
explicit CPropertyPage(  
   UINT nIDTemplate,  
   UINT nIDCaption = 0,  
   DWORD dwSize = sizeof(PROPSHEETPAGE)  
);  
explicit CPropertyPage(  
   LPCTSTR lpszTemplateName,  
   UINT nIDCaption = 0,  
   DWORD dwSize = sizeof(PROPSHEETPAGE)  
);  
CPropertyPage(  
   UINT nIDTemplate,  
   UINT nIDCaption,  
   UINT nIDHeaderTitle,  
   UINT nIDHeaderSubTitle = 0,  
   DWORD dwSize = sizeof(PROPSHEETPAGE)  
);  
CPropertyPage(  
   LPCTSTR lpszTemplateName,  
   UINT nIDCaption,  
   UINT nIDHeaderTitle,  
   UINT nIDHeaderSubTitle = 0,  
   DWORD dwSize = sizeof(PROPSHEETPAGE)  
);  
```  
  
#### Parameters  
 `nIDTemplate`  
 ID of the template used for this page.  
  
 `nIDCaption`  
 ID of the name to be placed in the tab for this page. If 0, the name will be taken from the dialog template for this page.  
  
 `dwSize`  
 `lpszTemplateName`  
 Points to a string containing the name of the template for this page. Cannot be **NULL**.  
  
 `nIDHeaderTitle`  
 ID of the name to be placed in the title location of the property page header.  
  
 `nIDHeaderSubTitle`  
 ID of the name to be placed in the subtitle location of the property page header.  
  
## Remarks  
 The object is displayed after all of the following conditions are met:  
  
-   The page has been added to a property sheet using [CPropertySheet::AddPage](../vs140/cpropertysheet--addpage.md).  
  
-   The property sheet's [DoModal](../vs140/cpropertysheet--domodal.md) or [Create](../vs140/cpropertysheet--create.md) function has been called.  
  
-   The user has selected (tabbed to) this page.  
  
 If you have multiple parameters (for example, if you are using an array), use [CPropertySheet::Construct](../vs140/cpropertysheet--construct.md) instead of `CPropertyPage`.  
  
## Example  
 [!code[NVC_MFCDocView#113](../vs140/codesnippet/CPP/cpropertypage--cpropertypage_1.cpp)]  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CPropertyPage Class](../vs140/cpropertypage-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPropertySheet::Create](../vs140/cpropertysheet--create.md)   
 [CPropertySheet::DoModal](../vs140/cpropertysheet--domodal.md)   
 [CPropertySheet::AddPage](../vs140/cpropertysheet--addpage.md)   
 [CPropertyPage::Construct](../vs140/cpropertypage--construct.md)