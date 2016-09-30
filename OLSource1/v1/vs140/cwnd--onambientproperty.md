---
title: "CWnd::OnAmbientProperty"
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
  - "CWnd.OnAmbientProperty"
  - "CWnd::OnAmbientProperty"
  - "OnAmbientProperty"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnAmbientProperty method"
  - "CWnd class, overridables"
ms.assetid: 333ce640-167a-4bc9-bb75-9f35115490f4
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnAmbientProperty
The framework calls this member function to obtain ambient property values from a window that contains OLE controls.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to the site of the control that requested the ambient property.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The dispatch ID of the requested ambient property.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Pointer to a caller-allocated <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> structure, through which the ambient property's value will be returned.  
  
## Return Value  
 **TRUE** if the ambient property is supported; **FALSE** if not.  
  
## Remarks  
 Override this function to alter the default ambient property values returned by an OLE control container to its controls. Any ambient property requests not handled by an overriding function should be forwarded to the base class implementation.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)