---
title: "CDocument::UpdateAllViews"
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
  - "CDocument.UpdateAllViews"
  - "CDocument::UpdateAllViews"
  - "UpdateAllViews"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "document views, updating"
  - "views, updating"
  - "CDocument class, operations"
  - "UpdateAllViews method"
  - "documents, modifying"
ms.assetid: 7ee165a5-f48b-4065-b497-63cf8682b152
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDocument::UpdateAllViews
Call this function after the document has been modified.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Points to the view that modified the document, or **NULL** if all views are to be updated.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Contains information about the modification.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Points to an object storing information about the modification.  
  
## Remarks  
 You should call this function after you call the [SetModifiedFlag](../vs140/cdocument--setmodifiedflag.md) member function. This function informs each view attached to the document, except for the view specified by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, that the document has been modified. You typically call this function from your view class after the user has changed the document through a view.  
  
 This function calls the [CView::OnUpdate](../vs140/cview--onupdate.md) member function for each of the document's views except the sending view, passing <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. Use these parameters to pass information to the views about the modifications made to the document. You can encode information using <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and/or you can define a [CObject](../vs140/cobject-class.md)-derived class to store information about the modifications and pass an object of that class using <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. Override the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> member function in your [CView](../vs140/cview-class.md)-derived class to optimize the updating of the view's display based on the information passed.  
  
## Example  
 [!code[NVC_MFCDocView#64](../vs140/codesnippet/CPP/cdocument--updateallviews_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDocument Class](../vs140/cdocument-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDocument::SetModifiedFlag](../vs140/cdocument--setmodifiedflag.md)   
 [CDocument::GetFirstViewPosition](../vs140/cdocument--getfirstviewposition.md)   
 [CDocument::GetNextView](../vs140/cdocument--getnextview.md)   
 [CView::OnUpdate](../vs140/cview--onupdate.md)