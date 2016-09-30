---
title: "CAxWindow::AttachControl"
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
  - "CAxWindow::AttachControl"
  - "AttachControl"
  - "CAxWindow.AttachControl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AttachControl method"
ms.assetid: ed80db40-eb52-4746-b46c-f8aff681c318
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAxWindow::AttachControl
Creates a new host object if one isn't already present and attaches the specified control to the host.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] A pointer to the **IUnknown** of the control.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [out] A pointer to the **IUnknown** of the host (the **AxWin** object).  
  
## Return Value  
 A standard <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> value.  
  
## Remarks  
 The control object being attached must be correctly initialized before calling <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CAxWindow Class](../vs140/caxwindow-class.md)   
 [AtlAxAttachControl](../vs140/atlaxattachcontrol.md)