---
title: "CDaoRecordView::OnGetRecordset"
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
  - "CDaoRecordView::OnGetRecordset"
  - "OnGetRecordset"
  - "CDaoRecordView.OnGetRecordset"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDaoRecordView class, getting recordset pointer"
  - "record views, getting recordset pointer"
  - "OnGetRecordset method"
ms.assetid: c303403b-d473-4c7b-a09d-c75546a31039
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoRecordView::OnGetRecordset
Returns a pointer to the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>-derived object associated with the record view.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A pointer to a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>-derived object if the object was successfully created; otherwise a **NULL** pointer.  
  
## Remarks  
 You must override this member function to construct or obtain a recordset object and return a pointer to it. If you declare your record view class with ClassWizard, the wizard writes a default override for you. ClassWizard's default implementation returns the recordset pointer stored in the record view if one exists. If not, it constructs a recordset object of the type you specified with ClassWizard and calls its **Open** member function to open the table or run the query, and then returns a pointer to the object.  
  
 For more information and examples, see the article [Record Views: Using a Record View](../vs140/using-a-record-view---mfc-data-access-.md).  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoRecordView Class](../vs140/cdaorecordview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoRecordset Class](../vs140/cdaorecordset-class.md)   
 [CDaoRecordset::Open](../vs140/cdaorecordset--open.md)