---
title: "CHtmlEditCtrlBase::SetOverwriteMode"
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
  - "CHtmlEditCtrlBase<T>::SetOverwriteMode"
  - "CHtmlEditCtrlBase.SetOverwriteMode"
  - "CHtmlEditCtrlBase<T>.SetOverwriteMode"
  - "CHtmlEditCtrlBase::SetOverwriteMode"
  - "SetOverwriteMode"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetOverwriteMode method"
ms.assetid: cac26728-0fe3-4a5e-9546-04263077391d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlEditCtrlBase::SetOverwriteMode
Toggles the text-entry mode between insert and overwrite.  
  
## Syntax  
  
```  
  
      HRESULT SetOverwriteMode(  
   bool bMode   
) const;  
```  
  
#### Parameters  
 `bMode`  
 If true, text-entry mode is overwrite; if false, text-entry mode is insert.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 This method sends the [IDM OVERWRITE command ID](https://msdn.microsoft.com/en-us/library/aa770016.aspx) to the WebBrowser control.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlEditCtrlBase Class](../vs140/chtmleditctrlbase-class.md)