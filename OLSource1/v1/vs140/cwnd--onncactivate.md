---
title: "CWnd::OnNcActivate"
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
  - "CWnd.OnNcActivate"
  - "CWnd::OnNcActivate"
  - "WM_NCACTIVATE"
  - "OnNcActivate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnNcActivate method"
  - "WM_NCACTIVATE"
ms.assetid: e2c23aec-13ac-4217-bfb6-ceac1eacd2be
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnNcActivate
The framework calls this member function when the nonclient area needs to be changed to indicate an active or inactive state.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies when a caption bar or icon needs to be changed to indicate an active or inactive state. The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> parameter is **TRUE** if an active caption or icon is to be drawn. It is **FALSE** for an inactive caption or icon.  
  
## Return Value  
 Nonzero if Windows should proceed with default processing; 0 to prevent the caption bar or icon from being deactivated.  
  
## Remarks  
 The default implementation draws the title bar and title-bar text in their active colors if <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is **TRUE** and in their inactive colors if <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is **FALSE**.  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::Default](../vs140/cwnd--default.md)   
 [CWnd::OnNcActivate](../vs140/cwnd--onncactivate.md)