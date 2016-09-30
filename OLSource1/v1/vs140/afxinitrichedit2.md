---
title: "AfxInitRichEdit2"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "AFXWIN/AfxInitRichEdit2"
  - "AfxInitRichEdit2"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AfxInitRichEdit2 function"
ms.assetid: 4a21857b-e45e-429e-b41a-b09f77fec99f
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AfxInitRichEdit2
Call this function to initialize the rich edit control (version 2.0 and later) for the application.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 Call this function to load the RICHED20.DLL and initialize version 2.0 of the rich edit control. If you call the Create method of [CRichEditCtrl](../vs140/cricheditctrl-class.md), [CRichEditView](../vs140/cricheditview-class.md), or [CRichEditDoc](../vs140/cricheditdoc-class.md), you typically don't need to call this function, but in some cases it might be necessary.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [AfxInitRichEdit](../vs140/afxinitrichedit.md)   
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)