---
title: "CHtmlEditCtrlBase::SetBlockFormat"
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
  - "CHtmlEditCtrlBase.SetBlockFormat"
  - "CHtmlEditCtrlBase<T>.SetBlockFormat"
  - "CHtmlEditCtrlBase::SetBlockFormat"
  - "SetBlockFormat"
  - "CHtmlEditCtrlBase<T>::SetBlockFormat"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetBlockFormat method"
ms.assetid: ea2b2c0b-5125-44cf-bc7f-e16c60564ad0
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlEditCtrlBase::SetBlockFormat
Sets the current block format tag.  
  
## Syntax  
  
```  
  
      HRESULT SetBlockFormat(  
   LPCTSTR szFormat   
) const;  
```  
  
#### Parameters  
 `szFormat`  
 The format tag.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 This method sends the [IDM_BLOCKFMT_command ID](https://msdn.microsoft.com/en-us/library/aa769883.aspx) to the WebBrowser control.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlEditCtrlBase Class](../vs140/chtmleditctrlbase-class.md)   
 [CHtmlEditCtrlBase::GetBlockFormat](../vs140/chtmleditctrlbase--getblockformat.md)