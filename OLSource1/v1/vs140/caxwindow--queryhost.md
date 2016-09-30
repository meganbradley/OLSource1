---
title: "CAxWindow::QueryHost"
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
  - "QueryHost"
  - "CAxWindow.QueryHost"
  - "CAxWindow::QueryHost"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "QueryHost method"
ms.assetid: 395e111e-f0cc-43dc-8b07-e83ac78c6b1d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAxWindow::QueryHost
Returns the specified interface of the host.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] Specifies the IID of the control's interface.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [out] A pointer to the interface on the host. In the template version of this method, there is no need for a reference ID as long as a typed interface with an associated UUID is passed.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] The interface that is being queried for.  
  
## Return Value  
 A standard <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> value.  
  
## Remarks  
 The interface of the host allows access to the underlying functionality of the window-hosting code, implemented by **AxWin**.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CAxWindow Class](../vs140/caxwindow-class.md)   
 [CAxWindow::QueryControl](../vs140/caxwindow--querycontrol.md)