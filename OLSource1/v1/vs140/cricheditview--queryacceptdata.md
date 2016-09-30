---
title: "CRichEditView::QueryAcceptData"
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
  - "CRichEditView.QueryAcceptData"
  - "QueryAcceptData"
  - "CRichEditView::QueryAcceptData"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CRichEditView class, overridables"
  - "QueryAcceptData method"
ms.assetid: bc2f524f-0b46-44fd-8e5c-1828cf8a4979
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditView::QueryAcceptData
Called by the framework to paste an object into the rich edit.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *lpdataobj*  
 Pointer to the [IDataObject](http://msdn.microsoft.com/library/windows/desktop/ms688421) to query.  
  
 *lpcfFormat*  
 Pointer to the acceptable data format.  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Not used.  
  
 *bReally*  
 Indicates if the paste operation should continue or not.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A handle to the metafile used for drawing the item's icon.  
  
## Return Value  
 An <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> value reporting the success of the operation.  
  
## Remarks  
 Override this function to handle different organization of COM items in your derived document class. This is an advanced overridable.  
  
 For more information on <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, see [Structure of COM Error Codes](http://msdn.microsoft.com/library/windows/desktop/ms690088) and [IDataObject](http://msdn.microsoft.com/library/windows/desktop/ms688421), respectively, in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFCDocView#160](../vs140/codesnippet/CPP/cricheditview--queryacceptdata_1.cpp)]  
  
## Requirements  
 **Header:** afxrich.h  
  
## See Also  
 [CRichEditView Class](../vs140/cricheditview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)