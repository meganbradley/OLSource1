---
title: "CDaoRecordset::SetCacheStart"
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
  - "SetCacheStart"
  - "CDaoRecordset.SetCacheStart"
  - "CDaoRecordset::SetCacheStart"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDaoRecordset class, setting cache start"
  - "SetCacheStart method"
  - "recordsets, setting cache information"
ms.assetid: baf13d1c-1dc9-4b42-88a4-a9c2982eb4c9
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoRecordset::SetCacheStart
Call this member function to specify the bookmark of the first record in the recordset to be cached.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A [COleVariant](../vs140/colevariant-class.md) that specifies the bookmark of the first record in the recordset to be cached.  
  
## Remarks  
 You can use the bookmark value of any record for the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> parameter of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> member function. Make the record you want to start the cache with the current record, establish a bookmark for that record using [SetBookmark](../vs140/cdaorecordset--setbookmark.md), and pass the bookmark value as the parameter for the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> member function.  
  
 The Microsoft Jet database engine requests records within the cache range from the cache, and it requests records outside the cache range from the server.  
  
 Records retrieved from the cache do not reflect changes made concurrently to the source data by other users.  
  
 To force an update of all the cached data, pass the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> parameter of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> as 0, call <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> again with the size of the cache you originally requested, and then call the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> member function.  
  
 Note that if you are not creating a UNICODE recordset, the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object must be explicitly declared ANSI. This can be done by using the [COleVariant::COleVariant](../vs140/colevariant--colevariant.md)**(** <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>**,** <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> **)** form of constructor with <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> set to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> (ANSI) or by using the **COleVariant** function [SetString](../vs140/colevariant--setstring.md)**(** <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>**,** <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> **)** with <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> set to <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
 For related information, see the topic CacheSize, CacheStart Properties" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoRecordset Class](../vs140/cdaorecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoRecordset::FillCache](../vs140/cdaorecordset--fillcache.md)   
 [CDaoRecordset::GetCacheSize](../vs140/cdaorecordset--getcachesize.md)   
 [CDaoRecordset::GetCacheStart](../vs140/cdaorecordset--getcachestart.md)   
 [CDaoRecordset::SetCacheSize](../vs140/cdaorecordset--setcachesize.md)