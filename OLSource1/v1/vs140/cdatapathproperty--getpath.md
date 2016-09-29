---
title: "CDataPathProperty::GetPath"
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
  - "CDataPathProperty.GetPath"
  - "GetPath"
  - "CDataPathProperty::GetPath"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetPath method"
ms.assetid: 0090c54f-e5b7-4acf-9878-5174851f4f19
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDataPathProperty::GetPath
Call this member function to retrieve the path, set when the `CDataPathProperty` object was constructed, or specified in **Open**, or specified in a previous call to the `SetPath` member function.  
  
## Syntax  
  
```  
  
CString GetPath( ) const;  
```  
  
## Return Value  
 Returns the pathname to the property itself. Can be empty if no path has been specified.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [CDataPathProperty Class](../vs140/cdatapathproperty-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDataPathProperty::SetPath](../vs140/cdatapathproperty--setpath.md)   
 [CDataPathProperty::Open](../vs140/cdatapathproperty--open.md)   
 [CDataPathProperty::CDataPathProperty](../vs140/cdatapathproperty--cdatapathproperty.md)