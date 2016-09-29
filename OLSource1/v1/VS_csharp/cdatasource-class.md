---
title: "CDataSource Class"
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
  - "ATL.CDataSource"
  - "ATL::CDataSource"
  - "CDataSource"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDataSource class"
ms.assetid: 99bf862c-9d5c-4117-9501-aa0e2672085c
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDataSource Class
Corresponds to an OLE DB data source object, which represents a connection through a provider to a data source.  
  
## Syntax  
  
```  
class CDataSource  
```  
  
## Members  
  
### Methods  
  
|||  
|-|-|  
|[Close](../VS_csharp/cdatasource--close.md)|Closes the connection.|  
|[GetInitializationString](../VS_csharp/cdatasource--getinitializationstring.md)|Retrieves the initialization string of the data source that is currently open.|  
|[GetProperties](../VS_csharp/cdatasource--getproperties.md)|Gets the values of properties currently set for the connected data source.|  
|[GetProperty](../VS_csharp/cdatasource--getproperty.md)|Gets the value of a single property currently set for the connected data source.|  
|[Open](../VS_csharp/cdatasource--open.md)|Creates a connection to a provider (data source) using either a **CLSID**, **ProgID**, or a `CEnumerator` moniker provided by the caller.|  
|[OpenFromFileName](../VS_csharp/cdatasource--openfromfilename.md)|Opens a data source from a file specified by the user-supplied file name.|  
|[OpenFromInitializationString](../VS_csharp/cdatasource--openfrominitializationstring.md)|Opens the data source specified by an initialization string.|  
|[OpenWithPromptFileName](../VS_csharp/cdatasource--openwithpromptfilename.md)|Allows the user to select a previously created data link file to open the corresponding data source.|  
|[OpenWithServiceComponents](../VS_csharp/cdatasource--openwithservicecomponents.md)|Opens a data source object using the Data Link dialog box.|  
  
## Remarks  
 One or more database sessions can be created for a single connection. These sessions are represented by `CSession`. You must call [CDataSource::Open](../VS_csharp/cdatasource--open.md) to open the connection before creating a session with `CSession::Open`.  
  
 For an example of how to use `CDataSource`, see the [CatDB](../VS_csharp/visual-c---samples.md) sample.  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [OLE DB Consumer Templates](../VS_csharp/ole-db-consumer-templates--c---.md)   
 [Consumer Architecture Chart](../VS_csharp/ole-db-consumer-templates-reference.md)