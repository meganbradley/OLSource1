---
title: "CDaoRecordset::CDaoRecordset"
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
  - CDaoRecordset::CDaoRecordset
  - CDaoRecordset.CDaoRecordset
dev_langs: 
  - C++
helpviewer_keywords: 
  - recordsets, creating
  - CDaoRecordset class, constructor
ms.assetid: 4c691d75-9911-4631-aacc-a0f649ae7c57
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDaoRecordset::CDaoRecordset
Constructs a `CDaoRecordset` object.  
  
## Syntax  
  
```  
  
      CDaoRecordset(  
   CDaoDatabase* pDatabase = NULL   
);  
```  
  
#### Parameters  
 `pDatabase`  
 Contains a pointer to a [CDaoDatabase](../vs140/cdaodatabase-class.md) object or the value **NULL**. If not **NULL** and the `CDaoDatabase` object's **Open** member function has not been called to connect it to the data source, the recordset attempts to open it for you during its own [Open](../vs140/cdaorecordset--open.md) call. If you pass **NULL**, a `CDaoDatabase` object is constructed and connected for you using the data source information you specified if you derived your recordset class from `CDaoRecordset`.  
  
## Remarks  
 You can either use `CDaoRecordset` directly or derive an application-specific class from `CDaoRecordset`. You can use ClassWizard to derive your recordset classes.  
  
> [!NOTE]
>  If you derive a `CDaoRecordset` class, your derived class must supply its own constructor. In the constructor of your derived class, call the constructor `CDaoRecordset::CDaoRecordset`, passing the appropriate parameters along to it.  
  
 Pass **NULL** to your recordset constructor to have a `CDaoDatabase` object constructed and connected for you automatically. This is a useful shortcut that does not require you to construct and connect a `CDaoDatabase` object prior to constructing your recordset. If the `CDaoDatabase` object is not open, a [CDaoWorkspace](../vs140/cdaoworkspace-class.md) object will also be created for you that uses the default workspace. For more information, see [CDaoDatabase::CDaoDatabase](../vs140/cdaodatabase--cdaodatabase.md).  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoRecordset Class](../vs140/cdaorecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoRecordset::GetDefaultDBName](../vs140/cdaorecordset--getdefaultdbname.md)   
 [CDaoRecordset::GetDefaultSQL](../vs140/cdaorecordset--getdefaultsql.md)   
 [CDaoRecordset::GetDateCreated](../vs140/cdaorecordset--getdatecreated.md)   
 [CDaoRecordset::GetDateLastUpdated](../vs140/cdaorecordset--getdatelastupdated.md)