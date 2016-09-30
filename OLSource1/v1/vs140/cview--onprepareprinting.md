---
title: "CView::OnPreparePrinting"
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
  - "OnPreparePrinting"
  - "CView::OnPreparePrinting"
  - "CView.OnPreparePrinting"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnPreparePrinting method"
  - "printing [MFC], preparation"
  - "CView class, overridables"
ms.assetid: a37370e5-90d5-4f26-8136-115629585189
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CView::OnPreparePrinting
Called by the framework before a document is printed or previewed.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Points to a [CPrintInfo](../vs140/cprintinfo-structure.md) structure that describes the current print job.  
  
## Return Value  
 Nonzero to begin printing; 0 if the print job has been canceled.  
  
## Remarks  
 The default implementation does nothing.  
  
 You must override this function to enable printing and print preview. Call the [DoPreparePrinting](../vs140/cview--doprepareprinting.md) member function, passing it the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> parameter, and then return its return value; <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> displays the Print dialog box and creates a printer device context. If you want to initialize the Print dialog box with values other than the defaults, assign values to the members of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. For example, if you know the length of the document, pass the value to the [SetMaxPage](../vs140/cprintinfo--setmaxpage.md) member function of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> before calling <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. This value is displayed in the To: box in the Range portion of the Print dialog box.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> does not display the Print dialog box for a preview job. If you want to bypass the Print dialog box for a print job, check that the **m_bPreview** member of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is **FALSE** and then set it to **TRUE** before passing it to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>; reset it to **FALSE** afterwards.  
  
 If you need to perform initializations that require access to the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object representing the printer device context (for example, if you need to know the page size before specifying the length of the document), override the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> member function.  
  
 If you want to set the value of the **m_nNumPreviewPages** or **m_strPageDesc** members of the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> parameter, do so after calling <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> member function sets **m_nNumPreviewPages** to the value found in the application's .INI file and sets **m_strPageDesc** to its default value.  
  
## Example  
 Override <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and call <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> from the override so that the framework will display a Print dialog box and create a printer DC for you.  
  
 [!code[NVC_MFCDocView#184](../vs140/codesnippet/CPP/cview--onprepareprinting_1.cpp)]  
  
 If you know how many pages the document contains, set the maximum page in <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> before calling <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>. The framework will display the maximum page number in the "to" box of the Print dialog box.  
  
 [!code[NVC_MFCDocView#185](../vs140/codesnippet/CPP/cview--onprepareprinting_2.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CView Class](../vs140/cview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPrintInfo Structure](../vs140/cprintinfo-structure.md)   
 [CView::DoPreparePrinting](../vs140/cview--doprepareprinting.md)   
 [CView::OnBeginPrinting](../vs140/cview--onbeginprinting.md)   
 [CView::OnPrepareDC](../vs140/cview--onpreparedc.md)   
 [CView::OnPrint](../vs140/cview--onprint.md)