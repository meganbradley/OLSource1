---
title: "CHtmlEditCtrlBase::Is2DElement"
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
  - "CHtmlEditCtrlBase.Is2DElement"
  - "Is2DElement"
  - "CHtmlEditCtrlBase<T>.Is2DElement"
  - "CHtmlEditCtrlBase<T>::Is2DElement"
  - "CHtmlEditCtrlBase::Is2DElement"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Is2DElement method"
ms.assetid: c6a81e5a-7769-4456-a66c-df1111ea9e23
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlEditCtrlBase::Is2DElement
Determines if an element is absolutely positioned.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 True if the element is absolutely positioned, false otherwise.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 This method sends the [IDM_2D_ELEMENT command ID](https://msdn.microsoft.com/en-us/library/aa769886.aspx) to the WebBrowser control.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlEditCtrlBase Class](../vs140/chtmleditctrlbase-class.md)   
 [CHtmlEditCtrlBase::Is1DElement](../vs140/chtmleditctrlbase--is1delement.md)