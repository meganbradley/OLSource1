---
title: "CRgn::CreateFromPath"
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
  - "CRgn::CreateFromPath"
  - "CreateFromPath"
  - "CRgn.CreateFromPath"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CRgn class, initialization"
  - "CreateFromPath method"
ms.assetid: de893506-3dd9-4de0-a512-8ccf02e975b8
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRgn::CreateFromPath
Creates a region from the path that is selected into the given device context.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Identifies a device context that contains a closed path.  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
## Remarks  
 The device context identified by the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> parameter must contain a closed path. After <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> converts a path into a region, Windows discards the closed path from the device context.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CRgn Class](../vs140/crgn-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::BeginPath](../vs140/cdc--beginpath.md)   
 [CDC::EndPath](../vs140/cdc--endpath.md)   
 [CDC::SetPolyFillMode](../vs140/cdc--setpolyfillmode.md)