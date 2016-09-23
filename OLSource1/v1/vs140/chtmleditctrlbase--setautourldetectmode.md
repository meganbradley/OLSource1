---
title: "CHtmlEditCtrlBase::SetAutoURLDetectMode"
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
  - CHtmlEditCtrlBase<T>.SetAutoURLDetectMode
  - CHtmlEditCtrlBase::SetAutoURLDetectMode
  - CHtmlEditCtrlBase<T>::SetAutoURLDetectMode
  - CHtmlEditCtrlBase.SetAutoURLDetectMode
  - SetAutoURLDetectMode
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetAutoURLDetectMode method
ms.assetid: 4c089b00-5127-4bc5-81c3-55833a421779
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CHtmlEditCtrlBase::SetAutoURLDetectMode
Turns automatic URL detection on and off.  
  
## Syntax  
  
```  
  
      HRESULT SetAutoURLDetectMode(  
   bool bNewValue   
) const;  
```  
  
#### Parameters  
 `bNewValue`  
 If true, automatic URL detection is enabled.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 This method sends the [IDM_AUTOURLDETECT_MODE command ID](https://msdn.microsoft.com/en-us/library/aa769893.aspx) to the WebBrowser control.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlEditCtrlBase Class](../vs140/chtmleditctrlbase-class.md)