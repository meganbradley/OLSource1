---
title: "AfxIsMFCToolBar"
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
  - "AfxIsMFCToolBar"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AfxIsMFCToolBar function"
ms.assetid: 1ecd0671-7dc1-4730-8b8b-552d63a61572
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AfxIsMFCToolBar
Determines whether the given window is a toolbar object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to an object that is derived from <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Return Value  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> if the provided window is a toolbar object; otherwise <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Remarks  
 This method returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> derives from <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. This method is useful when you have to validate that a function or method parameter is a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object.  
  
## Requirements  
 **Header:** afxpriv.h  
  
## See Also  
 [Macros, Global Functions, and Global Variables](../vs140/macros--global-functions--and-global-variables.md)   
 [CWnd Class](../vs140/cwnd-class.md)   
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)