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
  
```  
virtual BOOL NegotiateBorderSpace(  
   UINT nBorderCmd,  
   LPRECT lpRectBorder  
);  
```  
  
#### Parameters  
 [in] `nBorderCmd`  
 The border negotiation command. See the Remarks section for possible values.  
  
 [in, out] `lpRectBorder`  
 Dimensions of the border.  
  
## Return Value  
 `TRUE` if the layout must be recalculated; otherwise, `FALSE`.  
  
## Remarks  
 The following table lists the possible values for the `nBorderCmd` parameter.  
  
 `borderGet`  
 Get available OLE client space.  
  
 `borderRequest`  
 Request OLE client space.  
  
 `borderSet`  
 Set OLE client space.  
  
## Requirements  
 **Header:** afxframewndex.h  
  
## See Also  
 [CFrameWndEx Class](../vs140/cframewndex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)