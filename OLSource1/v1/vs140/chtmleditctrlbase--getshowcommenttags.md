---
title: "CHtmlEditCtrlBase::GetShowCommentTags"
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
  - "CHtmlEditCtrlBase<T>::GetShowCommentTags"
  - "CHtmlEditCtrlBase<T>.GetShowCommentTags"
  - "CHtmlEditCtrlBase.GetShowCommentTags"
  - "GetShowCommentTags"
  - "CHtmlEditCtrlBase::GetShowCommentTags"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetShowCommentTags method"
ms.assetid: 398d68d3-3f94-43fa-b8ec-8af2baae6c02
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlEditCtrlBase::GetShowCommentTags
Retrieves whether the WebBrowser displays a glyph for comment tags.  
  
## Syntax  
  
```  
  
      HRESULT GetShowCommentTags(  
   bool& bCurValue   
) const;  
```  
  
#### Parameters  
 `bCurValue`  
 True if the WebBrowser displays a glyph for comment tags, false if it doesn't.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 For more information, see [IDM_SHOWCOMMENTTAGS Command ID](https://msdn.microsoft.com/en-us/library/aa769950.aspx).  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlEditCtrlBase Class](../vs140/chtmleditctrlbase-class.md)   
 [CHtmlEditCtrlBase::SetShowCommentTags](../vs140/chtmleditctrlbase--setshowcommenttags.md)