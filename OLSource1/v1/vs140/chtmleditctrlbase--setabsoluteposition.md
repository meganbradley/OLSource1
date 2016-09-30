---
title: "CHtmlEditCtrlBase::SetAbsolutePosition"
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
  - "CHtmlEditCtrlBase.SetAbsolutePosition"
  - "CHtmlEditCtrlBase::SetAbsolutePosition"
  - "CHtmlEditCtrlBase<T>.SetAbsolutePosition"
  - "CHtmlEditCtrlBase<T>::SetAbsolutePosition"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetAbsolutePosition method, HTML elements"
ms.assetid: 2ddf4b6f-a946-472d-a31a-0d6fced4c3b2
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlEditCtrlBase::SetAbsolutePosition
Sets an element's position property to "absolute" or "static."  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 If true, the element's position property is "absolute"; if false, it is "static."  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 This method sends the [IDM_ABSOLUTE_POSITION command ID](https://msdn.microsoft.com/en-us/library/aa769889.aspx) to the WebBrowser control.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlEditCtrlBase Class](../vs140/chtmleditctrlbase-class.md)   
 [CHtmlEditCtrlBase::GetAbsolutePosition](../vs140/chtmleditctrlbase--getabsoluteposition.md)