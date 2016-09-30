---
title: "CHtmlEditCtrlBase::GetShowScriptTags"
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
  - "CHtmlEditCtrlBase<T>::GetShowScriptTags"
  - "CHtmlEditCtrlBase::GetShowScriptTags"
  - "GetShowScriptTags"
  - "CHtmlEditCtrlBase<T>.GetShowScriptTags"
  - "CHtmlEditCtrlBase.GetShowScriptTags"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetShowScriptTags method"
ms.assetid: 82ca5c91-ef5a-4d7c-837d-14111f09bf53
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlEditCtrlBase::GetShowScriptTags
Retrieves whether the WebBrowser displays a glyph for all the script tags.  
  
## Syntax  
  
```  
  
      HRESULT GetShowScriptTags(  
   bool& bCurValue   
) const;  
```  
  
#### Parameters  
 `bCurValue`  
 True if the WebBrowser displays a glyph for all the script tags, false if it does not.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 For more information, see [IDM_SHOWSCRIPTTAGS Command ID](https://msdn.microsoft.com/en-us/library/aa769953.aspx).  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlEditCtrlBase Class](../vs140/chtmleditctrlbase-class.md)   
 [CHtmlEditCtrlBase::SetShowScriptTags](../vs140/chtmleditctrlbase--setshowscripttags.md)