---
title: "CDaoRecordset::Seek"
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
  - "CDaoRecordset.Seek"
  - "CDaoRecordset::Seek"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "recordsets, seeking"
  - "Seek method"
  - "CDaoRecordset class, seeking"
ms.assetid: b04ded4e-4aa0-497c-a914-7cb16b9c488c
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoRecordset::Seek
Call this member function to locate the record in an indexed table-type recordset object that satisfies the specified criteria for the current index and make that record the current record.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 One of the following string expressions: "<", "\<=", "=", ">=", or ">".  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to a [COleVariant](../vs140/colevariant-class.md) whose value corresponds to the first field in the index. Required.  
  
 *pKey2*  
 A pointer to a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> whose value corresponds to the second field in the index, if any. Defaults to **NULL**.  
  
 *pKey3*  
 A pointer to a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> whose value corresponds to the third field in the index, if any. Defaults to **NULL**.  
  
 *pKeyArray*  
 A pointer to an array of variants. The array size corresponds to the number of fields in the index.  
  
 *nKeys*  
 An integer corresponding to the size of the array, which is the number of fields in the index.  
  
> [!NOTE]
>  Do not specify wildcards in the keys. Wildcards will cause <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to return no matching records.  
  
## Return Value  
 Nonzero if matching records are found, otherwise 0.  
  
## Remarks  
 Use the second (array) version of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to handle indexes of four fields or more.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> enables high-performance index searching on table-type recordsets. You must set the current index by calling <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> before calling <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. If the index identifies a nonunique key field or fields, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> locates the first record that satisfies the criteria. If you do not set an index, an exception is thrown.  
  
 Note that if you are not creating a UNICODE recordset, the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> objects must be explicitly declared ANSI. This can be done by using the [COleVariant::COleVariant](../vs140/colevariant--colevariant.md)**(** <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>**,** <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> **)** form of constructor with <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> set to <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> (ANSI) or by using the **COleVariant** function [SetString](../vs140/colevariant--setstring.md)**(** <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>**,** <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> **)** with <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> set to <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
 When you call <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, you pass one or more key values and a comparison operator ("<", "\<=", "=", ">=", or ">"). <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> searches through the specified key fields and locates the first record that satisfies the criteria specified by <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>. Once found, <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> returns nonzero, and makes that record current. If <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> fails to locate a match, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> returns zero, and the current record is undefined. When using DAO directly, you must explicitly check the NoMatch property.  
  
 If <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> is "=", ">=", or ">", <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> starts at the beginning of the index. If <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> is "<" or "<=", <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> starts at the end of the index and searches backward unless there are duplicate index entries at the end. In this case, <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> starts at an arbitrary entry among the duplicate index entries at the end of the index.  
  
 There does not have to be a current record when you use <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>.  
  
 To locate a record in a dynaset-type or snapshot-type recordset that satisfies a specific condition, use the Find operations. To include all records, not just those that satisfy a specific condition, use the Move operations to move from record to record.  
  
 You cannot call <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> on an attached table of any type because attached tables must be opened as dynaset-type or snapshot-type recordsets. However, if you call <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> to directly open an installable ISAM database, you can call <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> on tables in that database, although the performance may be slow.  
  
 For related information, see the topic "Seek Method" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoRecordset Class](../vs140/cdaorecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoRecordset::FindFirst](../vs140/cdaorecordset--findfirst.md)   
 [CDaoRecordset::FindLast](../vs140/cdaorecordset--findlast.md)   
 [CDaoRecordset::FindNext](../vs140/cdaorecordset--findnext.md)   
 [CDaoRecordset::FindPrev](../vs140/cdaorecordset--findprev.md)   
 [CDaoRecordset::Move](../vs140/cdaorecordset--move.md)   
 [CDaoRecordset::MoveFirst](../vs140/cdaorecordset--movefirst.md)   
 [CDaoRecordset::MoveLast](../vs140/cdaorecordset--movelast.md)   
 [CDaoRecordset::MoveNext](../vs140/cdaorecordset--movenext.md)   
 [CDaoRecordset::MovePrev](../vs140/cdaorecordset--moveprev.md)   
 [COleVariant::COleVariant](../vs140/colevariant--colevariant.md)   
 [COleVariant::SetString](../vs140/colevariant--setstring.md)