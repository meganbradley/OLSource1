---
title: "CDaoRecordset::IsEOF"
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
  - "IsEOF"
  - "CDaoRecordset.IsEOF"
  - "CDaoRecordset::IsEOF"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "recordsets, end of"
  - "IsEOF method"
  - "CDaoRecordset class, end of file"
ms.assetid: 2f1b0ad0-f6f6-4fd4-8186-fd2da84b84f2
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoRecordset::IsEOF
Call this member function as you scroll from record to record to learn whether you have gone beyond the last record of the recordset.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Nonzero if the recordset contains no records or if you have scrolled beyond the last record; otherwise 0.  
  
## Remarks  
 You can also call <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> to determine whether the recordset contains any records or is empty. Immediately after you call **Open**, if the recordset contains no records, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> returns nonzero. When you open a recordset that has at least one record, the first record is the current record and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> returns 0.  
  
 If the last record is the current record when you call <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> will subsequently return nonzero. If <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> returns nonzero and you call <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, an exception is thrown. If <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> returns nonzero, the current record is undefined, and any action that requires a current record will result in an exception.  
  
 Effect of specific methods on <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> settings:  
  
-   Calling **Open** internally makes the first record in the recordset the current record by calling **MoveFirst**. Therefore, calling **Open** on an empty set of records causes <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> to return nonzero. (See the following table for the behavior of a failed **MoveFirst** call.)  
  
-   All Move operations that successfully locate a record cause both <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> to return 0.  
  
-   An <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> call followed by an **Update** call that successfully inserts a new record will cause <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> to return 0, but only if <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is already nonzero. The state of <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> will always remain unchanged. As defined by the Microsoft Jet database engine, the current record pointer of an empty recordset is at the end of a file, so any new record is inserted after the current record.  
  
-   Any **Delete** call, even if it removes the only remaining record from a recordset, will not change the value of <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.  
  
 This table shows which Move operations are allowed with different combinations of <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>/<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.  
  
||MoveFirst, MoveLast|MovePrev,\<br />\<br /> Move < 0|Move 0|MoveNext,\<br />\<br /> Move > 0|  
|------|-------------------------|-----------------------------|------------|-----------------------------|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>=nonzero,\<br />\<br /> <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>=0|Allowed|Exception|Exception|Allowed|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>=0,\<br />\<br /> <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>=nonzero|Allowed|Allowed|Exception|Exception|  
|Both nonzero|Exception|Exception|Exception|Exception|  
|Both 0|Allowed|Allowed|Allowed|Allowed|  
  
 Allowing a Move operation does not mean that the operation will successfully locate a record. It merely indicates that an attempt to perform the specified Move operation is allowed and will not generate an exception. The value of the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> member functions may change as a result of the attempted Move.  
  
 The effect of Move operations that do not locate a record on the value of <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> settings is shown in the following table.  
  
||IsBOF|IsEOF|  
|------|-----------|-----------|  
|**MoveFirst**, <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|Nonzero|Nonzero|  
|**Move** 0|No change|No change|  
|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, **Move** < 0|Nonzero|No change|  
|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, **Move** > 0|No change|Nonzero|  
  
 For related information, see the topic "BOF, EOF Properties" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoRecordset Class](../vs140/cdaorecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoRecordset::IsBOF](../vs140/cdaorecordset--isbof.md)