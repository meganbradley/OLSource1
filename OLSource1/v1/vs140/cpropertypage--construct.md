---
title: "CPropertyPage::Construct"
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
  - "CPropertyPage.Construct"
  - "CPropertyPage::Construct"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "property pages, construction"
  - "Construct method"
  - "CPropertyPage class, construction"
ms.assetid: 333a73d4-b5e7-4f9f-b065-4f58292fbbeb
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPropertyPage::Construct
Call this member function to construct a `CPropertyPage` object.  
  
## Syntax  
  
```  
  
      void Construct(  
   UINT nIDTemplate,  
   UINT nIDCaption = 0   
);  
void Construct(  
   LPCTSTR lpszTemplateName,  
   UINT nIDCaption = 0   
);  
void Construct(  
   UINT nIDTemplate,  
   UINT nIDCaption,  
   UINT nIDHeaderTitle,  
   UINT nIDHeaderSubTitle = 0   
);  
void Construct(  
   LPCTSTR lpszTemplateName,  
   UINT nIDCaption,  
   UINT nIDHeaderTitle,  
   UINT nIDHeaderSubTitle = 0   
);  
```  
  
#### Parameters  
 `nIDTemplate`  
 ID of the template used for this page.  
  
 `nIDCaption`  
 ID of the name to be placed in the tab for this page. If 0, the name will be taken from the dialog template for this page.  
  
 `lpszTemplateName`  
 Contains a null-terminated string that is the name of a template resource.  
  
 `nIDHeaderTitle`  
 ID of the name to be placed in the title location of the property page header. By default, 0.  
  
 `nIDHeaderSubTitle`  
 ID of the name to be placed in the subtitle location of the property page header. By default, 0.  
  
## Remarks  
 The object is displayed after all of the following conditions are met:  
  
-   The page has been added to a property sheet using [CPropertySheet::AddPage](../vs140/cpropertysheet--addpage.md).  
  
-   The property sheet's [DoModal](../vs140/cpropertysheet--domodal.md) or [Create](../vs140/cpropertysheet--create.md) function has been called.  
  
-   The user has selected (tabbed to) this page.  
  
 Call **Construct** if one of the other class constructors has not been called. The `Construct` member function is flexible because you can leave the parameter statement blank and then specify multiple parameters and construction at any point in your code.  
  
 You must use `Construct` when you work with arrays, and you must call **Construct** for each member of the array so that the data members are assigned proper values.  
  
## Example  
 [!code[NVC_MFCDocView#112](../vs140/codesnippet/CPP/cpropertypage--construct_1.cpp)]  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CPropertyPage Class](../vs140/cpropertypage-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPropertyPage::CPropertyPage](../vs140/cpropertypage--cpropertypage.md)   
 [CPropertySheet::DoModal](../vs140/cpropertysheet--domodal.md)   
 [CPropertySheet::AddPage](../vs140/cpropertysheet--addpage.md)