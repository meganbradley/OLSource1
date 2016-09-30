---
title: "CMDIChildWndEx::IsReadOnly"
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
  - "CMDIChildWndEx::IsReadOnly"
  - "CMDIChildWndEx.IsReadOnly"
  - "IsReadOnly"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsReadOnly method"
ms.assetid: 99473388-a70d-4687-b78e-b8f27adfbf48
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMDIChildWndEx::IsReadOnly
Specifies whether the document that is displayed in the child window is read-only.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> if the document is read-only; otherwise <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Remarks  
 This function is used to prevent saving of read-only documents.  
  
## Example  
 The following example demonstrates overriding the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> method. This code snippet comes from the [VisualStudioDemo Sample: MFC Visual Studio Application](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_VisualStudioDemo#2](../vs140/codesnippet/CPP/cmdichildwndex--isreadonly_1.cpp)]  
  
## Requirements  
 **Header:** afxMDIChildWndEx.h  
  
## See Also  
 [CMDIChildWndEx Class](../vs140/cmdichildwndex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)