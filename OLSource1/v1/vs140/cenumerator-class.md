---
title: "CEnumerator Class"
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
  - "CEnumerator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CEnumerator class"
ms.assetid: 25805f1b-26e3-402f-af83-1b5fe5ddebf7
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CEnumerator Class
Uses an OLE DB enumerator object, which exposes the [ISourcesRowset](https://msdn.microsoft.com/en-us/library/ms715969.aspx) interface to return a rowset describing all data sources and enumerators.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Methods  
  
|||  
|-|-|  
|[Find](../vs140/cenumerator--find.md)|Searches through available providers (data sources) looking for one with the specified name.|  
|[GetMoniker](../vs140/cenumerator--getmoniker.md)|Retrieves the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> interface for the current record.|  
|[Open](../vs140/cenumerator--open.md)|Opens the enumerator.|  
  
## Remarks  
 You can retrieve the **ISourcesRowset** data indirectly from this class.  
  
## Requirements  
 **Header:**atldbcli.h  
  
## See Also  
 [DBViewer](../vs140/visual-c---samples.md)   
 [OLE DB Consumer Templates](../vs140/ole-db-consumer-templates--c---.md)   
 [Consumer Architecture Chart](../vs140/ole-db-consumer-templates-reference.md)