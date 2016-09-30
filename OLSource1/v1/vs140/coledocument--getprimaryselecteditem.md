---
title: "COleDocument::GetPrimarySelectedItem"
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
  - "GetPrimarySelectedItem"
  - "COleDocument.GetPrimarySelectedItem"
  - "COleDocument::GetPrimarySelectedItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleDocument class, overridables"
  - "GetPrimarySelectedItem method"
ms.assetid: 45620ea0-99bb-49ff-9996-9f19a017645a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDocument::GetPrimarySelectedItem
Called by the framework to retrieve the currently selected OLE item in the specified view.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to the active view object displaying the document.  
  
## Return Value  
 A pointer to the single, selected OLE item; **NULL** if no OLE items are selected or if more than one is selected.  
  
## Remarks  
 The default implementation searches the list of contained OLE items for a single selected item and returns a pointer to it. If there is no item selected, or if there is more than one item selected, the function returns **NULL**. You must override the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> member function in your view class for this function to work. Override this function if you have your own method of storing contained OLE items.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleDocument Class](../vs140/coledocument-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CView::IsSelected](../vs140/cview--isselected.md)