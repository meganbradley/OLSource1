---
title: "CWnd::OnTouchInput"
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
  - "OnTouchInput"
  - "afxwin/CWnd::OnTouchInput"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnTouchInput"
ms.assetid: d6879a53-9aac-4c06-af4a-ea6345bd3e31
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnTouchInput
Process single input from Windows touch.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Point where screen has been touched (in the client coordinates).  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Number of touch input.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Total number of touch inputs.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Pointer to TOUCHINPUT structure.  
  
## Return Value  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if the application processes Windows touch input; otherwise <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Remarks  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)