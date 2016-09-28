---
title: "IDBPropertiesImpl::GetProperties"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "IDBPropertiesImpl::GetProperties"
  - "IDBPropertiesImpl.GetProperties"
  - "GetProperties"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetProperties method"
ms.assetid: ab24aebd-366d-49a1-b49b-bb46c6d90f05
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDBPropertiesImpl::GetProperties
Returns the values of properties in the Data Source, Data Source Information, and Initialization property groups that are currently set on the data source object or the values of properties in the Initialization property group that are currently set on the enumerator.  
  
## Syntax  
  
```  
  
      STDMETHOD(GetProperties)(   
   ULONG cPropertySets,   
   const DBPROPIDSET rgPropertySets[],   
   ULONG * pcProperties,   
   DBPROPSET ** prgProperties    
);  
```  
  
#### Parameters  
 See [IDBProperties::GetProperties](https://msdn.microsoft.com/en-us/library/ms714344.aspx) in the *OLE DB Programmer's Reference*.  
  
 Some parameters correspond to *OLE DB Programmer's Reference* parameters of different names, which are described in **IDBProperties::GetProperties**:  
  
|OLE DB Template parameters|*OLE DB Programmer's Reference* parameters|  
|--------------------------------|------------------------------------------------|  
|`cPropertySets`|`cPropertyIDSets`|  
|`rgPropertySets`|`rgPropertyIDSets`|  
|*pcProperties*|*pcPropertySets*|  
|*prgProperties*|*prgPropertySets*|  
  
## Remarks  
 If the provider is initialized, this method returns the values of properties in the **DBPROPSET_DATASOURCE**, **DBPROPSET_DATASOURCEINFO**, **DBPROPSET_DBINIT** property groups that are currently set on the data source object. If the provider is not initialized, it returns **DBPROPSET_DBINIT** group properties only.  
  
## Requirements  
 **Header:** atldb.h  
  
## See Also  
 [IDBPropertiesImpl Class](../vs140/idbpropertiesimpl-class.md)   
 [IDBPropertiesImpl::GetPropertyInfo](../vs140/idbpropertiesimpl--getpropertyinfo.md)   
 [IDBPropertiesImpl::SetProperties](../vs140/idbpropertiesimpl--setproperties.md)