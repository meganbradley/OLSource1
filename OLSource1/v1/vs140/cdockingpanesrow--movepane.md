---
title: "CDockingPanesRow::MovePane"
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
  - "MovePane"
  - "CDockingPanesRow::MovePane"
  - "CDockingPanesRow.MovePane"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MovePane method"
ms.assetid: a7c43852-a9aa-4b94-8773-a64ca4ce65bb
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockingPanesRow::MovePane
[!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
## Syntax  
  
```  
void MovePane(  
   CPane* pControlBar,  
   CPoint ptOffset,  
   BOOL bSwapControlBars,  
   HDWP& hdwp  
);  
void MovePane(  
   CPane* pControlBar,  
   CRect rectTarget,  
   HDWP& hdwp  
);  
void MovePane(  
   CPane* pControlBar,  
   int nOffset,  
   bool bForward,  
   HDWP& hdwp  
);  
void MovePane(  
   CPane* pControlBar,  
   int nAbsolutOffset,  
   HDWP& hdwp  
);  
```  
  
#### Parameters  
 [in] `pControlBar`  
  [in] `ptOffset`  
  [in] `bSwapControlBars`  
  [in] `hdwp`  
  [in] `rectTarget`  
  [in] `nOffset`  
  [in] `bForward`  
  [in] `nAbsolutOffset`  
  
## Remarks  
  
## Requirements  
 **Header:** afxdockingpanesrow.h  
  
## See Also  
 [CDockingPanesRow Class](../vs140/cdockingpanesrow-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)