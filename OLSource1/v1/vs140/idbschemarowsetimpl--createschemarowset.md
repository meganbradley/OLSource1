---
title: "IDBSchemaRowsetImpl::CreateSchemaRowset"
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
  - "IDBSchemaRowsetImpl::CreateSchemaRowset"
  - "ATL::IDBSchemaRowsetImpl::CreateSchemaRowset"
  - "CreateSchemaRowset"
  - "IDBSchemaRowsetImpl.CreateSchemaRowset"
  - "ATL.IDBSchemaRowsetImpl.CreateSchemaRowset"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateSchemaRowset method"
ms.assetid: ad3e3e4d-45b9-461c-b7b8-3af6843631b1
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDBSchemaRowsetImpl::CreateSchemaRowset
Implements a COM object creator function for the object specified by the template parameter.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] An outer [IUnknown](http://msdn.microsoft.com/library/windows/desktop/ms680509) when aggregating, otherwise **NULL**.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] The count of restrictions applied to the schema rowset.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] An array of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>**VARIANT**s to be applied to the rowset.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [in] The interface to [QueryInterface](../vs140/queryinterface.md) for on the output **IUnknown**.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 [in] The number of property sets to set.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 [in] An array of [DBPROPSET](https://msdn.microsoft.com/en-us/library/ms714367.aspx) structures that specify the properties being set.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 [out] The outgoing **IUnknown** requested by <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. This **IUnknown** is an interface on the schema rowset object.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 [out] A pointer to an instance of the schema rowset class. Typically, this parameter is not used, but it can be used if you must perform more work on the schema rowset before handing it out to a COM object. The lifetime of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is bound by <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
## Return Value  
 A standard <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> value.  
  
## Remarks  
 This function implements a generic creator for all types of schema rowsets. Typically, the user does not call this function. It is called by the implementation of the schema map.  
  
## Requirements  
 **Header:** atldb.h  
  
## See Also  
 [IDBSchemaRowsetImpl Class](../vs140/idbschemarowsetimpl-class.md)   
 [IDBSchemaRowsetImpl Class Members](assetId:///e74f6f82-541c-42e7-b4c6-e2d4656a0649)   
 [SCHEMA_ENTRY](../vs140/schema_entry.md)   
 [Schema Rowset Classes and Typedef Classes](../vs140/schema-rowset-classes-and-typedef-classes.md)