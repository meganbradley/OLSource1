---
title: "COleDBRecordView::OnGetRowset"
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
  - "COleDBRecordView::OnGetRowset"
  - "OnGetRowset"
  - "COleDBRecordView.OnGetRowset"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleDBRecordView class, attributes"
  - "OnGetRowset method"
ms.assetid: ba1d4355-9e32-474c-8dcc-3cf8664d6bc9
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDBRecordView::OnGetRowset
Returns a handle for the **CRowset<>** object associated with the record view.  
  
## Syntax  
  
```  
  
   virtual CRowset< >* OnGetRowset(   
) = 0;  
```  
  
## Return Value  
 A standard `HRESULT` value.  
  
## Remarks  
 You must override this member function to construct or obtain a rowset object and return a handle to it. If you declare your record view class with ClassWizard, the wizard writes a default override for you. ClassWizard's default implementation returns the rowset handle stored in the record view if one exists. If not, it constructs a rowset object of the type you specified with ClassWizard and calls its **Open** member function to open the table or run the query, and then returns a handle to the object.  
  
> [!NOTE]
>  Previous to MFC 7.0, `OnGetRowset` returned a pointer to `CRowset`. If you have code that calls `OnGetRowset`, you need to change the return type to the templatized class **CRowset<>**.  
  
## Example  
 [!code[NVC_MFCDatabase#38](../vs140/codesnippet/CPP/coledbrecordview--ongetrowset_1.cpp)]  
  
 For more information and examples, see the article [Record Views: Using a Record View](../vs140/using-a-record-view---mfc-data-access-.md).  
  
## Requirements  
 **Header:** afxoledb.h  
  
## See Also  
 [COleDBRecordView Class](../vs140/coledbrecordview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)