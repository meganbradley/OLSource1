---
title: "CDataExchange::m_pDlgWnd"
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
  - "m_pDlgWnd"
  - "CDataExchange::m_pDlgWnd"
  - "CDataExchange.m_pDlgWnd"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_pDlgWnd"
ms.assetid: 68d2862f-3ffe-464f-9c97-04b408a95cdd
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDataExchange::m_pDlgWnd
Contains a pointer to the [CWnd](../vs140/cwnd-class.md) object for which dialog data exchange (DDX) or validation (DDV) is taking place.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 This object is usually a [CDialog](../vs140/cdialog-class.md) object. Implementors of custom DDX or DDV routines can use this pointer to obtain access to the dialog window that contains the controls they are operating on.  
  
 For more information on writing your own DDX and DDV routines, see [Technical Note 26](../vs140/tn026--ddx-and-ddv-routines.md). For an overview of DDX and DDV, see [Dialog Data Exchange and Validation](../vs140/dialog-data-exchange-and-validation.md) and [Dialog Box Topics](../vs140/dialog-boxes.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDataExchange Class](../vs140/cdataexchange-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)