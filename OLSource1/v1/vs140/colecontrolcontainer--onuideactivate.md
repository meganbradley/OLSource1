---
title: "COleControlContainer::OnUIDeactivate"
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
  - "OnUIDeactivate"
  - "COleControlContainer::OnUIDeactivate"
  - "COleControlContainer.OnUIDeactivate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleControlContainer class, overridables"
  - "OnUIDeactivate method"
ms.assetid: a1116961-5b25-4f09-a537-b0bf383f1c54
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControlContainer::OnUIDeactivate
Called by the framework when the control site, pointed to by `pSite`, is about to be deactivated.  
  
## Syntax  
  
```  
  
      virtual void OnUIDeactivate(  
   COleControlSite* pSite   
);  
```  
  
#### Parameters  
 `pSite`  
 A pointer to the control site about to be deactivated.  
  
## Remarks  
 When this notification is received, the container should reinstall its user interface and take focus.  
  
## Requirements  
 **Header:** afxocc.h  
  
## See Also  
 [COleControlContainer Class](../vs140/colecontrolcontainer-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)