---
title: "CRecordset::GetStatus"
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
  - "CRecordset.GetStatus"
  - "CRecordset::GetStatus"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CRecordset class, status"
  - "GetStatus method"
ms.assetid: 9f8e2fb5-5d3c-4634-8f87-500f4a556f1f
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRecordset::GetStatus
Determines the index of the current record in the recordset and whether the last record has been seen.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A reference to a **CRecordsetStatus** object. See the Remarks section for more information.  
  
## Remarks  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> attempts to track the index, but under some circumstances this may not be possible. See [GetRecordCount](../vs140/crecordset--getrecordcount.md) for an explanation.  
  
 The **CRecordsetStatus** structure has the following form:  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
 The two members of **CRecordsetStatus** have the following meanings:  
  
-   **m_lCurrentRecord** Contains the zero-based index of the current record in the recordset, if known. If the index cannot be determined, this member contains **AFX_CURRENT_RECORD_UNDEFINED** (–2). If <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is **TRUE** (empty recordset or attempt to scroll before first record), then **m_lCurrentRecord** is set to **AFX_CURRENT_RECORD_BOF** (–1). If on the first record, then it is set to 0, second record 1, and so on.  
  
-   **m_bRecordCountFinal** Nonzero if the total number of records in the recordset has been determined. Generally this must be accomplished by starting at the beginning of the recordset and calling <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> until <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> returns nonzero. If this member is zero, the record count as returned by <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, if not –1, is only a "high water mark" count of the records.  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CRecordset Class](../vs140/crecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRecordset::GetRecordCount](../vs140/crecordset--getrecordcount.md)