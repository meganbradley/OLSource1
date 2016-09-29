---
title: "PROPERTY_INFO_ENTRY_VALUE"
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
  - "PROPERTY_INFO_ENTRY_VALUE"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PROPERTY_INFO_ENTRY_VALUE macro"
ms.assetid: 9690f7f3-fb20-4a7e-a75f-8a3a1cb1ce0d
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# PROPERTY_INFO_ENTRY_VALUE
Represents a specific property in a property set.  
  
## Syntax  
  
```  
  
PROPERTY_INFO_ENTRY_VALUE(  
dwPropID  
, value )  
```  
  
#### Parameters  
 *dwPropID*  
 [in] A [DBPROPID](https://msdn.microsoft.com/en-us/library/ms723882.aspx) value that can be used in conjunction with the property set GUID to identify a property.  
  
 *value*  
 [in] The property value of type `DWORD`.  
  
## Remarks  
 With this macro, you can directly specify the property value of type `DWORD`. To set the property to default value defined in ATLDB.H, use [PROPERTY_INFO_ENTRY](../VS_csharp/property_info_entry.md). To set the value, flags, and options for the property, use [PROPERTY_INFO_ENTRY_EX](../VS_csharp/property_info_entry_ex.md).  
  
## Example  
 See [BEGIN_PROPSET_MAP](../VS_csharp/begin_propset_map.md).  
  
## Requirements  
 **Header:** atldb.h  
  
## See Also  
 [Macros for OLE DB Provider Templates](../VS_csharp/macros-for-ole-db-provider-templates.md)   
 [OLE DB Provider Templates](../VS_csharp/ole-db-provider-templates--c---.md)   
 [OLE DB Provider Template Architecture](../VS_csharp/ole-db-provider-template-architecture.md)   
 [Creating an OLE DB Provider](../VS_csharp/creating-an-ole-db-provider.md)