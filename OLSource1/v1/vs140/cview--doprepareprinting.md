---
title: "CView::DoPreparePrinting"
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
  - "DoPreparePrinting"
  - "CView.DoPreparePrinting"
  - "CView::DoPreparePrinting"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CView class, operations"
  - "DoPreparePrinting method"
  - "printing [MFC], preparation"
ms.assetid: e1b09ada-7c13-4c11-931f-a11850bef98e
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CView::DoPreparePrinting
Call this function from your override of [OnPreparePrinting](../vs140/cview--onprepareprinting.md) to invoke the Print dialog box and create a printer device context.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Points to a [CPrintInfo](../vs140/cprintinfo-structure.md) structure that describes the current print job.  
  
## Return Value  
 Nonzero if printing or print preview can begin; 0 if the operation has been canceled.  
  
## Remarks  
 This function's behavior depends on whether it is being called for printing or print preview (specified by the **m_bPreview** member of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> parameter). If a file is being printed, this function invokes the Print dialog box, using the values in the [CPrintInfo](../vs140/cprintinfo-structure.md) structure that <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> points to; after the user has closed the dialog box, the function creates a printer device context based on settings the user specified in the dialog box and returns this device context through the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> parameter. This device context is used to print the document.  
  
 If a file is being previewed, this function creates a printer device context using the current printer settings; this device context is used for simulating the printer during preview.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CView Class](../vs140/cview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPrintInfo Structure](../vs140/cprintinfo-structure.md)   
 [CView::OnPreparePrinting](../vs140/cview--onprepareprinting.md)