---
title: "COlePropertyPage::COlePropertyPage"
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
  - COlePropertyPage.COlePropertyPage
  - COlePropertyPage::COlePropertyPage
dev_langs: 
  - C++
helpviewer_keywords: 
  - COlePropertyPage class, constructor
ms.assetid: 007a2f50-f19b-4d01-9982-05d41db840d9
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COlePropertyPage::COlePropertyPage
Constructs a `COlePropertyPage` object.  
  
## Syntax  
  
```  
  
      COlePropertyPage(  
   UINT idDlg,  
   UINT idCaption   
);  
```  
  
#### Parameters  
 *idDlg*  
 Resource ID of the dialog template.  
  
 *idCaption*  
 Resource ID of the property page's caption.  
  
## Remarks  
 When you implement a subclass of `COlePropertyPage`, your subclass's constructor should use the `COlePropertyPage` constructor to identify the dialog-template resource on which the property page is based and the string resource containing its caption.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COlePropertyPage Class](../vs140/colepropertypage-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)