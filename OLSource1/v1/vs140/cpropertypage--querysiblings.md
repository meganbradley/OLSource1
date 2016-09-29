---
title: "CPropertyPage::QuerySiblings"
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
  - "CPropertyPage.QuerySiblings"
  - "CPropertyPage::QuerySiblings"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "property pages, querying"
  - "CPropertyPage class, operations"
  - "forwarding messages on property pages"
  - "QuerySiblings method"
  - "querying property pages"
ms.assetid: 5af187fd-f583-4fea-9d0e-ba52f64e899d
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPropertyPage::QuerySiblings
Call this member function to forward a message to each page in the property sheet.  
  
## Syntax  
  
```  
  
      LRESULT QuerySiblings(  
   WPARAM wParam,  
   LPARAM lParam   
);  
```  
  
#### Parameters  
 `wParam`  
 Specifies additional message-dependent information.  
  
 `lParam`  
 Specifies additional message-dependent information  
  
## Return Value  
 The nonzero value from a page in the property sheet, or 0 if all pages return a value of 0.  
  
## Remarks  
 If a page returns a nonzero value, the property sheet does not send the message to subsequent pages.  
  
## Example  
 [!code[NVC_MFCDocView#124](../vs140/codesnippet/CPP/cpropertypage--querysiblings_1.cpp)]  
  
 [!code[NVC_MFCDocView#125](../vs140/codesnippet/CPP/cpropertypage--querysiblings_2.cpp)]  
  
 [!code[NVC_MFCDocView#126](../vs140/codesnippet/CPP/cpropertypage--querysiblings_3.cpp)]  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CPropertyPage Class](../vs140/cpropertypage-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)