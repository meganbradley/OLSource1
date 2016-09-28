---
title: "CHtmlEditCtrlBase::Is1DElement"
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
  - "CHtmlEditCtrlBase<T>.Is1DElement"
  - "CHtmlEditCtrlBase.Is1DElement"
  - "CHtmlEditCtrlBase<T>::Is1DElement"
  - "CHtmlEditCtrlBase::Is1DElement"
  - "Is1DElement"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Is1DElement method"
ms.assetid: 545b5531-cc59-45d1-8ff7-9e00ed50a4ad
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlEditCtrlBase::Is1DElement
Determines if an element is statically positioned.  
  
## Syntax  
  
```  
  
      HRESULT Is1DElement(  
   bool& bValue   
) const;  
```  
  
#### Parameters  
 `bValue`  
 True if the element is statically positioned, false otherwise.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 This method sends the [IDM_1D_ELEMENT command ID](https://msdn.microsoft.com/en-us/library/aa769885.aspx) to the WebBrowser control.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlEditCtrlBase Class](../vs140/chtmleditctrlbase-class.md)   
 [CHtmlEditCtrlBase::Is2DElement](../vs140/chtmleditctrlbase--is2delement.md)