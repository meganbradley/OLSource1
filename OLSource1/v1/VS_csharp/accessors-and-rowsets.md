---
title: "Accessors and Rowsets"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "accessors [C++]"
  - "OLE DB consumer templates, rowset support"
  - "OLE DB consumer templates, accessors"
  - "rowsets [C++], accessing"
  - "bulk rowsets"
  - "CAccessorRowset class, accessor types"
  - "single rowsets"
  - "CArrayRowset class, accessors"
  - "CBulkRowset class, accessors"
  - "array rowsets"
  - "CAccessorBase class"
  - "CRowset class, accessors and rowsets"
  - "accessors [C++], rowsets"
  - "rowsets [C++], supported types"
ms.assetid: edc9c8b3-1a2d-4c2d-869f-7e058c631042
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Accessors and Rowsets
To set and retrieve data, OLE DB Templates use an accessor and a rowset through the [CAccessorRowset](../VS_csharp/caccessorrowset-class.md) class. This class can handle multiple accessors of different types.  
  
## Accessor Types  
 All accessors derive from [CAccessorBase](../VS_csharp/caccessorbase-class.md). `CAccessorBase` provides both parameter and column binding.  
  
 The following figure shows the accessor types.  
  
 ![Accessor types](../VS_csharp/media/vcaccessortypes.gif "vcAccessorTypes")  
Accessor Classes  
  
-   [CAccessor](../VS_csharp/caccessor-class.md) Use this accessor when you know the structure of the database source at design time. `CAccessor` statically binds a database record, which contains the buffer, to the data source.  
  
-   [CDynamicAccessor](../VS_csharp/cdynamicaccessor-class.md) Use this accessor when you do not know the structure of the database at design time. `CDynamicAccessor` calls `IColumnsInfo::GetColumnInfo` to get the database column information. It creates and manages an accessor and the buffer.  
  
-   [CDynamicParameterAccessor](../VS_csharp/cdynamicparameteraccessor-class.md) Use this accessor to handle unknown command types. When you prepare the commands, `CDynamicParameterAccessor` can get parameter information from the `ICommandWithParameters` interface, if the provider supports `ICommandWithParameters`.  
  
-   [CDynamicStringAccessor](../VS_csharp/cdynamicstringaccessor-class.md), [CDynamicStringAccessorA](../VS_csharp/cdynamicstringaccessora-class.md), and [CDynamicStringAccessorW](../VS_csharp/cdynamicstringaccessorw-class.md) Use these classes when you have no knowledge of the database schema. `CDynamicStringAccessorA` retrieves data as ANSI strings; `CDynamicStringAccessorW` retrieves data as Unicode strings.  
  
-   [CManualAccessor](../VS_csharp/cmanualaccessor-class.md) With this class, you can use whatever data types you want if the provider can convert the type. It handles both result columns and command parameters.  
  
 The following table summarizes the support in the OLE DB Template accessor types.  
  
|Accessor type|Dynamic|Handles params|Buffer|Multiple accessors|  
|-------------------|-------------|--------------------|------------|------------------------|  
|`CAccessor`|No|Yes|User|Yes|  
|`CDynamicAccessor`|Yes|No|OLE DB Templates|No|  
|`CDynamicParameterAccessor`|Yes|Yes|OLE DB Templates|No|  
|`CDynamicStringAccessor[A,W]`|Yes|No|OLE DB Templates|No|  
|`CManualAccessor`|Yes|Yes|User|Yes|  
  
## Rowset Types  
 The OLE DB Templates support three kinds of rowsets (see the preceding figure): single rowsets (implemented by [CRowset](../VS_csharp/crowset-class.md)), bulk rowsets (implemented by [CBulkRowset](../VS_csharp/cbulkrowset-class.md)), and array rowsets (implemented by [CArrayRowset](../VS_csharp/carrayrowset-class.md)). Single rowsets fetch a single row handle when `MoveNext` is called. Bulk rowsets can fetch multiple row handles. Array rowsets are rowsets that can be accessed using array syntax.  
  
 The following figure shows the rowset types.  
  
 ![RowsetType graphic](../VS_csharp/media/vcrowsettypes.gif "vcRowsetTypes")  
Rowset Classes  
  
 [Schema rowsets](../VS_csharp/obtaining-metadata-with-schema-rowsets.md) do not access data in the data store but instead access information about the data store, called metadata. Schema rowsets are typically used in situations in which the database structure is not known at compile time and must be obtained at run time.  
  
## See Also  
 [OLE DB Consumer Templates](../VS_csharp/ole-db-consumer-templates--c---.md)