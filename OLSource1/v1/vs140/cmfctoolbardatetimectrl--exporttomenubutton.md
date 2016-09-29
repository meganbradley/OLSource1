---
title: "CMFCToolBarDateTimeCtrl::ExportToMenuButton"
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
  - "ExportToMenuButton"
  - "CMFCToolBarDateTimeCtrl::ExportToMenuButton"
  - "CMFCToolBarDateTimeCtrl.ExportToMenuButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ExportToMenuButton method"
ms.assetid: dc1d605e-142c-484d-bb82-f8d6c09ad7bc
caps.latest.revision: 10
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarDateTimeCtrl::ExportToMenuButton
Copies text from the toolbar button to a menu.  
  
## Syntax  
  
```  
virtual BOOL ExportToMenuButton(  
   CMFCToolBarMenuButton& menuButton   
) const;  
```  
  
#### Parameters  
 [in] `menuButton`  
 A reference to the target menu button.  
  
## Return Value  
 This method returns `TRUE`.  
  
## Remarks  
 This method overrides the base class implementation ([CMFCToolBarButton::ExportToMenuButton](../vs140/cmfctoolbarbutton--exporttomenubutton.md)) by loading the string resource that is associated with the command ID of the control. For more information about string resources, see [CStringT::LoadString](../vs140/cstringt--loadstring.md).  
  
## Requirements  
 **Header:** afxtoolbardatetimectrl.h  
  
## See Also  
 [CMFCToolBarDateTimeCtrl Class](../vs140/cmfctoolbardatetimectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCToolBarMenuButton Class](../vs140/cmfctoolbarmenubutton-class.md)   
 [CMFCToolBarButton::ExportToMenuButton](../vs140/cmfctoolbarbutton--exporttomenubutton.md)   
 [CStringT::LoadString](../vs140/cstringt--loadstring.md)