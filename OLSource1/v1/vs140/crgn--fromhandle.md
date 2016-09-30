---
title: "CRgn::FromHandle"
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
  - "CRgn::FromHandle"
  - "CRgn.FromHandle"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CRgn class, operations"
  - "FromHandle method [MFC]"
ms.assetid: 391d75e8-f314-47e1-86d3-82f61e9331e3
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRgn::FromHandle
Returns a pointer to a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object when given a handle to a Windows region.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies a handle to a Windows region.  
  
## Return Value  
 A pointer to a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object. If the function was not successful, the return value is **NULL**.  
  
## Remarks  
 If a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object is not already attached to the handle, a temporary <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object is created and attached. This temporary <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object is valid only until the next time the application has idle time in its event loop, at which time all temporary graphic objects are deleted. Another way of saying this is that the temporary object is only valid during the processing of one window message.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CRgn Class](../vs140/crgn-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)