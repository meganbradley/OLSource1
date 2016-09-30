---
title: "CDocument::PreCloseFrame"
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
  - "PreCloseFrame"
  - "CDocument.PreCloseFrame"
  - "CDocument::PreCloseFrame"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PreCloseFrame method"
  - "CDocument class, overridables"
  - "document frames"
ms.assetid: 10a056d9-ea5e-4fc7-888c-f026297390a5
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDocument::PreCloseFrame
This member function is called by the framework before the frame window is destroyed.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to the [CFrameWnd](../vs140/cframewnd-class.md) that holds the associated **CDocument** object.  
  
## Remarks  
 It can be overridden to provide custom cleanup, but be sure to call the base class as well.  
  
 The default of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> does nothing in **CDocument**. The **CDocument**-derived classes [COleDocument](../vs140/coledocument-class.md) and [CRichEditDoc](../vs140/cricheditdoc-class.md) use this member function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDocument Class](../vs140/cdocument-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)