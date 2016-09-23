---
title: "COleCmdUI::Enable"
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
  - COleCmdUI.Enable
  - COleCmdUI::Enable
dev_langs: 
  - C++
helpviewer_keywords: 
  - Enable method
ms.assetid: d04464d4-bbeb-480d-b414-b2f7a0d76495
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COleCmdUI::Enable
Call this function to set the command flag of the `COleCmdUI` object to **OLECOMDF_ENABLED**, which tells the interface the command is available and enabled, or to clear the command flag.  
  
## Syntax  
  
```  
  
      virtual void Enable(   
   BOOL bOn    
);  
```  
  
#### Parameters  
 `bOn`  
 Indicates whether the command associated with the `COleCmdUI` object should be enabled or disabled. Nonzero enables the command; 0 disables the command.  
  
## Requirements  
 **Header:** afxdocob.h  
  
## See Also  
 [COleCmdUI Class](../vs140/colecmdui-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)