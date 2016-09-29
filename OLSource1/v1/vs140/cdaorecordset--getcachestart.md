---
title: "CDaoRecordset::GetCacheStart"
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
  - "CDaoRecordset.GetCacheStart"
  - "CDaoRecordset::GetCacheStart"
  - "GetCacheStart"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "recordsets, getting information"
  - "CDaoRecordset class, getting cache information"
  - "recordsets, caching records"
  - "GetCacheStart method"
ms.assetid: 0be13185-5326-4be5-8095-ed8776391747
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoRecordset::GetCacheStart
Call this member function to obtain the bookmark value of the first record in the recordset to be cached.  
  
## Syntax  
  
```  
  
COleVariant GetCacheStart( );  
  
```  
  
## Return Value  
 A `COleVariant` that specifies the bookmark of the first record in the recordset to be cached.  
  
## Remarks  
 The Microsoft Jet database engine requests records within the cache range from the cache, and it requests records outside the cache range from the server.  
  
> [!NOTE]
>  Records retrieved from the cache do not reflect changes made concurrently to the source data by other users.  
  
 For related information, see the topic "CacheSize, CacheStart Properties" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoRecordset Class](../vs140/cdaorecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoRecordset::FillCache](../vs140/cdaorecordset--fillcache.md)   
 [CDaoRecordset::GetCacheSize](../vs140/cdaorecordset--getcachesize.md)   
 [CDaoRecordset::SetCacheSize](../vs140/cdaorecordset--setcachesize.md)   
 [CDaoRecordset::SetCacheStart](../vs140/cdaorecordset--setcachestart.md)