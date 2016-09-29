---
title: "COleObjectFactory::RevokeAll"
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
  - "COleObjectFactory::RevokeAll"
  - "RevokeAll"
  - "COleObjectFactory.RevokeAll"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RevokeAll method"
  - "COleObjectFactory class, operations"
ms.assetid: a2b44a51-a65d-4572-a90a-d46987c8ab95
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleObjectFactory::RevokeAll
Revokes all of the application's object factories' registrations with the OLE system DLLs.  
  
## Syntax  
  
```  
  
static void PASCAL RevokeAll( );  
```  
  
## Remarks  
 The framework calls this function automatically before the application terminates. If necessary, call it from an override of [CWinApp::ExitInstance](../vs140/cwinapp--exitinstance.md).  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [COleObjectFactory Class](../vs140/coleobjectfactory-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleObjectFactory::Revoke](../vs140/coleobjectfactory--revoke.md)   
 [COleObjectFactory::Register](../vs140/coleobjectfactory--register.md)   
 [CWinApp::ExitInstance](../vs140/cwinapp--exitinstance.md)