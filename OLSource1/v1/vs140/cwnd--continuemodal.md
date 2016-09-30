---
title: "CWnd::ContinueModal"
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
  - "ContinueModal"
  - "CWnd.ContinueModal"
  - "CWnd::ContinueModal"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "modal loop functions"
  - "modal states"
  - "loop structures, modal loops"
  - "modal windows"
  - "ContinueModal method"
ms.assetid: 2c215d85-c068-4eb8-b58f-1090b2e8b271
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::ContinueModal
This member function is called by [RunModalLoop](../vs140/cwnd--runmodalloop.md) to determine when the modal state should be exited.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Nonzero if modal loop is to be continued; 0 when [EndModalLoop](../vs140/cwnd--endmodalloop.md) is called.  
  
## Remarks  
 By default, it returns non-zero until <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is called.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::RunModalLoop](../vs140/cwnd--runmodalloop.md)   
 [CWnd::EndModalLoop](../vs140/cwnd--endmodalloop.md)