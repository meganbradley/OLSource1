---
title: "CPropertyPage::m_psp"
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
  - "CPropertyPage::m_psp"
  - "CPropertyPage.m_psp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "property page data members"
  - "CPropertyPage class, data members"
  - "m_psp"
ms.assetid: 514917b9-df2f-4490-bd44-50ad06f4e81e
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPropertyPage::m_psp
`m_psp` is a structure whose members store the characteristics of [PROPSHEETPAGE](http://msdn.microsoft.com/library/windows/desktop/bb774548).  
  
## Syntax  
  
```  
  
PROPSHEETPAGE m_psp;  
  
```  
  
## Remarks  
 Use this structure to initialize the appearance of a property page after it is constructed.  
  
 For more information on this structure, including a listing of its members, see **PROPSHEETPAGE** in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFCDocView#128](../vs140/codesnippet/CPP/cpropertypage--m_psp_1.cpp)]  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CPropertyPage Class](../vs140/cpropertypage-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPropertySheet Class](../vs140/cpropertysheet-class.md)   
 [PROPSHEETPAGE](http://msdn.microsoft.com/library/windows/desktop/bb774548)