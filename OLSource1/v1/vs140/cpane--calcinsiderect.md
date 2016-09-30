---
title: "CPane::CalcInsideRect"
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
  - "CPane.CalcInsideRect"
  - "CalcInsideRect"
  - "CPane::CalcInsideRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CalcInsideRect method"
ms.assetid: b9fd483b-378c-48e3-9098-cec007105c9a
caps.latest.revision: 11
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPane::CalcInsideRect
Calculates the inside rectangle of a pane, including the borders and grippers.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [out] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Contains the size and offset of the client area of the pane.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> if the pane is oriented horizontally; otherwise, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Remarks  
 This method is called by the framework when it has to recalculate the layout for a pane. The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> parameter is filled with the size and offset of the client area of the pane. This includes its borders and grippers.  
  
## Requirements  
 **Header:** afxPane.h  
  
## See Also  
 [CPane Class](../vs140/cpane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)