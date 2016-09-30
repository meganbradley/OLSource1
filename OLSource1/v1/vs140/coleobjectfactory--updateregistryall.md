---
title: "COleObjectFactory::UpdateRegistryAll"
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
  - "COleObjectFactory::UpdateRegistryAll"
  - "COleObjectFactory.UpdateRegistryAll"
  - "UpdateRegistryAll"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "UpdateRegistryAll method"
  - "COleObjectFactory class, operations"
ms.assetid: 60adcf43-f9f7-45ee-a09d-df9ccc6e1c77
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleObjectFactory::UpdateRegistryAll
Registers all of the application's object factories with the OLE system registry.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Determines whether the control class's object factory is to be registered.  
  
## Return Value  
 Nonzero if the factories are successfully updated; otherwise 0.  
  
## Remarks  
 This function is usually called by [CWinApp::InitInstance](../vs140/cwinapp--initinstance.md) when the application is launched.  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [COleObjectFactory Class](../vs140/coleobjectfactory-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleObjectFactory::Revoke](../vs140/coleobjectfactory--revoke.md)   
 [COleObjectFactory::Register](../vs140/coleobjectfactory--register.md)   
 [COleObjectFactory::UpdateRegistry](../vs140/coleobjectfactory--updateregistry.md)   
 [CWinApp::InitInstance](../vs140/cwinapp--initinstance.md)