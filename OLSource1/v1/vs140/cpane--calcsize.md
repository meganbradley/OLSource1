---
title: "CPane::CalcSize"
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
  - "CPane::CalcSize"
  - "CPane.CalcSize"
  - "CalcSize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CalcSize method"
ms.assetid: 8b7770ac-cf6b-463e-b1c1-f59dd793ae1e
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPane::CalcSize
Calculates the size of the pane.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if the pane is being docked vertically, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> otherwise.  
  
## Return Value  
 The default implementation of this method returns a size of (0, 0).  
  
## Remarks  
 Derived classes should override this method.  
  
## Requirements  
 **Header:** afxpane.h  
  
## See Also  
 [CPane Class](../vs140/cpane-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)