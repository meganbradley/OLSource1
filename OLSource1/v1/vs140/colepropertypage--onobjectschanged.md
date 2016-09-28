---
title: "COlePropertyPage::OnObjectsChanged"
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
  - "COlePropertyPage.OnObjectsChanged"
  - "COlePropertyPage::OnObjectsChanged"
  - "OnObjectsChanged"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnObjectsChanged method"
ms.assetid: 2728d284-89db-41e2-84c3-6a8af54e9626
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COlePropertyPage::OnObjectsChanged
Called by the framework when another OLE control, with new properties, is chosen.  
  
## Syntax  
  
```  
  
virtual void OnObjectsChanged( );  
```  
  
## Remarks  
 When viewing the properties of an OLE control in the developer environment, a modeless dialog box is used to display its property pages. If another control is selected, a different set of property pages must be displayed for the new set of properties. The framework calls this function to notify the property page of the change.  
  
 Override this function to receive notification of this action and perform any special actions.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COlePropertyPage Class](../vs140/colepropertypage-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)