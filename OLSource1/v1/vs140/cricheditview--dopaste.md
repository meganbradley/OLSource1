---
title: "CRichEditView::DoPaste"
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
  - "DoPaste"
  - "CRichEditView::DoPaste"
  - "CRichEditView.DoPaste"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CRichEditView class, operations"
  - "DoPaste method"
ms.assetid: 39d3df99-f7ec-46ee-bdbd-0eeed48f1811
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditView::DoPaste
Call this function to paste the OLE item in <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> into this rich edit document/view.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The [COleDataObject](../vs140/coledataobject-class.md) containing the data to paste.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The desired Clipboard format.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The metafile that represents the item to be pasted.  
  
## Remarks  
 The framework calls this function as part of the default implementation of [QueryAcceptData](../vs140/cricheditview--queryacceptdata.md).  
  
 This function determines the type of paste based on the results of the handler for Paste Special. If <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is 0, the new item uses the current iconic representation. If <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is nonzero and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is not **NULL**, the new item uses <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> for its representation.  
  
## Requirements  
 **Header:** afxrich.h  
  
## See Also  
 [CRichEditView Class](../vs140/cricheditview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditCtrl::Paste](../vs140/cricheditctrl--paste.md)   
 [CRichEditView::IsRichEditFormat](../vs140/cricheditview--isricheditformat.md)   
 [CRichEditView::InsertItem](../vs140/cricheditview--insertitem.md)