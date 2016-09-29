---
title: "CDataPathProperty::CDataPathProperty"
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
  - "CDataPathProperty.CDataPathProperty"
  - "CDataPathProperty::CDataPathProperty"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDataPathProperty class, constructor"
ms.assetid: 89d12cb8-e6a2-4216-8556-67c62273928b
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDataPathProperty::CDataPathProperty
Constructs a `CDataPathProperty` object.  
  
## Syntax  
  
```  
  
      CDataPathProperty(  
   COleControl* pControl = NULL  
);  
CDataPathProperty(  
   LPCTSTR lpszPath,  
   COleControl* pControl = NULL  
);  
```  
  
#### Parameters  
 `pControl`  
 A pointer to the OLE control object to be associated with this `CDataPathProperty` object.  
  
 `lpszPath`  
 The path, which may be absolute or relative, used to create an asynchronous moniker that references the actual absolute location of the property. `CDataPathProperty` uses URLs, not filenames. If you want a `CDataPathProperty` object for a file, prepend `file://` to the path.  
  
## Remarks  
 The `COleControl` object pointed to by `pControl` is used by **Open** and retrieved by derived classes. If `pControl` is **NULL**, the control used with **Open** should be set with `SetControl`. If `lpszPath` is **NULL**, you can pass in the path through **Open** or set it with `SetPath`.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [CDataPathProperty Class](../vs140/cdatapathproperty-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDataPathProperty::Open](../vs140/cdatapathproperty--open.md)   
 [CDataPathProperty::SetControl](../vs140/cdatapathproperty--setcontrol.md)