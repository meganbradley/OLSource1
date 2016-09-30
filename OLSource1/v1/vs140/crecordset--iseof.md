---
title: "CRecordset::IsEOF"
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
  - "CRecordset.IsEOF"
  - "CRecordset::IsEOF"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsEOF method"
ms.assetid: 5801f1ad-b71a-4b1a-8e42-40abed92a21c
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRecordset::IsEOF
Returns nonzero if the recordset has been positioned after the last record. There is no current record.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Nonzero if the recordset contains no records or if you have scrolled beyond the last record; otherwise 0.  
  
## Remarks  
 Call this member function as you scroll from record to record to learn whether you have gone beyond the last record of the recordset. You can also use <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> to determine whether the recordset contains any records or is empty. Immediately after you call **Open**, if the recordset contains no records, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> returns nonzero. When you open a recordset that has at least one record, the first record is the current record and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> returns 0.  
  
 If the last record is the current record when you call <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> will subsequently return nonzero. If <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> returns nonzero and you call <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, an error occurs. If <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> returns nonzero, the current record is undefined, and any action that requires a current record will result in an error.  
  
## Example  
 See the example for [IsBOF](../vs140/crecordset--isbof.md).  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CRecordset Class](../vs140/crecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRecordset::IsBOF](../vs140/crecordset--isbof.md)   
 [CRecordset::MoveLast](../vs140/crecordset--movelast.md)   
 [CRecordset::MoveNext](../vs140/crecordset--movenext.md)