---
title: "CDaoRecordset::FillCache"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "FillCache"
  - "CDaoRecordset.FillCache"
  - "CDaoRecordset::FillCache"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "recordsets [C++], caching records"
  - "CDaoRecordset class, filling cache"
  - "FillCache method"
ms.assetid: 0bca1482-c573-490b-9f5b-bb3ce79e946a
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoRecordset::FillCache
Call this member function to cache a specified number of records from the recordset.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the number of rows to fill in the cache. If you omit this parameter, the value is determined by the CacheSize property setting of the underlying DAO object.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A [COleVariant](../vs140/colevariant-class.md) specifying a bookmark. The cache is filled starting from the record indicated by this bookmark. If you omit this parameter, the cache is filled starting from the record indicated by the CacheStart property of the underlying DAO object.  
  
## Remarks  
 Caching improves the performance of an application that retrieves, or fetches, data from a remote server. A cache is space in local memory that holds the data most recently fetched from the server on the assumption that the data will probably be requested again while the application is running. When data is requested, the Microsoft Jet database engine checks the cache for the data first rather than fetching it from the server, which takes more time. Using data caching on non-ODBC data sources has no effect as the data is not saved in the cache.  
  
 Rather than waiting for the cache to be filled with records as they are fetched, you can explicitly fill the cache at any time by calling the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> member function. This is a faster way to fill the cache because <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> fetches several records at once instead of one at a time. For example, while each screenful of records is being displayed, you can have your application call <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to fetch the next screenful of records.  
  
 Any ODBC database accessed with recordset objects can have a local cache. To create the cache, open a recordset object from the remote data source, and then call the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> member functions of the recordset. If <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and *lBookmark* create a range that is partly or wholly outside the range specified by <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, the portion of the recordset outside this range is ignored and is not loaded into the cache. If <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> requests more records than remain in the remote data source, only the remaining records are fetched, and no exception is thrown.  
  
 Records fetched from the cache do not reflect changes made concurrently to the source data by other users.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> fetches only records not already cached. To force an update of all the cached data, call the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> member function with an <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> parameter equal to 0, call <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> again with the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> parameter equal to the size of the cache you originally requested, and then call <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
 For related information, see the topic "FillCache Method" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoRecordset Class](../vs140/cdaorecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoRecordset::GetCacheSize](../vs140/cdaorecordset--getcachesize.md)   
 [CDaoRecordset::GetCacheStart](../vs140/cdaorecordset--getcachestart.md)   
 [CDaoRecordset::SetCacheSize](../vs140/cdaorecordset--setcachesize.md)   
 [CDaoRecordset::SetCacheStart](../vs140/cdaorecordset--setcachestart.md)