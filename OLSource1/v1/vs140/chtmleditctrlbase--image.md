---
title: "CHtmlEditCtrlBase::Image"
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
  - "Image"
  - "CHtmlEditCtrlBase<T>::Image"
  - "CHtmlEditCtrlBase::Image"
  - "CHtmlEditCtrlBase<T>.Image"
  - "CHtmlEditCtrlBase.Image"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Image method"
ms.assetid: 0d60899e-e3ad-4434-aac7-b9f2abfe097a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlEditCtrlBase::Image
Overwrites an image on the current selection.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The path and file name of the image to be inserted.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 This method sends the [IDM_IMAGE command ID](https://msdn.microsoft.com/en-us/library/aa769970.aspx) to the WebBrowser control.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlEditCtrlBase Class](../vs140/chtmleditctrlbase-class.md)