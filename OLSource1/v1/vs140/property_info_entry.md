---
title: "PROPERTY_INFO_ENTRY"
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
  - "PROPERTY_INFO_ENTRY"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PROPERTY_INFO_ENTRY macro"
ms.assetid: f7bd23d6-52b4-4d6a-aa9a-1fca9834c8dc
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# PROPERTY_INFO_ENTRY
Represents a specific property in a property set.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *dwPropID*  
 [in] A [DBPROPID](https://msdn.microsoft.com/en-us/library/ms723882.aspx) value that can be used in conjunction with the property set GUID to identify a property.  
  
## Remarks  
 This macro sets the property value of type <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> to a default value defined in ATLDB.H. To set the property to a value of your choosing, use [PROPERTY_INFO_ENTRY_VALUE](../vs140/property_info_entry_value.md). To set the [VARTYPE](assetId:///317b911b-1805-402d-a9cb-159546bc88b4) and [DBPROPFLAGS](https://msdn.microsoft.com/en-us/library/ms724342.aspx) for the property at the same time, use [PROPERTY_INFO_ENTRY_EX](../vs140/property_info_entry_ex.md).  
  
## Example  
 See [BEGIN_PROPSET_MAP](../vs140/begin_propset_map.md).  
  
## Requirements  
 **Header:** atldb.h  
  
## See Also  
 [Macros for OLE DB Provider Templates](../vs140/macros-for-ole-db-provider-templates.md)   
 [OLE DB Provider Templates](../vs140/ole-db-provider-templates--c---.md)   
 [OLE DB Provider Template Architecture](../vs140/ole-db-provider-template-architecture.md)   
 [Creating an OLE DB Provider](../vs140/creating-an-ole-db-provider.md)