---
title: "CStreamRowset Class"
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
  - "ATL::CStreamRowset<TAccessor>"
  - "ATL::CStreamRowset"
  - "CStreamRowset"
  - "ATL.CStreamRowset<TAccessor>"
  - "ATL.CStreamRowset"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CStreamRowset class"
ms.assetid: a106e953-a38a-464e-8ea5-28963d9e4811
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStreamRowset Class
Used in a `CCommand` or `CTable` declaration.  
  
## Syntax  
  
```  
template <class TAccessor = CAccessorBase>  
class CStreamRowset  
```  
  
#### Parameters  
 `TAccessor`  
 An accessor class.  
  
## Members  
  
### Methods  
  
|||  
|-|-|  
|[CStreamRowset](../vs140/cstreamrowset--cstreamrowset.md)|Constructor. Instantiates and initializes the `CStreamRowset` object.|  
|[Close](../vs140/cstreamrowset--close.md)|Releases the [ISequentialStream](https://msdn.microsoft.com/en-us/library/ms718035.aspx) interface pointer in the class.|  
  
## Remarks  
 Use `CStreamRowset` in your `CCommand` or `CTable` declaration, for example:  
  
 [!code[NVC_OLEDB_Consumer#11](../vs140/codesnippet/CPP/cstreamrowset-class_1.cpp)]  
  
 or  
  
 [!code[NVC_OLEDB_Consumer#12](../vs140/codesnippet/CPP/cstreamrowset-class_2.cpp)]  
  
 `ICommand::Execute` returns an `ISequentialStream` pointer, which is stored in `m_spStream`. You then use the **Read** method to retrieve the (Unicode string) data in XML format. For example:  
  
 [!code[NVC_OLEDB_Consumer#13](../vs140/codesnippet/CPP/cstreamrowset-class_3.cpp)]  
  
 SQL Server 2000 performs the XML formatting, and will return all columns and all rows of the rowset as one XML string.  
  
> [!NOTE]
>  This feature works with SQL Server 2000 only.  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [OLE DB Consumer Templates](../vs140/ole-db-consumer-templates--c---.md)   
 [Consumer Architecture Chart](../vs140/ole-db-consumer-templates-reference.md)