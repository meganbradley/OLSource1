---
title: "CPropertySheet::EndDialog"
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
  - CPropertySheet.EndDialog
  - CPropertySheet::EndDialog
dev_langs: 
  - C++
helpviewer_keywords: 
  - CPropertySheet class, operations
  - EndDialog method
ms.assetid: c90a29fd-714b-40cf-a502-9102a26cda0d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CPropertySheet::EndDialog
Terminates the property sheet.  
  
## Syntax  
  
```  
  
      void EndDialog(  
   int nEndID   
);  
```  
  
#### Parameters  
 *nEndID*  
 Identifier to be used as return value of the property sheet.  
  
## Remarks  
 This member function is called by the framework when the OK, Cancel, or Close button is pressed. Call this member function if an event occurs that should close the property sheet.  
  
 This member function is only used with a modal dialog box.  
  
## Example  
 See the example for [CPropertySheet::PressButton](../vs140/cpropertysheet--pressbutton.md).  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CPropertySheet Class](../vs140/cpropertysheet-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPropertyPage::OnOK](../vs140/cpropertypage--onok.md)   
 [CPropertyPage::OnCancel](../vs140/cpropertypage--oncancel.md)   
 [CWnd::DestroyWindow](../vs140/cwnd--destroywindow.md)