---
title: "CHtmlEditCtrlBase::SetShowCommentTags"
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
  - "SetShowCommentTags"
  - "CHtmlEditCtrlBase.SetShowCommentTags"
  - "CHtmlEditCtrlBase<T>.SetShowCommentTags"
  - "CHtmlEditCtrlBase<T>::SetShowCommentTags"
  - "CHtmlEditCtrlBase::SetShowCommentTags"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetShowCommentTags method"
ms.assetid: 810fc9a6-5d82-4e68-9cce-745caa78cbff
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlEditCtrlBase::SetShowCommentTags
Displays a glyph for all the comment tags.  
  
## Syntax  
  
```  
  
      HRESULT SetShowCommentTags(  
   bool bNewValue   
) const;  
```  
  
#### Parameters  
 `bNewValue`  
 If true, displays a glyph for all the comment tags.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 This method sends the [IDM SHOWCOMMENTTAGS command ID](https://msdn.microsoft.com/en-us/library/aa769950.aspx) to the WebBrowser control.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlEditCtrlBase Class](../vs140/chtmleditctrlbase-class.md)   
 [CHtmlEditCtrlBase::GetShowCommentTags](../vs140/chtmleditctrlbase--getshowcommenttags.md)