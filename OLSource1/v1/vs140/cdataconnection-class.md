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
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Methods  
  
|||  
|-|-|  
|[CDataConnection](../vs140/cdataconnection--cdataconnection.md)|Constructor. Instantiates and initializes a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.|  
|[Copy](../vs140/cdataconnection--copy.md)|Creates a copy of an existing data connection.|  
|[Open](../vs140/cdataconnection--open.md)|Opens a connection to a data source using an initialization string.|  
|[OpenNewSession](../vs140/cdataconnection--opennewsession.md)|Opens a new session on the current connection.|  
  
### Operators  
  
|||  
|-|-|  
|[operator BOOL](../vs140/cdataconnection--operator-bool.md)|Determines whether the current session is open or not.|  
|[operator bool](../vs140/cdataconnection--operator-bool--ole-db-.md)|Determines whether the current session is open or not.|  
|[operator CDataSource&](../vs140/cdataconnection--operator-cdatasource-.md)|Returns a reference to the contained <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object.|  
|[operator CDataSource*](../vs140/cdataconnection--operator-cdatasource-.md)|Returns a pointer to the contained <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object.|  
|[operator CSession&](../vs140/cdataconnection--operator-csession-.md)|Returns a reference to the contained <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object.|  
|[operator CSession*](../vs140/cdataconnection--operator-csession-.md)|Returns a pointer to the contained <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object.|  
  
## Remarks  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is a useful class for creating clients because it encapsulates necessary objects (data source and session) and some of the work you need to do when connecting to a data source  
  
 Without <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, you have to create a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object, call its [OpenFromInitializationString](../vs140/cdatasource--openfrominitializationstring.md) method, then create an instance of a [CSession](../vs140/csession-class.md) object, call its [Open](../vs140/csession--open.md) method, then create a [CCommand](../vs140/ccommand-class.md) object and call its **Open*** methods.  
  
 With <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, you only need to create a connection object, pass it an initialization string, then use that connection to open commands. If you plan on using your connection to the database repeatedly, it is a good idea to keep the connection open, and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> provides a convenient way to do that.  
  
> [!NOTE]
>  If you are creating a database application that needs to handle multiple sessions, you will need to use [OpenNewSession](../vs140/cdataconnection--opennewsession.md).  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [OLE DB Consumer Templates](../vs140/ole-db-consumer-templates--c---.md)   
 [Consumer Architecture Chart](../vs140/ole-db-consumer-templates-reference.md)