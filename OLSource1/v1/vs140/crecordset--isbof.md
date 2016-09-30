---
title: "CRecordset::IsBOF"
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
  - "CRecordset.IsBOF"
  - "IsBOF"
  - "CRecordset::IsBOF"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsBOF method"
ms.assetid: db4dcc52-54fd-4d6f-99d1-183d3741fff4
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRecordset::IsBOF
Returns nonzero if the recordset has been positioned before the first record. There is no current record.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Nonzero if the recordset contains no records or if you have scrolled backward before the first record; otherwise 0.  
  
## Remarks  
 Call this member function before you scroll from record to record to learn whether you have gone before the first record of the recordset. You can also use <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> along with <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to determine whether the recordset contains any records or is empty. Immediately after you call **Open**, if the recordset contains no records, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> returns nonzero.When you open a recordset that has at least one record, the first record is the current record and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> returns 0.  
  
 If the first record is the current record and you call <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> will subsequently return nonzero. If <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> returns nonzero and you call <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, an error occurs. If <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> returns nonzero, the current record is undefined, and any action that requires a current record will result in an error.  
  
## Example  
 This example uses <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> to detect the limits of a recordset as the code scrolls through the recordset in both directions.  
  
 [!code[NVC_MFCDatabase#25](../vs140/codesnippet/CPP/crecordset--isbof_1.cpp)]  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CRecordset Class](../vs140/crecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRecordset::IsEOF](../vs140/crecordset--iseof.md)   
 [CRecordset::MoveFirst](../vs140/crecordset--movefirst.md)   
 [CRecordset::MovePrev](../vs140/crecordset--moveprev.md)