---
title: "COleObjectFactory::OnCreateObject"
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
  - "OnCreateObject"
  - "COleObjectFactory::OnCreateObject"
  - "COleObjectFactory.OnCreateObject"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleObjectFactory class, overridables"
  - "OnCreateObject method"
ms.assetid: 13095e89-8ab0-4bdb-9e99-6c338ecee07e
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleObjectFactory::OnCreateObject
Called by the framework to create a new object.  
  
## Syntax  
  
```  
  
virtual CCmdTarget* OnCreateObject( );  
```  
  
## Return Value  
 A pointer to the created object. It can throw a memory exception if it fails.  
  
## Remarks  
 Override this function to create the object from something other than the [CRuntimeClass](../vs140/cruntimeclass-structure.md) passed to the constructor.  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [COleObjectFactory Class](../vs140/coleobjectfactory-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleObjectFactory::COleObjectFactory](../vs140/coleobjectfactory--coleobjectfactory.md)   
 [CRuntimeClass Structure](../vs140/cruntimeclass-structure.md)