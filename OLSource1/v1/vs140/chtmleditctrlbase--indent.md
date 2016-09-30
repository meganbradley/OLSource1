---
title: "CHtmlEditCtrlBase::Indent"
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
  - "Indent"
  - "CHtmlEditCtrlBase<T>::Indent"
  - "CHtmlEditCtrlBase.Indent"
  - "CHtmlEditCtrlBase::Indent"
  - "CHtmlEditCtrlBase<T>.Indent"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Indent method"
ms.assetid: 24f7fe22-f100-439a-8d48-d980293be40f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlEditCtrlBase::Indent
Increases the indent of the selected text by one indentation increment.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 This method sends the [IDM_INDENT command ID](https://msdn.microsoft.com/en-us/library/aa769963.aspx) to the WebBrowser control.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlEditCtrlBase Class](../vs140/chtmleditctrlbase-class.md)   
 [CHtmlEditCtrlBase::Outdent](../vs140/chtmleditctrlbase--outdent.md)