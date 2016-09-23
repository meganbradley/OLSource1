---
title: "CPropertyPage::GetPSP"
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
  - GetPSP
  - CPropertyPage.GetPSP
  - CPropertyPage::GetPSP
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetPSP method
  - CPropertyPage class, operations
ms.assetid: ed397363-6c31-47f1-ae94-791f45902a67
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CPropertyPage::GetPSP
Retrieves the Windows [PROPSHEETPAGE](http://msdn.microsoft.com/library/windows/desktop/bb774548) structure associated with the `CPropertyPage` object.  
  
## Syntax  
  
```  
  
      const PROPSHEETPAGE & GetPSP( ) const;   
PROPSHEETPAGE & GetPSP( );  
```  
  
## Return Value  
 A reference to the **PROPSHEETPAGE** structure.  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CPropertyPage Class](../vs140/cpropertypage-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)