---
title: "COleControl::Load"
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
  - "COleControl.Load"
  - "COleControl::Load"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Load method"
ms.assetid: bcc9cd2e-3d4c-4938-a5b3-cc4ed09b1d3a
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::Load
Resets any previous data loaded asynchronously and initiates a new loading of the control's asynchronous property.  
  
## Syntax  
  
```  
  
      void Load(  
   LPCTSTR strNewPath,  
   CDataPathProperty& prop   
);  
```  
  
#### Parameters  
 *strNewPath*  
 A pointer to a string containing the path that references the absolute location of the asynchronous control property.  
  
 *prop*  
 A [CDataPathProperty](../vs140/cdatapathproperty-class.md) object implementing an asynchronous control property.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDataPathProperty Class](../vs140/cdatapathproperty-class.md)