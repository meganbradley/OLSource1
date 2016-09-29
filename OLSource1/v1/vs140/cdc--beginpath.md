---
title: "CDC::BeginPath"
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
  - "CDC::BeginPath"
  - "BeginPath"
  - "CDC.BeginPath"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "BeginPath method"
  - "CDC class, path functions"
ms.assetid: db3ab7ec-345f-4a9c-a494-627ce8e36fbd
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::BeginPath
Opens a path bracket in the device context.  
  
## Syntax  
  
```  
BOOL BeginPath();  
```  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
## Remarks  
 After a path bracket is open, an application can begin calling GDI drawing functions to define the points that lie in the path. An application can close an open path bracket by calling the `EndPath` member function. When an application calls `BeginPath`, any previous paths are discarded.  
  
 See [BeginPath](http://msdn.microsoft.com/library/windows/desktop/dd183363) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for a list of the drawing functions that define points in a path.  
  
## Example  
 [!code[NVC_MFCDocView#30](../vs140/codesnippet/CPP/cdc--beginpath_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::EndPath](../vs140/cdc--endpath.md)   
 [CDC::FillPath](../vs140/cdc--fillpath.md)   
 [CRgn::CreateFromPath](../vs140/crgn--createfrompath.md)   
 [CDC::SelectClipPath](../vs140/cdc--selectclippath.md)   
 [CDC::StrokeAndFillPath](../vs140/cdc--strokeandfillpath.md)   
 [CDC::StrokePath](../vs140/cdc--strokepath.md)   
 [CDC::WidenPath](../vs140/cdc--widenpath.md)