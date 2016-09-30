---
title: "CHtmlEditCtrlBase::SetOverrideCursor"
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
  - "CHtmlEditCtrlBase<T>.SetOverrideCursor"
  - "CHtmlEditCtrlBase::SetOverrideCursor"
  - "CHtmlEditCtrlBase.SetOverrideCursor"
  - "CHtmlEditCtrlBase<T>::SetOverrideCursor"
  - "SetOverrideCursor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetOverrideCursor method"
ms.assetid: 66083760-f2b4-4169-b618-016d2110d69c
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlEditCtrlBase::SetOverrideCursor
Commands the WebBrowser never to change the mouse pointer.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 If true, the WebBrowser will not change the mouse pointer.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 This method sends the [IDM OVERRIDE_CURSOR command ID](https://msdn.microsoft.com/en-us/library/aa769932.aspx) to the WebBrowser control.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlEditCtrlBase Class](../vs140/chtmleditctrlbase-class.md)