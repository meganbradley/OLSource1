---
title: "CHtmlEditCtrlBase::InsInputSubmit"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CHtmlEditCtrlBase::InsInputSubmit
  - CHtmlEditCtrlBase<T>::InsInputSubmit
  - CHtmlEditCtrlBase.InsInputSubmit
  - CHtmlEditCtrlBase<T>.InsInputSubmit
  - InsInputSubmit
dev_langs: 
  - C++
helpviewer_keywords: 
  - InsInputSubmit method
ms.assetid: 31ce5388-7770-4b36-8025-4457f3687e10
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CHtmlEditCtrlBase::InsInputSubmit
Overwrites a submit control on the current selection.  
  
## Syntax  
  
```  
  
      HRESULT InsInputSubmit(  
   LPCTSTR szId = NULL   
) const;  
```  
  
#### Parameters  
 `szId`  
 The ID for the submit control.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 This method sends the [IDM_INSINPUTSUBMIT command ID](https://msdn.microsoft.com/en-us/library/aa769979.aspx) to the WebBrowser control.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlEditCtrlBase Class](../vs140/chtmleditctrlbase-class.md)