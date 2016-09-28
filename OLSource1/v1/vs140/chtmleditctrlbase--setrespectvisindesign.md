---
title: "CHtmlEditCtrlBase::SetRespectVisInDesign"
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
  - "SetRespectVisInDesign"
  - "CHtmlEditCtrlBase<T>.SetRespectVisInDesign"
  - "CHtmlEditCtrlBase::SetRespectVisInDesign"
  - "CHtmlEditCtrlBase.SetRespectVisInDesign"
  - "CHtmlEditCtrlBase<T>::SetRespectVisInDesign"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetRespectVisInDesign method"
ms.assetid: 6ebe6ff1-f000-4b16-8db4-b042c9c83163
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlEditCtrlBase::SetRespectVisInDesign
Hides invisible elements in design mode.  
  
## Syntax  
  
```  
  
      HRESULT SetRespectVisInDesign(  
   bool bNewValue   
) const;  
```  
  
#### Parameters  
 `bNewValue`  
 If true, any elements that have a visibility set to "hidden" or display property set to "none" will not be shown in both design mode and browse mode; if false, those elements will be displayed only in browse mode.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 This method sends the [IDM RESPECTVISIBILITY_INDESIGN command ID](https://msdn.microsoft.com/en-us/library/aa770023.aspx) to the WebBrowser control.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlEditCtrlBase Class](../vs140/chtmleditctrlbase-class.md)