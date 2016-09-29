---
title: "CAccessorRowset Class"
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
  - "CAccessorRowset"
  - "ATL.CAccessorRowset"
  - "ATL::CAccessorRowset"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CAccessorRowset class"
ms.assetid: bd4f58ed-cebf-4d43-8985-1e5fcbf06953
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAccessorRowset Class
Encapsulates a rowset and its associated accessors in a single class.  
  
## Syntax  
  
```  
template <   
   class TAccessor = CNoAccessor,    
   template <typename T> class TRowset = CRowset    
>  
class CAccessorRowset :   
   public TAccessor,    
   public TRowset<TAccessor>  
```  
  
#### Parameters  
 `TAccessor`  
 An accessor class.  
  
 `TRowset`  
 A rowset class.  
  
## Members  
  
### Methods  
  
|||  
|-|-|  
|[Bind](../VS_csharp/caccessorrowset--bind.md)|Creates bindings (used when **bBind** is specified as false in [CCommand::Open](../VS_csharp/ccommand--open.md)).|  
|[CAccessorRowset](../VS_csharp/caccessorrowset--caccessorrowset.md)|Constructor.|  
|[Close](../VS_csharp/caccessorrowset--close.md)|Closes the rowset and any accessors.|  
|[FreeRecordMemory](../VS_csharp/caccessorrowset--freerecordmemory.md)|Frees any columns in the current record that need to be freed.|  
|[GetColumnInfo](../VS_csharp/caccessorrowset--getcolumninfo.md)|Implements [IColumnsInfo::GetColumnInfo](https://msdn.microsoft.com/en-us/library/ms722704.aspx).|  
  
## Remarks  
 Class `TAccessor` manages the accessor. Class *TRowset* manages the rowset.  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [OLE DB Consumer Templates](../VS_csharp/ole-db-consumer-templates--c---.md)   
 [Consumer Architecture Chart](../VS_csharp/ole-db-consumer-templates-reference.md)