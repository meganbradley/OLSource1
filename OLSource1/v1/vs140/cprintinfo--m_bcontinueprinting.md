---
title: "CPrintInfo::m_bContinuePrinting"
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
  - "CPrintInfo.m_bContinuePrinting"
  - "CPrintInfo::m_bContinuePrinting"
  - "m_bContinuePrinting"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CPrintInfo structure, data members"
  - "m_bContinuePrinting"
ms.assetid: 467c1abc-22f9-46d4-85ec-175f53728f5c
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPrintInfo::m_bContinuePrinting
Contains a flag indicating whether the framework should continue the print loop.  
  
## Remarks  
 If you are doing print-time pagination, you can set this member to **FALSE** in your override of <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> once the end of the document has been reached. You do not have to modify this variable if you have specified the length of the document at the beginning of the print job using the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> member function. The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> member is a public variable of type **BOOL**.  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CPrintInfo Structure](../vs140/cprintinfo-structure.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPrintInfo::SetMaxPage](../vs140/cprintinfo--setmaxpage.md)   
 [CView::OnPrepareDC](../vs140/cview--onpreparedc.md)