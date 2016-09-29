---
title: "CDataConnection Class"
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
  - "ATL::CDataConnection"
  - "ATL.CDataConnection"
  - "CDataConnection"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDataConnection class"
ms.assetid: 77432d85-4e20-49ec-a0b0-142137828471
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDataConnection Class
Manages the connection with the data source.  
  
## Syntax  
  
```  
class CDataConnection  
```  
  
## Members  
  
### Methods  
  
|||  
|-|-|  
|[CDataConnection](../VS_csharp/cdataconnection--cdataconnection.md)|Constructor. Instantiates and initializes a `CDataConnection` object.|  
|[Copy](../VS_csharp/cdataconnection--copy.md)|Creates a copy of an existing data connection.|  
|[Open](../VS_csharp/cdataconnection--open.md)|Opens a connection to a data source using an initialization string.|  
|[OpenNewSession](../VS_csharp/cdataconnection--opennewsession.md)|Opens a new session on the current connection.|  
  
### Operators  
  
|||  
|-|-|  
|[operator BOOL](../VS_csharp/cdataconnection--operator-bool.md)|Determines whether the current session is open or not.|  
|[operator bool](../VS_csharp/cdataconnection--operator-bool--ole-db-.md)|Determines whether the current session is open or not.|  
|[operator CDataSource&](../VS_csharp/cdataconnection--operator-cdatasource-.md)|Returns a reference to the contained `CDataSource` object.|  
|[operator CDataSource*](../VS_csharp/cdataconnection--operator-cdatasource-.md)|Returns a pointer to the contained `CDataSource` object.|  
|[operator CSession&](../VS_csharp/cdataconnection--operator-csession-.md)|Returns a reference to the contained `CSession` object.|  
|[operator CSession*](../VS_csharp/cdataconnection--operator-csession-.md)|Returns a pointer to the contained `CSession` object.|  
  
## Remarks  
 `CDataConnection` is a useful class for creating clients because it encapsulates necessary objects (data source and session) and some of the work you need to do when connecting to a data source  
  
 Without `CDataConnection`, you have to create a `CDataSource` object, call its [OpenFromInitializationString](../VS_csharp/cdatasource--openfrominitializationstring.md) method, then create an instance of a [CSession](../VS_csharp/csession-class.md) object, call its [Open](../VS_csharp/csession--open.md) method, then create a [CCommand](../VS_csharp/ccommand-class.md) object and call its **Open*** methods.  
  
 With `CDataConnection`, you only need to create a connection object, pass it an initialization string, then use that connection to open commands. If you plan on using your connection to the database repeatedly, it is a good idea to keep the connection open, and `CDataConnection` provides a convenient way to do that.  
  
> [!NOTE]
>  If you are creating a database application that needs to handle multiple sessions, you will need to use [OpenNewSession](../VS_csharp/cdataconnection--opennewsession.md).  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [OLE DB Consumer Templates](../VS_csharp/ole-db-consumer-templates--c---.md)   
 [Consumer Architecture Chart](../VS_csharp/ole-db-consumer-templates-reference.md)