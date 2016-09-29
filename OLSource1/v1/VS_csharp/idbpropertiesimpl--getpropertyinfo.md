---
title: "IDBPropertiesImpl::GetPropertyInfo"
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
  - "IDBPropertiesImpl::GetPropertyInfo"
  - "IDBPropertiesImpl.GetPropertyInfo"
  - "GetPropertyInfo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetPropertyInfo method"
ms.assetid: 170e9640-5010-4e0d-8a54-f50b23af08ad
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDBPropertiesImpl::GetPropertyInfo
Returns property information supported by the data source.  
  
## Syntax  
  
```  
  
      STDMETHOD(GetPropertyInfo)(   
   ULONG cPropertySets,   
   const DBPROPIDSET rgPropertySets[],   
   ULONG * pcPropertyInfoSets,   
   DBPROPINFOSET ** prgPropertyInfoSets,   
   OLECHAR ** ppDescBuffer    
);  
```  
  
#### Parameters  
 See [IDBProperties::GetPropertyInfo](https://msdn.microsoft.com/en-us/library/ms718175.aspx) in the *OLE DB Programmer's Reference*.  
  
 Some parameters correspond to *OLE DB Programmer's Reference* parameters of different names, which are described in **IDBProperties::GetPropertyInfo**:  
  
|OLE DB Template parameters|*OLE DB Programmer's Reference* parameters|  
|--------------------------------|------------------------------------------------|  
|`cPropertySets`|`cPropertyIDSets`|  
|`rgPropertySets`|`rgPropertyIDSets`|  
  
## Remarks  
 Uses [IDBInitializeImpl::m_pCUtlPropInfo](../VS_csharp/idbinitializeimpl--m_pcutlpropinfo.md) to implement this functionality.  
  
## Requirements  
 **Header:** atldb.h  
  
## See Also  
 [IDBPropertiesImpl Class](../VS_csharp/idbpropertiesimpl-class.md)   
 [IDBPropertiesImpl::GetProperties](../VS_csharp/idbpropertiesimpl--getproperties.md)   
 [IDBPropertiesImpl::SetProperties](../VS_csharp/idbpropertiesimpl--setproperties.md)