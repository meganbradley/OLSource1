---
title: "CHtmlEditCtrlBase::Delete"
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
  - "CHtmlEditCtrlBase.Delete"
  - "CHtmlEditCtrlBase::Delete"
  - "CHtmlEditCtrlBase<T>::Delete"
  - "CHtmlEditCtrlBase<T>.Delete"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Delete method"
ms.assetid: 94c1dbd1-72ca-44de-81f0-0be59a3a5049
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlEditCtrlBase::Delete
Deletes the current selection.  
  
## Syntax  
  
```  
  
HRESULT Delete( ) const;  
  
```  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 This method sends the [IDM_DELETE command ID](https://msdn.microsoft.com/en-us/library/aa769876.aspx) to the WebBrowser control.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlEditCtrlBase Class](../vs140/chtmleditctrlbase-class.md)   
 [CHtmlEditCtrlBase::Cut](../vs140/chtmleditctrlbase--cut.md)