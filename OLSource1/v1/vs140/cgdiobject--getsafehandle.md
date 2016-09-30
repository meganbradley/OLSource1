---
title: "CGdiObject::GetSafeHandle"
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
  - "GetSafeHandle"
  - "CGdiObject::GetSafeHandle"
  - "CGdiObject.GetSafeHandle"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetSafeHandle method"
  - "CGdiObject class, operations"
ms.assetid: 70442824-fdf1-435b-85c1-f28db7784559
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CGdiObject::GetSafeHandle
Returns <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> unless **this** is **NULL**, in which case **NULL** is returned.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to the attached Windows GDI object; otherwise **NULL** if no object is attached.  
  
## Remarks  
 This is part of the general handle interface paradigm and is useful when **NULL** is a valid or special value for a handle.  
  
## Example  
 See the example for [CWnd::IsWindowEnabled](../vs140/cwnd--iswindowenabled.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CGdiObject Class](../vs140/cgdiobject-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)