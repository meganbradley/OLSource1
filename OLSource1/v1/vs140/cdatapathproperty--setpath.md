---
title: "CDataPathProperty::SetPath"
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
  - "CDataPathProperty::SetPath"
  - "SetPath"
  - "CDataPathProperty.SetPath"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetPath method"
ms.assetid: 45d7417b-452e-4897-91fb-c62ea7896c18
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDataPathProperty::SetPath
Call this member function to set the pathname of the property.  
  
## Syntax  
  
```  
  
      void SetPath(  
   LPCTSTR lpszPath   
);  
```  
  
#### Parameters  
 `lpszPath`  
 A path, which may be absolute or relative, to the property being loaded asynchronously. `CDataPathProperty` uses URLs, not filenames. If you want a `CDataPathProperty` object for a file, prepend `file://` to the path.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [CDataPathProperty Class](../vs140/cdatapathproperty-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDataPathProperty::GetPath](../vs140/cdatapathproperty--getpath.md)   
 [CDataPathProperty::SetControl](../vs140/cdatapathproperty--setcontrol.md)   
 [CDataPathProperty::CDataPathProperty](../vs140/cdatapathproperty--cdatapathproperty.md)