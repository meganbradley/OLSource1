---
title: "COleObjectFactory::Register"
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
  - "COleObjectFactory::Register"
  - "COleObjectFactory.Register"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Register method"
  - "COleObjectFactory class, operations"
ms.assetid: 89a573a3-6089-4026-9c64-ae3290676ffb
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleObjectFactory::Register
Registers this object factory with the OLE system DLLs.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Nonzero if the factory is successfully registered; otherwise 0.  
  
## Remarks  
 This function is usually called by [CWinApp::InitInstance](../vs140/cwinapp--initinstance.md) when the application is launched.  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [COleObjectFactory Class](../vs140/coleobjectfactory-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleObjectFactory::Revoke](../vs140/coleobjectfactory--revoke.md)   
 [COleObjectFactory::RegisterAll](../vs140/coleobjectfactory--registerall.md)   
 [CWinApp::InitInstance](../vs140/cwinapp--initinstance.md)