---
title: "CHtmlEditCtrlBase::InsInputHidden"
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
  - "CHtmlEditCtrlBase<T>.InsInputHidden"
  - "CHtmlEditCtrlBase::InsInputHidden"
  - "CHtmlEditCtrlBase.InsInputHidden"
  - "CHtmlEditCtrlBase<T>::InsInputHidden"
  - "InsInputHidden"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "InsInputHidden method"
ms.assetid: 69be194d-8f75-4d3c-b118-58657aa80f4a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlEditCtrlBase::InsInputHidden
Inserts a hidden control on the current selection.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The ID for the hidden control.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 This method sends the [IDM_INSINPUTHIDDEN command ID](https://msdn.microsoft.com/en-us/library/aa769974.aspx) to the WebBrowser control.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlEditCtrlBase Class](../vs140/chtmleditctrlbase-class.md)