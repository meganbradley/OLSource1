---
title: "CPropertyPage::CancelToClose"
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
  - "CancelToClose"
  - "CPropertyPage::CancelToClose"
  - "CPropertyPage.CancelToClose"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CPropertyPage class, operations"
  - "property page operations"
  - "CancelToClose method"
ms.assetid: 81fac40b-c7fc-4b07-b9ba-b854bf9e8155
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPropertyPage::CancelToClose
Call this function after an unrecoverable change has been made to the data in a page of a modal property sheet.  
  
## Syntax  
  
```  
  
void CancelToClose( );  
```  
  
## Remarks  
 This function will change the OK button to Close and disable the Cancel button. This change alerts the user that a change is permanent and the modifications cannot be cancelled.  
  
 The `CancelToClose` member function does nothing in a modeless property sheet, because a modeless property sheet does not have a Cancel button by default.  
  
## Example  
 See the example for [CPropertyPage::QuerySiblings](../vs140/cpropertypage--querysiblings.md).  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CPropertyPage Class](../vs140/cpropertypage-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPropertyPage::OnKillActive](../vs140/cpropertypage--onkillactive.md)   
 [CPropertyPage::SetModified](../vs140/cpropertypage--setmodified.md)