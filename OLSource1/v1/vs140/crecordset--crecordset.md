---
title: "CRecordset::CRecordset"
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
  - "CRecordset::CRecordset"
  - "CRecordset.CRecordset"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CRecordset class, constructor"
ms.assetid: f706a405-ca6c-4baa-bf19-c8fbebf7292a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRecordset::CRecordset
Constructs a `CRecordset` object.  
  
## Syntax  
  
```  
  
      CRecordset(  
   CDatabase* pDatabase = NULL  
);  
```  
  
#### Parameters  
 `pDatabase`  
 Contains a pointer to a `CDatabase` object or the value **NULL**. If not **NULL** and the `CDatabase` object's **Open** member function has not been called to connect it to the data source, the recordset attempts to open it for you during its own **Open** call. If you pass **NULL**, a `CDatabase` object is constructed and connected for you using the data source information you specified when you derived your recordset class with ClassWizard.  
  
## Remarks  
 You can either use `CRecordset` directly or derive an application-specific class from `CRecordset`. You can use ClassWizard to derive your recordset classes.  
  
> [!NOTE]
>  A derived class *must* supply its own constructor. In the constructor of your derived class, call the constructor `CRecordset::CRecordset`, passing the appropriate parameters along to it.  
  
 Pass **NULL** to your recordset constructor to have a `CDatabase` object constructed and connected for you automatically. This is a useful shorthand that does not require you to construct and connect a `CDatabase` object prior to constructing your recordset.  
  
## Example  
 For more information, see the article [Recordset: Declaring a Class for a Table (ODBC)](../vs140/recordset--declaring-a-class-for-a-table--odbc-.md).  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CRecordset Class](../vs140/crecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRecordset::Open](../vs140/crecordset--open.md)   
 [CRecordset::Close](../vs140/crecordset--close.md)