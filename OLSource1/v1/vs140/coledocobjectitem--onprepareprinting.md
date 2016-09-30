---
title: "COleDocObjectItem::OnPreparePrinting"
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
  - "COleDocObjectItem::OnPreparePrinting"
  - "COleDocObjectItem.OnPreparePrinting"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnPreparePrinting method"
  - "printing [MFC], preparation"
ms.assetid: d783fd82-1d3e-42ef-bf83-45424049762e
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDocObjectItem::OnPreparePrinting
This member function is called by the framework to prepare a document for printing.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a [CView](../vs140/cview-class.md) object that is sending the print command.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to a [CPrintInfo](../vs140/cprintinfo-structure.md) object that describes the job to be printed.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies whether the entire document is to be printed.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleDocObjectItem Class](../vs140/coledocobjectitem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDocObjectItem::OnPrint](../vs140/coledocobjectitem--onprint.md)