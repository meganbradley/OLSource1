---
title: "CHtmlEditCtrlBase::RemoveFormat"
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
  - "CHtmlEditCtrlBase<T>::RemoveFormat"
  - "CHtmlEditCtrlBase<T>.RemoveFormat"
  - "RemoveFormat"
  - "CHtmlEditCtrlBase::RemoveFormat"
  - "CHtmlEditCtrlBase.RemoveFormat"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RemoveFormat method"
ms.assetid: e863dbb2-fe87-49cf-97e9-cf5654edaa83
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlEditCtrlBase::RemoveFormat
Removes the formatting tags from the current selection.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 This method sends the [IDM_REMOVEFORMAT command ID](https://msdn.microsoft.com/en-us/library/aa770021.aspx) to the WebBrowser control.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlEditCtrlBase Class](../vs140/chtmleditctrlbase-class.md)