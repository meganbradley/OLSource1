---
title: "CMouseManager::GetViewDblClickCommand"
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
  - "CMouseManager::GetViewDblClickCommand"
  - "CMouseManager.GetViewDblClickCommand"
  - "GetViewDblClickCommand"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetViewDblClickCommand method"
ms.assetid: 7076ea28-710b-4368-b811-39a93b277f34
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMouseManager::GetViewDblClickCommand
Returns the command that is executed when the user double-clicks inside the provided view.  
  
## Syntax  
  
```  
UINT GetViewDblClickCommand(  
   int iId   
) const;  
```  
  
#### Parameters  
 [in] `iId`  
 The view ID.  
  
## Return Value  
 The command identifier if the view is associated with a command; otherwise 0.  
  
## Requirements  
 **Header:** afxmousemanager.h  
  
## See Also  
 [CMouseManager Class](../vs140/cmousemanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)