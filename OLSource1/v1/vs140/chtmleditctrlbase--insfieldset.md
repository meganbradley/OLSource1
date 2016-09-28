---
title: "CHtmlEditCtrlBase::InsFieldSet"
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
  - "InsFieldSet"
  - "CHtmlEditCtrlBase<T>.InsFieldSet"
  - "CHtmlEditCtrlBase::InsFieldSet"
  - "CHtmlEditCtrlBase<T>::InsFieldSet"
  - "CHtmlEditCtrlBase.InsFieldSet"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "InsFieldSet method"
ms.assetid: e58c4f9e-bf78-4333-a59e-10c07d98c220
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlEditCtrlBase::InsFieldSet
Overwrites a box on the current selection.  
  
## Syntax  
  
```  
  
      HRESULT InsFieldSet(  
   LPCTSTR szId = NULL   
) const;  
```  
  
#### Parameters  
 `szId`  
 The ID for the box.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 This method sends the [IDM_INSFIELDSET command ID](https://msdn.microsoft.com/en-us/library/aa769967.aspx) to the WebBrowser control.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlEditCtrlBase Class](../vs140/chtmleditctrlbase-class.md)