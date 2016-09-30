---
title: "CComControlBase::SetDirty"
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
  - "CComControlBase::SetDirty"
  - "CComControlBase.SetDirty"
  - "ATL::CComControlBase::SetDirty"
  - "ATL.CComControlBase.SetDirty"
  - "SetDirty"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetDirty method"
ms.assetid: 9e3e22c8-9e17-4971-92cf-9cc707ea8664
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComControlBase::SetDirty
Sets the data member <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> to the value in <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Value of the data member [CComControlBase::m_bRequiresSave](../vs140/ccomcontrolbase--m_brequiressave.md).  
  
## Remarks  
 **SetDirty(TRUE)** should be called to flag that the control has changed since it was last saved. The value of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is retrieved with [CComControlBase::GetDirty](../vs140/ccomcontrolbase--getdirty.md).  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CComControlBase Class](../vs140/ccomcontrolbase-class.md)