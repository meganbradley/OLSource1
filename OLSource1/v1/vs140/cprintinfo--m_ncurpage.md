---
title: "CPrintInfo::m_nCurPage"
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
  - "CPrintInfo.m_nCurPage"
  - "m_nCurPage"
  - "CPrintInfo::m_nCurPage"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CPrintInfo structure, data members"
  - "m_nCurPage"
ms.assetid: 34ec516a-f7bb-4210-aa57-81991ad117cc
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPrintInfo::m_nCurPage
Contains the number of the current page.  
  
## Remarks  
 The framework calls <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> once for each page of the document, specifying a different value for this member each time; its values range from the value returned by <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to that returned by <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. Use this member in your overrides of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to print the specified page of the document.  
  
 When preview mode is first invoked, the framework reads the value of this member to determine which page of the document should be previewed initially. You can set the value of this member in your override of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to maintain the user's current position in the document when entering preview mode. The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> member is a public variable of type **UINT**.  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CPrintInfo Structure](../vs140/cprintinfo-structure.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPrintInfo::GetFromPage](../vs140/cprintinfo--getfrompage.md)   
 [CPrintInfo::GetToPage](../vs140/cprintinfo--gettopage.md)   
 [CView::OnPrepareDC](../vs140/cview--onpreparedc.md)   
 [CView::OnPreparePrinting](../vs140/cview--onprepareprinting.md)   
 [CView::OnPrint](../vs140/cview--onprint.md)