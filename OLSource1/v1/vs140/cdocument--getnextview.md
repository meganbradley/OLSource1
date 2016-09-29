---
title: "CDocument::GetNextView"
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
  - "CDocument.GetNextView"
  - "CDocument::GetNextView"
  - "GetNextView"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetNextView method"
  - "CDocument class, operations"
  - "document views"
  - "documents, viewing"
ms.assetid: 8fea89b7-c652-4b99-a477-a1adb126e3c8
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDocument::GetNextView
Call this function to iterate through all of the document's views.  
  
## Syntax  
  
```  
  
      virtual CView* GetNextView(  
   POSITION& rPosition   
) const;  
```  
  
#### Parameters  
 `rPosition`  
 A reference to a **POSITION** value returned by a previous call to the `GetNextView` or [GetFirstViewPosition](../vs140/cdocument--getfirstviewposition.md) member functions. This value must not be **NULL**.  
  
## Return Value  
 A pointer to the view identified by `rPosition`.  
  
## Remarks  
 The function returns the view identified by `rPosition` and then sets `rPosition` to the **POSITION** value of the next view in the list. If the retrieved view is the last in the list, then `rPosition` is set to **NULL**.  
  
## Example  
 [!code[NVC_MFCDocView#59](../vs140/codesnippet/CPP/cdocument--getnextview_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDocument Class](../vs140/cdocument-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDocument::AddView](../vs140/cdocument--addview.md)   
 [CDocument::GetFirstViewPosition](../vs140/cdocument--getfirstviewposition.md)   
 [CDocument::RemoveView](../vs140/cdocument--removeview.md)   
 [CDocument::UpdateAllViews](../vs140/cdocument--updateallviews.md)