---
title: "IDBSchemaRowsetImpl::GetRowset"
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
  - "ATL::IDBSchemaRowsetImpl::GetRowset"
  - "ATL.IDBSchemaRowsetImpl.GetRowset"
  - "IDBSchemaRowsetImpl<SessionClass>::GetRowset"
  - "IDBSchemaRowsetImpl.GetRowset"
  - "IDBSchemaRowsetImpl::GetRowset"
  - "ATL::IDBSchemaRowsetImpl<SessionClass>::GetRowset"
  - "GetRowset"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetRowset method"
ms.assetid: 3ae28c22-e186-4a15-8591-b0192e784a6f
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDBSchemaRowsetImpl::GetRowset
Returns a schema rowset.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] An outer **IUnknown** when aggregating; otherwise **NULL**.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] A reference to the requested schema rowset GUID (for example, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>).  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] A count of restrictions to be applied to the rowset.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [in] An array of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>**VARIANT**s that represent the restrictions.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 [in] The IID to request of the newly created schema rowset.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 [in] The number of property sets to set.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 [in/out] An array of [DBPROPSET](https://msdn.microsoft.com/en-us/library/ms714367.aspx) structures to set on the newly created schema rowset.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 [out] A pointer to the requested interface on the newly created schema rowset.  
  
## Remarks  
 This method requires the user to have a schema map in the session class. Using the schema map information, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> creates a given rowset object if the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> parameter is equal to one of the map entries GUIDs. See [SCHEMA_ENTRY](../vs140/schema_entry.md) for a description of the map entry.  
  
 See [IDBSchemaRowset::GetRowset](https://msdn.microsoft.com/en-us/library/ms722634.aspx) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atldb.h  
  
## See Also  
 [IDBSchemaRowsetImpl Class](../vs140/idbschemarowsetimpl-class.md)   
 [IDBSchemaRowsetImpl Class Members](assetId:///e74f6f82-541c-42e7-b4c6-e2d4656a0649)   
 [IDBSchemaRowsetImpl::GetSchemas](../vs140/idbschemarowsetimpl--getschemas.md)   
 [Schema Rowset Classes and Typedef Classes](../vs140/schema-rowset-classes-and-typedef-classes.md)