---
title: "COleObjectFactory::Revoke"
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
  - "COleObjectFactory.Revoke"
  - "Revoke"
  - "COleObjectFactory::Revoke"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Revoke method"
  - "COleObjectFactory class, operations"
ms.assetid: d8c01c0a-4e60-42ee-b8a6-a728cff48afa
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleObjectFactory::Revoke
Revokes this object factory's registration with the OLE system DLLs.  
  
## Syntax  
  
```  
  
void Revoke( );  
```  
  
## Remarks  
 The framework calls this function automatically before the application terminates. If necessary, call it from an override of [CWinApp::ExitInstance](../vs140/cwinapp--exitinstance.md).  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [COleObjectFactory Class](../vs140/coleobjectfactory-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleObjectFactory::RevokeAll](../vs140/coleobjectfactory--revokeall.md)   
 [COleObjectFactory::Register](../vs140/coleobjectfactory--register.md)   
 [CWinApp::ExitInstance](../vs140/cwinapp--exitinstance.md)