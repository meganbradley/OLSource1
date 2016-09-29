---
title: "CPropertyPage::OnKillActive"
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
  - "CPropertyPage.OnKillActive"
  - "OnKillActive"
  - "CPropertyPage::OnKillActive"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "property page overridables"
  - "CPropertyPage class, overridables"
  - "OnKillActive method"
ms.assetid: 966ff914-0a85-4100-9d12-c703ea5e5ca9
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPropertyPage::OnKillActive
This member function is called by the framework when the page is no longer the active page.  
  
## Syntax  
  
```  
  
virtual BOOL OnKillActive( );  
```  
  
## Return Value  
 Nonzero if data was updated successfully, otherwise 0.  
  
## Remarks  
 Override this member function to perform special data validation tasks.  
  
 The default implementation of this member function copies settings from the controls in the property page to the member variables of the property page. If the data was not updated successfully due to a dialog data validation (DDV) error, the page retains focus.  
  
 After this member function returns successfully, the framework will call the page's [OnOK](../vs140/cpropertypage--onok.md) function.  
  
## Example  
 [!code[NVC_MFCDocView#115](../vs140/codesnippet/CPP/cpropertypage--onkillactive_1.cpp)]  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CPropertyPage Class](../vs140/cpropertypage-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::UpdateData](../vs140/cwnd--updatedata.md)   
 [CPropertyPage::OnOK](../vs140/cpropertypage--onok.md)   
 [CPropertyPage::OnSetActive](../vs140/cpropertypage--onsetactive.md)