---
title: "CHtmlEditCtrlBase::SetBackColor"
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
  - "CHtmlEditCtrlBase<T>.SetBackColor"
  - "CHtmlEditCtrlBase<T>::SetBackColor"
  - "CHtmlEditCtrlBase::SetBackColor"
  - "CHtmlEditCtrlBase.SetBackColor"
  - "SetBackColor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetBackColor method"
ms.assetid: efa30f4b-8989-43bc-a2ff-b40cc99a43f9
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlEditCtrlBase::SetBackColor
Sets the background color of the current selection.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The color. See <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> in [IDM_BACKCOLOR Command ID](https://msdn.microsoft.com/en-us/library/aa769858.aspx).  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The color. See <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> in [IDM_BACKCOLOR Command ID](https://msdn.microsoft.com/en-us/library/aa769858.aspx).  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 This method sends the [IDM_BACKCOLOR_ command ID](https://msdn.microsoft.com/en-us/library/aa769858.aspx) to the WebBrowser control.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlEditCtrlBase Class](../vs140/chtmleditctrlbase-class.md)   
 [CHtmlEditCtrlBase::GetBackColor](../vs140/chtmleditctrlbase--getbackcolor.md)