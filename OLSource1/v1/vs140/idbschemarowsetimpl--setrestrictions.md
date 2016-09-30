---
title: "IDBSchemaRowsetImpl::SetRestrictions"
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
  - "IDBSchemaRowsetImpl::SetRestrictions"
  - "SetRestrictions"
  - "IDBSchemaRowsetImpl.SetRestrictions"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetRestrictions method"
ms.assetid: 707d5065-b853-4d38-9b67-3066b4d3b279
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDBSchemaRowsetImpl::SetRestrictions
Specifies which restrictions you support on a particular schema rowset.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] The number of restrictions in the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> array and the number of GUIDs in the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> array.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] An array of the GUIDs of the schema rowsets for which to fetch restrictions. Each array element contains the GUID of one schema rowset (for example, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>).  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 [in] An array of length <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> of restriction values to be set. Each element corresponds to the restrictions on the schema rowset identified by the GUID. If a schema rowset is not supported by the provider, the element is set to zero. Otherwise, the **ULONG** value contains a bit mask that represents the restrictions supported on that schema rowset. For more information on which restrictions correspond to a particular schema rowset, consult the table of schema rowset GUIDs in [IDBSchemaRowset](https://msdn.microsoft.com/en-us/library/ms713686.aspx) in the *OLE DB Programmer's Reference* in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Remarks  
 The **IDBSchemaRowset** object calls <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to determine which restrictions you support on a particular schema rowset (it is called by [GetSchemas](../vs140/idbschemarowsetimpl--getschemas.md) through an upcasted pointer). Restrictions allow consumers to fetch only matching rows (for example, find all the columns in the table "MyTable"). Restrictions are optional, and in the case in which none are supported (the default), all data is always returned.  
  
 The default implementation of this method sets the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> array elements to 0. Override the default in your session class to set restrictions other than the default.  
  
 For information on implementing schema rowset support, see [Supporting Schema Rowsets](../vs140/supporting-schema-rowsets.md).  
  
 For an example of an provider that supports schema rowsets, see the [UpdatePV](../vs140/visual-c---samples.md) sample.  
  
 For more information on schema rowsets, see [IDBSchemaRowset](https://msdn.microsoft.com/en-us/library/ms713686.aspx) in the *OLE DB Programmer's Reference* in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atldb.h  
  
## See Also  
 [IDBSchemaRowsetImpl Class](../vs140/idbschemarowsetimpl-class.md)   
 [IDBSchemaRowsetImpl Class Members](assetId:///e74f6f82-541c-42e7-b4c6-e2d4656a0649)   
 [Schema Rowset Classes and Typedef Classes](../vs140/schema-rowset-classes-and-typedef-classes.md)   
 [Supporting Schema Rowsets](../vs140/supporting-schema-rowsets.md)   
 [UpdatePV](../vs140/visual-c---samples.md)