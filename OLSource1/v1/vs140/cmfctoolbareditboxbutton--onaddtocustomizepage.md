---
title: "CMFCToolBarEditBoxButton::OnAddToCustomizePage"
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
  - "OnAddToCustomizePage"
  - "CMFCToolBarEditBoxButton.OnAddToCustomizePage"
  - "CMFCToolBarEditBoxButton::OnAddToCustomizePage"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnAddToCustomizePage method"
ms.assetid: 8e8b1fda-c594-4737-a514-09ddbec1bcca
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarEditBoxButton::OnAddToCustomizePage
Called by the framework when the button is added to a **Customize** dialog box.  
  
## Syntax  
  
```  
virtual void OnAddToCustomizePage();  
```  
  
## Remarks  
 This method extends the base class implementation ([CMFCToolBarButton::OnAddToCustomizePage](../vs140/cmfctoolbarbutton--onaddtocustomizepage.md)) by copying the properties from the edit box control in any toolbar that has the same command ID as this object. This method does nothing if no toolbar has an edit box control that has the same command ID as this object.  
  
 For more information about the **Customize** dialog box, see [CMFCToolBarsCustomizeDialog Class](../vs140/cmfctoolbarscustomizedialog-class.md).  
  
## Requirements  
 **Header:** afxtoolbareditboxbutton.h  
  
## See Also  
 [CMFCToolBarEditBoxButton Class](../vs140/cmfctoolbareditboxbutton-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCToolBarButton::OnAddToCustomizePage](../vs140/cmfctoolbarbutton--onaddtocustomizepage.md)   
 [CMFCToolBarsCustomizeDialog Class](../vs140/cmfctoolbarscustomizedialog-class.md)