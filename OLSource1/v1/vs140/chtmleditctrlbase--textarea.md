---
title: "CHtmlEditCtrlBase::TextArea"
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
  - "CHtmlEditCtrlBase.TextArea"
  - "CHtmlEditCtrlBase<T>.TextArea"
  - "CHtmlEditCtrlBase::TextArea"
  - "CHtmlEditCtrlBase<T>::TextArea"
  - "TextArea"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "TextArea method"
ms.assetid: 962e4eaa-22e3-49b1-b76c-16f59627eaf2
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlEditCtrlBase::TextArea
Overwrites a multiline text input control on the current selection.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The ID of the multiline text input control.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 This method sends the [IDM TEXTAREA command ID](https://msdn.microsoft.com/en-us/library/aa769986.aspx) to the WebBrowser control.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlEditCtrlBase Class](../vs140/chtmleditctrlbase-class.md)