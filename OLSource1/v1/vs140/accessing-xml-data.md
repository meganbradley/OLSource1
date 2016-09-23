---
title: "Accessing XML Data"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - C++
helpviewer_keywords: 
  - data access [C++], XML data
  - XML [C++], accessing data
  - CXMLAccessor class, retrieving XML data
  - data [C++], XML data access
  - rowsets [C++], retrieving XML data
  - CStreamRowset class, retrieving XML data
ms.assetid: 6b693d55-a554-4846-8118-e8773b79b572
caps.latest.revision: 17
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Accessing XML Data
There are two separate methods of retrieving XML data from a data source: one uses [CStreamRowset](../vs140/cstreamrowset-class.md) and the other uses [CXMLAccessor](../vs140/cxmlaccessor-class.md).  
  
|Functionality|CStreamRowset|CXMLAccessor|  
|-------------------|-------------------|------------------|  
|Amount of data transferred|Retrieves data from all columns and rows at once.|Retrieves data from all columns but only one row at a time. You must navigate rows using methods such as `MoveNext`.|  
|Formatting the string|SQL Server formats the XML string and sends it to the consumer.|Retrieves rowset data in its native format (requests that the provider send it as Unicode strings) and then builds the string containing the data in XML format.|  
|Control over formatting|You have some level of control over how the XML string is formatted by setting some SQL Server 2000-specific properties.|You have no control over the format of the generated XML string.|  
  
 While `CStreamRowset` provides a more overall efficient way of retrieving data in XML format, it is only supported by SQL Server 2000.  
  
## Retrieving XML Data Using CStreamRowset  
 You specify [CStreamRowset](../vs140/cstreamrowset-class.md) as the rowset type in your `CCommand` or `CTable` declaration. You can use it with your own accessor or no accessor, for example:  
  
```  
CCommand<CAccessor<CMyAccessor>, CStreamRowset> myCmd;  
```  
  
 -or-  
  
```  
CCommand<CNoAccessor, CStreamRowset> myCmd;  
```  
  
 Normally when you call `CCommand::Open` (specifying, for example, `CRowset` as the `TRowset` class), it obtains an `IRowset`pointer. `ICommand::Execute` returns an `IRowset`pointer, which is stored in the `m_spRowset` member of the `CRowset` object. Methods such as `MoveFirst`, `MoveNext`, and `GetData` use that pointer to retrieve the data.  
  
 By contrast, when you call `CCommand::Open` (but specify `CStreamRowset` as the `TRowset` class), `ICommand::Execute` returns an `ISequentialStream` pointer, which is stored in the `m_spStream` data member of [CStreamRowset](../vs140/cstreamrowset-class.md). You then use the `Read` method to retrieve the (Unicode string) data in XML format. For example:  
  
```  
myCmd.m_spStream->Read()  
```  
  
 SQL Server 2000 performs the XML formatting and returns all columns and all rows of the rowset as one XML string.  
  
 For an example using the `Read` method, see "Adding XML Support to the Consumer" in [Implementing a Simple Consumer](../vs140/implementing-a-simple-consumer.md).  
  
> [!NOTE]
>  XML support using `CStreamRowset` works with SQL Server 2000 only and requires that you have the OLE DB Provider for SQL Server 2000 (installed with MDAC).  
  
## Retrieving XML Data Using CXMLAccessor  
 [CXMLAccessor](../vs140/cxmlaccessor-class.md) allows you to access data from a data source as string data when you have no knowledge of the data store's schema. `CXMLAccessor` works like `CDynamicStringAccessorW` except that the former converts all data accessed from the data store as XML-formatted (tagged) data. The XML tag names match the data store's column names as closely as possible.  
  
 Use `CXMLAccessor` as you would any other accessor class, passing it as a template parameter to `CCommand` or `CTable`:  
  
```  
CTable<CXMLAccessor, CRowset> rs;  
```  
  
 Use [GetXMLRowData](../vs140/cxmlaccessor--getxmlrowdata.md) to retrieve data from the table one row at a time, and navigate rows using methods such as `MoveNext`, for example:  
  
```  
// Open data source, session, and rowset  
hr = rs.MoveFirst();  
while( SUCCEEDED(hr) && hr != DB_S_ENDOFROWSET )  
{  
    CStringW strRowData;  
    myCmd.GetXMLRowData(strRowData);  
  
    printf_s( "%S\n", strRowData );  
  
    hr = rs.MoveNext();  
}  
```  
  
 You can use [GetXMLColumnData](../vs140/cxmlaccessor--getxmlcolumndata.md) to retrieve the column (data type) information as XML-formatted string data.  
  
## See Also  
 [Using Accessors](../vs140/using-accessors.md)