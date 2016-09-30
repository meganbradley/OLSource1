---
title: "CHtmlEditCtrlBase::InsInputUpload"
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
  - "CHtmlEditCtrlBase<T>.InsInputUpload"
  - "InsInputUpload"
  - "CHtmlEditCtrlBase.InsInputUpload"
  - "CHtmlEditCtrlBase::InsInputUpload"
  - "CHtmlEditCtrlBase<T>::InsInputUpload"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "InsInputUpload method"
ms.assetid: c727cf3c-270b-455d-9eb3-456a8cf39ee7
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlEditCtrlBase::InsInputUpload
Overwrites a file upload control on the current selection.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The ID for the file upload control.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 This method sends the [IDM_INSINPUTUPLOAD command ID](https://msdn.microsoft.com/en-us/library/aa769973.aspx) to the WebBrowser control.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlEditCtrlBase Class](../vs140/chtmleditctrlbase-class.md)