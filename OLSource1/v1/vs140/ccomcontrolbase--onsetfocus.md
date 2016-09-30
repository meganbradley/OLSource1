---
title: "CComControlBase::OnSetFocus"
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
  - "CComControlBase.OnSetFocus"
  - "CComControlBase::OnSetFocus"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnSetFocus method"
ms.assetid: a47bdc1a-b7e6-46ad-a7a1-c454aec1effd
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComControlBase::OnSetFocus
Checks that the control is in-place active and has a valid control site, then informs the container the control has gained focus.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Reserved.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Reserved.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Reserved.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Flag that indicates whether the window message was successfully handled. The default is <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Return Value  
 Always returns 1.  
  
## Remarks  
 Sends a notification to the container that the control has received focus.  
  
## Requirements  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> atlctl.h  
  
## See Also  
 [CComControlBase Class](../vs140/ccomcontrolbase-class.md)