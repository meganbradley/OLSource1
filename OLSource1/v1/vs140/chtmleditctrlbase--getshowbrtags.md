---
title: "CHtmlEditCtrlBase::GetShowBRTags"
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
  - "CHtmlEditCtrlBase::GetShowBRTags"
  - "CHtmlEditCtrlBase.GetShowBRTags"
  - "CHtmlEditCtrlBase<T>.GetShowBRTags"
  - "GetShowBRTags"
  - "CHtmlEditCtrlBase<T>::GetShowBRTags"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetShowBRTags method"
ms.assetid: 70d0ce7d-a7eb-4cb1-993d-3f26042ffab5
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlEditCtrlBase::GetShowBRTags
Retrieves whether the WebBrowser displays a glyph for br tags.  
  
## Syntax  
  
```  
  
      HRESULT GetShowBRTags(  
   bool& bCurValue   
) const;  
```  
  
#### Parameters  
 `bCurValue`  
 True if the WebBrowser displays a glyph for br tags, false if it doesn't.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 For more information, see [IDM_SHOWWBRTAGS Command ID](https://msdn.microsoft.com/en-us/library/aa769956.aspx).  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlEditCtrlBase Class](../vs140/chtmleditctrlbase-class.md)   
 [CHtmlEditCtrlBase::SetShowBRTags](../vs140/chtmleditctrlbase--setshowbrtags.md)