---
title: "ISessionPropertiesImpl::GetProperties"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - ISessionPropertiesImpl::GetProperties
  - ISessionPropertiesImpl.GetProperties
  - GetProperties
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetProperties method
ms.assetid: 48726c2a-9599-4fc5-9940-a932faef91ab
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# ISessionPropertiesImpl::GetProperties
Returns the list of properties in the **DBPROPSET_SESSION** property group that are currently set on the session.  
  
## Syntax  
  
```  
  
      STDMETHOD(GetProperties)(   
   ULONG cPropertyIDSets,   
   const DBPROPIDSET rgPropertyIDSets[],   
   ULONG * pcPropertySets,   
   DBPROPSET ** prgPropertySets    
);  
```  
  
#### Parameters  
 See [ISessionProperties::GetProperties](https://msdn.microsoft.com/en-us/library/ms723643.aspx) in the *OLE DB Programmer's Reference*.  
  
## Requirements  
 **Header:** atldb.h  
  
## See Also  
 [ISessionPropertiesImpl Class](../vs140/isessionpropertiesimpl-class.md)   
 [ISessionPropertiesImpl::SetProperties](../vs140/isessionpropertiesimpl--setproperties.md)