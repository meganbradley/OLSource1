---
title: "COleControlContainer::COleControlContainer"
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
  - "COleControlContainer.COleControlContainer"
  - "COleControlContainer::COleControlContainer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleControlContainer class, constructor"
ms.assetid: 6d42419a-51f8-4ffa-a4a4-45d4c1c09693
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControlContainer::COleControlContainer
Constructs a `COleControlContainer` object.  
  
## Syntax  
  
```  
  
      explicit COleControlContainer(  
   CWnd* pWnd   
);  
```  
  
#### Parameters  
 `pWnd`  
 A pointer to the parent window of the control container.  
  
## Remarks  
 Once the object has been successfully created, add a custom control site with a call to `AttachControlSite`.  
  
## Requirements  
 **Header:** afxocc.h  
  
## See Also  
 [COleControlContainer Class](../vs140/colecontrolcontainer-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)