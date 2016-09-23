---
title: "CHtmlEditCtrlBase::SetMultiSelect"
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
  - SetMultiSelect
  - CHtmlEditCtrlBase<T>::SetMultiSelect
  - CHtmlEditCtrlBase::SetMultiSelect
  - CHtmlEditCtrlBase<T>.SetMultiSelect
  - CHtmlEditCtrlBase.SetMultiSelect
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetMultiSelect method
ms.assetid: ff36a102-6ef6-4d68-bfc0-c723d486bdc7
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CHtmlEditCtrlBase::SetMultiSelect
Enables multiple selection.  
  
## Syntax  
  
```  
  
      HRESULT SetMultiSelect(  
   bool bNewValue   
) const;  
```  
  
#### Parameters  
 `bNewValue`  
 If true, allows for the selection of more than one site-selectable element at a time when the user holds down the SHIFT or CTRL keys.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 This method sends the [IDM MULTIPLESELECTION command ID](https://msdn.microsoft.com/en-us/library/aa769929.aspx) to the WebBrowser control.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlEditCtrlBase Class](../vs140/chtmleditctrlbase-class.md)