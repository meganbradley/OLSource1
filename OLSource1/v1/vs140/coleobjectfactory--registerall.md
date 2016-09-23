---
title: "COleObjectFactory::RegisterAll"
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
  - COleObjectFactory::RegisterAll
  - COleObjectFactory.RegisterAll
  - RegisterAll
dev_langs: 
  - C++
helpviewer_keywords: 
  - RegisterAll method
  - COleObjectFactory class, operations
ms.assetid: afd341e0-18df-43b6-a6fd-fc6edef0f1da
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COleObjectFactory::RegisterAll
Registers all of the application's object factories with the OLE system DLLs.  
  
## Syntax  
  
```  
  
static BOOL PASCAL RegisterAll( );  
```  
  
## Return Value  
 Nonzero if the factories are successfully registered; otherwise 0.  
  
## Remarks  
 This function is usually called by [CWinApp::InitInstance](../vs140/cwinapp--initinstance.md) when the application is launched.  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [COleObjectFactory Class](../vs140/coleobjectfactory-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleObjectFactory::Revoke](../vs140/coleobjectfactory--revoke.md)   
 [COleObjectFactory::Register](../vs140/coleobjectfactory--register.md)   
 [CWinApp::InitInstance](../vs140/cwinapp--initinstance.md)