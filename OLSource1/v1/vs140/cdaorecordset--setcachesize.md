---
title: "CDaoRecordset::SetCacheSize"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CDaoRecordset.SetCacheSize
  - SetCacheSize
  - CDaoRecordset::SetCacheSize
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetCacheSize method
  - recordsets, setting cache information
  - CDaoRecordset class, setting cache size
ms.assetid: fd4781aa-25d3-4d2a-a88c-7057a5e23b30
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDaoRecordset::SetCacheSize
Call this member function to set the number of records to be cached.  
  
## Syntax  
  
```  
  
      void SetCacheSize(  
   long lSize   
);  
```  
  
#### Parameters  
 `lSize`  
 Specifies the number of records. A typical value is 100. A setting of 0 turns off caching. The setting must be between 5 and 1200 records. The cache may use a considerable amount of memory.  
  
## Remarks  
 A cache is a space in local memory that holds the data most recently retrieved from the server in the event that the data will be requested again while the application is running. Data caching improves the performance of an application that retrieves data from a remote server through dynaset-type recordset objects. When data is requested, the Microsoft Jet database engine checks the cache for the requested data first rather than retrieving it from the server, which takes more time. Data that does not come from an ODBC data source is not saved in the cache.  
  
 Any ODBC data source, such as an attached table, can have a local cache. To create the cache, open a recordset object from the remote data source, call the `SetCacheSize` and `SetCacheStart` member functions, and then call the `FillCache` member function or step through the records by using one of the Move operations. The `lSize` parameter of the `SetCacheSize` member function can be based on the number of records your application can work with at one time. For example, if you are using a recordset as the source of the data to be displayed on screen, you could pass the `SetCacheSize` `lSize` parameter as 20 to display 20 records at one time.  
  
 For related information, see the topic "CacheSize, CacheStart Properties" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoRecordset Class](../vs140/cdaorecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoRecordset::FillCache](../vs140/cdaorecordset--fillcache.md)   
 [CDaoRecordset::GetCacheSize](../vs140/cdaorecordset--getcachesize.md)   
 [CDaoRecordset::GetCacheStart](../vs140/cdaorecordset--getcachestart.md)   
 [CDaoRecordset::SetCacheStart](../vs140/cdaorecordset--setcachestart.md)