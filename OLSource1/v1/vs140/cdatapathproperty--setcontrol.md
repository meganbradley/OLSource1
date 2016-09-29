---
title: "CDataPathProperty::SetControl"
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
  - "CDataPathProperty::SetControl"
  - "CDataPathProperty.SetControl"
  - "SetControl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetControl method"
ms.assetid: 2a13dd80-a76e-41d2-bbb4-cd5a200b8d60
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDataPathProperty::SetControl
Call this member function to associate an asynchronous OLE control with the `CDataPathProperty` object.  
  
## Syntax  
  
```  
  
      void SetControl(  
   COleControl* pControl   
);  
```  
  
#### Parameters  
 `pControl`  
 A pointer to the asynchronous OLE control to be associated with the property.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [CDataPathProperty Class](../vs140/cdatapathproperty-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDataPathProperty::GetControl](../vs140/cdatapathproperty--getcontrol.md)   
 [CDataPathProperty::SetPath](../vs140/cdatapathproperty--setpath.md)   
 [CDataPathProperty::CDataPathProperty](../vs140/cdatapathproperty--cdatapathproperty.md)