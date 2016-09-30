---
title: "CComControlBase::OnPaint"
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
  - "CComControlBase::OnPaint"
  - "CComControlBase.OnPaint"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnPaint method"
ms.assetid: 34972a7b-245b-48fd-8da1-b697a8a354d9
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComControlBase::OnPaint
Prepares the container for painting, gets the control's client area, then calls the control class's <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> method.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Reserved.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 An existing HDC.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Reserved.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Reserved.  
  
## Return Value  
 Always returns zero.  
  
## Remarks  
 If <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is not NULL, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> assumes it contains a valid HDC and uses it instead of [CComControlBase::m_hWndCD](../vs140/ccomcontrolbase--m_hwndcd.md).  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CComControlBase Class](../vs140/ccomcontrolbase-class.md)