---
title: "CHtmlEditCtrlBase::InsInputImage"
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
  - "CHtmlEditCtrlBase.InsInputImage"
  - "CHtmlEditCtrlBase<T>::InsInputImage"
  - "CHtmlEditCtrlBase::InsInputImage"
  - "CHtmlEditCtrlBase<T>.InsInputImage"
  - "InsInputImage"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "InsInputImage method"
ms.assetid: 6b473bde-9170-465f-90bf-8069fe0d72c8
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlEditCtrlBase::InsInputImage
Overwrites an image control on the current selection.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The ID for the image control.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 This method sends the [IDM_INSINPUTIMAGE command ID](https://msdn.microsoft.com/en-us/library/aa769975.aspx) to the WebBrowser control.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlEditCtrlBase Class](../vs140/chtmleditctrlbase-class.md)