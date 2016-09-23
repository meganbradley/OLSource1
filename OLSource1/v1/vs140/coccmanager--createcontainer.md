---
title: "COccManager::CreateContainer"
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
  - CreateContainer
  - COccManager::CreateContainer
  - COccManager.CreateContainer
dev_langs: 
  - C++
helpviewer_keywords: 
  - CreateContainer method
  - COccManager class, overridables
ms.assetid: 9b6ed717-96d3-450d-b7ed-668651ad7d2c
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COccManager::CreateContainer
Called by the framework to create a control container.  
  
## Syntax  
  
```  
  
      virtual COleControlContainer* CreateContainer(  
   CWnd* pWnd   
);  
```  
  
#### Parameters  
 `pWnd`  
 A pointer to the window object associated with the custom site container.  
  
## Return Value  
 A pointer to the newly created container; otherwise **NULL**.  
  
## Remarks  
 For more information on creating custom sites, see [COleControlContainer::AttachControlSite](../vs140/colecontrolcontainer--attachcontrolsite.md).  
  
## Requirements  
 **Header:** afxocc.h  
  
## See Also  
 [COccManager Class](../vs140/coccmanager-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)