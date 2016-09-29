---
title: "COleObjectFactory::UpdateRegistry"
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
  - "COleObjectFactory.UpdateRegistry"
  - "UpdateRegistry"
  - "COleObjectFactory::UpdateRegistry"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "UpdateRegistry method"
  - "COleObjectFactory class, operations"
ms.assetid: 80c46635-590b-40e0-9499-0080bf3f66f1
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleObjectFactory::UpdateRegistry
Registers all of the application's object factories with the OLE system registry.  
  
## Syntax  
  
```  
  
      void UpdateRegistry(  
   LPCTSTR lpszProgID = NULL   
);  
virtual BOOL UpdateRegistry(   
   BOOL bRegister    
);  
```  
  
#### Parameters  
 `lpszProgID`  
 Pointer to a string containing the human-readable program identifier, such as "Excel.Document.5."  
  
 `bRegister`  
 Determines whether the control class's object factory is to be registered.  
  
## Remarks  
 Brief discussions of the two forms for this function follow:  
  
-   **UpdateRegistry(**  `lpszProgID`  **)** Registers this object factory with the OLE system registry. This function is usually called by [CWinApp::InitInstance](../vs140/cwinapp--initinstance.md) when the application is launched.  
  
-   **UpdateRegistry(**  `bRegister`  **)** This form of the function is overridable. If `bRegister` is **TRUE**, this function registers the control class with the system registry. Otherwise, it unregisters the class.  
  
     If you use MFC ActiveX ControlWizard to create your project, ControlWizard supplies an override to this pure virtual function.  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [COleObjectFactory Class](../vs140/coleobjectfactory-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleObjectFactory::Revoke](../vs140/coleobjectfactory--revoke.md)   
 [COleObjectFactory::Register](../vs140/coleobjectfactory--register.md)   
 [COleObjectFactory::UpdateRegistryAll](../vs140/coleobjectfactory--updateregistryall.md)   
 [CWinApp::InitInstance](../vs140/cwinapp--initinstance.md)