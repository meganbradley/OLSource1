---
title: "CDaoRecordset::GetCacheSize"
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
  - CDaoRecordset::GetCacheSize
  - CDaoRecordset.GetCacheSize
  - GetCacheSize
dev_langs: 
  - C++
helpviewer_keywords: 
  - recordsets, getting information
  - CDaoRecordset class, getting cache information
  - GetCacheSize method
  - recordsets, caching records
ms.assetid: 2d8e6176-f785-4db0-9660-934a563a3300
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDaoRecordset::GetCacheSize
Call this member function to obtain the number of records cached.  
  
## Syntax  
  
```  
  
long GetCacheSize( );  
  
```  
  
## Return Value  
 A value that specifies the number of records in a dynaset-type recordset containing data to be locally cached from an ODBC data source.  
  
## Remarks  
 Data caching improves the performance of an application that retrieves data from a remote server through dynaset-type recordset objects. A cache is a space in local memory that holds the data most recently retrieved from the server in the event that the data will be requested again while the application is running. When data is requested, the Microsoft Jet database engine checks the cache for the requested data first rather than retrieving it from the server, which takes more time. Data that does not come from an ODBC data source is not saved in the cache.  
  
 Any ODBC data source, such as an attached table, can have a local cache.  
  
 For related information, see the topic "CacheSize, CacheStart Properties" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoRecordset Class](../vs140/cdaorecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoRecordset::FillCache](../vs140/cdaorecordset--fillcache.md)   
 [CDaoRecordset::GetCacheStart](../vs140/cdaorecordset--getcachestart.md)   
 [CDaoRecordset::SetCacheSize](../vs140/cdaorecordset--setcachesize.md)   
 [CDaoRecordset::SetCacheStart](../vs140/cdaorecordset--setcachestart.md)