---
title: "CDaoRecordset::IsBOF"
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
  - CDaoRecordset::IsBOF
  - IsBOF
  - CDaoRecordset.IsBOF
dev_langs: 
  - C++
helpviewer_keywords: 
  - IsBOF method
  - CDaoRecordset class, beginning of file
  - recordsets, beginning of
ms.assetid: ea44bc06-7cba-4cf6-a24e-959bd21b44b1
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDaoRecordset::IsBOF
Call this member function before you scroll from record to record to learn whether you have gone before the first record of the recordset.  
  
## Syntax  
  
```  
  
BOOL IsBOF( ) const;  
  
```  
  
## Return Value  
 Nonzero if the recordset contains no records or if you have scrolled backward before the first record; otherwise 0.  
  
## Remarks  
 You can also call `IsBOF` along with `IsEOF` to determine whether the recordset contains any records or is empty. Immediately after you call **Open**, if the recordset contains no records, `IsBOF` returns nonzero. When you open a recordset that has at least one record, the first record is the current record and `IsBOF` returns 0.  
  
 If the first record is the current record and you call `MovePrev`, `IsBOF` will subsequently return nonzero. If `IsBOF` returns nonzero and you call `MovePrev`, an exception is thrown. If `IsBOF` returns nonzero, the current record is undefined, and any action that requires a current record will result in an exception.  
  
 Effect of specific methods on `IsBOF` and `IsEOF` settings:  
  
-   Calling **Open** internally makes the first record in the recordset the current record by calling **MoveFirst**. Therefore, calling **Open** on an empty set of records causes `IsBOF` and `IsEOF` to return nonzero. (See the following table for the behavior of a failed **MoveFirst** or `MoveLast` call.)  
  
-   All Move operations that successfully locate a record cause both `IsBOF` and `IsEOF` to return 0.  
  
-   An `AddNew` call followed by an **Update** call that successfully inserts a new record will cause `IsBOF` to return 0, but only if `IsEOF` is already nonzero. The state of `IsEOF` will always remain unchanged. As defined by the Microsoft Jet database engine, the current record pointer of an empty recordset is at the end of a file, so any new record is inserted after the current record.  
  
-   Any **Delete** call, even if it removes the only remaining record from a recordset, will not change the value of `IsBOF` or `IsEOF`.  
  
 This table shows which Move operations are allowed with different combinations of `IsBOF`/`IsEOF`.  
  
||MoveFirst, MoveLast|MovePrev,<br /><br /> Move < 0|Move 0|MoveNext,<br /><br /> Move > 0|  
|------|-------------------------|-----------------------------|------------|-----------------------------|  
|`IsBOF`=nonzero,<br /><br /> `IsEOF`=0|Allowed|Exception|Exception|Allowed|  
|`IsBOF`=0,<br /><br /> `IsEOF`=nonzero|Allowed|Allowed|Exception|Exception|  
|Both nonzero|Exception|Exception|Exception|Exception|  
|Both 0|Allowed|Allowed|Allowed|Allowed|  
  
 Allowing a Move operation does not mean that the operation will successfully locate a record. It merely indicates that an attempt to perform the specified Move operation is allowed and will not generate an exception. The value of the `IsBOF` and `IsEOF` member functions may change as a result of the attempted move.  
  
 The effect of Move operations that do not locate a record on the value of `IsBOF` and `IsEOF` settings is shown in the following table.  
  
||IsBOF|IsEOF|  
|------|-----------|-----------|  
|**MoveFirst**, `MoveLast`|Nonzero|Nonzero|  
|**Move** 0|No change|No change|  
|`MovePrev`, **Move** < 0|Nonzero|No change|  
|`MoveNext`, **Move** > 0|No change|Nonzero|  
  
 For related information, see the topic "BOF, EOF Properties" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoRecordset Class](../vs140/cdaorecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoRecordset::IsEOF](../vs140/cdaorecordset--iseof.md)