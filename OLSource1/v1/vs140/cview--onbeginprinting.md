---
title: "CView::OnBeginPrinting"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - OnBeginPrinting
  - CView::OnBeginPrinting
  - CView.OnBeginPrinting
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnBeginPrinting method
  - printing [MFC], beginning
  - CView class, overridables
ms.assetid: 63b58323-f95b-41c5-a0ef-db13119b1f6e
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CView::OnBeginPrinting
Called by the framework at the beginning of a print or print preview job, after `OnPreparePrinting` has been called.  
  
## Syntax  
  
```  
  
      virtual void OnBeginPrinting(  
   CDC* pDC,  
   CPrintInfo* pInfo   
);  
```  
  
#### Parameters  
 `pDC`  
 Points to the printer device context.  
  
 `pInfo`  
 Points to a [CPrintInfo](../vs140/cprintinfo-structure.md) structure that describes the current print job.  
  
## Remarks  
 The default implementation of this function does nothing. Override this function to allocate any GDI resources, such as pens or fonts, needed specifically for printing. Select the GDI objects into the device context from within the [OnPrint](../vs140/cview--onprint.md) member function for each page that uses them. If you are using the same view object to perform both screen display and printing, use separate variables for the GDI resources needed for each display; this allows you to update the screen during printing.  
  
 You can also use this function to perform initializations that depend on properties of the printer device context. For example, the number of pages needed to print the document may depend on settings that the user specified from the Print dialog box (such as page length). In such a situation, you cannot specify the document length in the [OnPreparePrinting](../vs140/cview--onprepareprinting.md) member function, where you would normally do so; you must wait until the printer device context has been created based on the dialog box settings. [OnBeginPrinting](#_mfc_cview.3a3a.onbeginprinting) is the first overridable function that gives you access to the [CDC](../vs140/cdc-class.md) object representing the printer device context, so you can set the document length from this function. Note that if the document length is not specified by this time, a scroll bar is not displayed during print preview.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CView Class](../vs140/cview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CView::OnEndPrinting](../vs140/cview--onendprinting.md)   
 [CView::OnPreparePrinting](../vs140/cview--onprepareprinting.md)   
 [CView::OnPrint](../vs140/cview--onprint.md)