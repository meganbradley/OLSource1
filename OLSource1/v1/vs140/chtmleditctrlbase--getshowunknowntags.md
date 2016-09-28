---
title: "CHtmlEditCtrlBase::GetShowUnknownTags"
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
  - "GetShowUnknownTags"
  - "CHtmlEditCtrlBase::GetShowUnknownTags"
  - "CHtmlEditCtrlBase<T>::GetShowUnknownTags"
  - "CHtmlEditCtrlBase<T>.GetShowUnknownTags"
  - "CHtmlEditCtrlBase.GetShowUnknownTags"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetShowUnknownTags method"
ms.assetid: bba99a38-9fab-427f-b9ea-10bf728ff7d3
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlEditCtrlBase::GetShowUnknownTags
Retrieves whether the WebBrowser displays a glyph for all unknown tags.  
  
## Syntax  
  
```  
  
      HRESULT GetShowUnknownTags(  
   bool& bCurValue   
) const;  
```  
  
#### Parameters  
 `bCurValue`  
 True if the WebBrowser displays a glyph for all unknown tags, false if it does not.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 For more information, see [IDM_SHOWUNKNOWNTAGS Command ID](https://msdn.microsoft.com/en-us/library/aa769955.aspx).  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlEditCtrlBase Class](../vs140/chtmleditctrlbase-class.md)   
 [CHtmlEditCtrlBase::SetShowUnknownTags](../vs140/chtmleditctrlbase--setshowunknowntags.md)