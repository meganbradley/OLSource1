---
title: "CMFCToolBarDateTimeCtrl::OnAddToCustomizePage"
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
  - "CMFCToolBarDateTimeCtrl.OnAddToCustomizePage"
  - "OnAddToCustomizePage"
  - "CMFCToolBarDateTimeCtrl::OnAddToCustomizePage"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnAddToCustomizePage method"
ms.assetid: f3e8023e-fb29-4e11-94fb-3cfc3631859c
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarDateTimeCtrl::OnAddToCustomizePage
Called by the framework when the button is added to a **Customize** dialog box.  
  
## Syntax  
  
```  
virtual void OnAddToCustomizePage();  
```  
  
## Remarks  
 This method extends the base class implementation, [CMFCToolBarButton::OnAddToCustomizePage](../vs140/cmfctoolbarbutton--onaddtocustomizepage.md), by copying the properties from the first date and time control in any toolbar that has the same command ID as this object. This method does nothing if no toolbar has a date and time control that has the same command ID as this object.  
  
 For more information about the **Customize** dialog box, see [CMFCToolBarsCustomizeDialog Class](../vs140/cmfctoolbarscustomizedialog-class.md).  
  
## Requirements  
 **Header:** afxtoolbardatetimectrl.h  
  
## See Also  
 [CMFCToolBarDateTimeCtrl Class](../vs140/cmfctoolbardatetimectrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCToolBarsCustomizeDialog Class](../vs140/cmfctoolbarscustomizedialog-class.md)