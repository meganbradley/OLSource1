---
title: "CFrameWndEx::NegotiateBorderSpace"
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
  - "CFrameWndEx::NegotiateBorderSpace"
  - "CFrameWndEx.NegotiateBorderSpace"
  - "NegotiateBorderSpace"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "NegotiateBorderSpace method"
ms.assetid: 9f5de915-f612-4162-986f-daafcdac217b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFrameWndEx::NegotiateBorderSpace
Implements OLE client border negotiation.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The border negotiation command. See the Remarks section for possible values.  
  
 [in, out] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Dimensions of the border.  
  
## Return Value  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> if the layout must be recalculated; otherwise, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Remarks  
 The following table lists the possible values for the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> parameter.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Get available OLE client space.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Request OLE client space.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Set OLE client space.  
  
## Requirements  
 **Header:** afxframewndex.h  
  
## See Also  
 [CFrameWndEx Class](../vs140/cframewndex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)