---
title: "CHtmlEditCtrlBase::GetShowAllTags"
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
  - GetShowAllTags
  - CHtmlEditCtrlBase.GetShowAllTags
  - CHtmlEditCtrlBase::GetShowAllTags
  - CHtmlEditCtrlBase<T>::GetShowAllTags
  - CHtmlEditCtrlBase<T>.GetShowAllTags
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetShowAllTags method
ms.assetid: 9356b165-59d9-4cfb-bee1-0de945108158
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CHtmlEditCtrlBase::GetShowAllTags
Returns whether the WebBrowser displays glyphs to show the location of all tags in a document.  
  
## Syntax  
  
```  
  
      HRESULT GetShowAllTags(  
   bool& bCurValue   
) const;  
```  
  
#### Parameters  
 `bCurValue`  
 True if the WebBrowser displays glyphs to show the location of all tags in a document; false if it does not.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 For more information, see [IDM_SHOWALLTAGS Command ID](https://msdn.microsoft.com/en-us/library/aa769948.aspx).  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlEditCtrlBase Class](../vs140/chtmleditctrlbase-class.md)   
 [CHtmlEditCtrlBase::SetShowAllTags](../vs140/chtmleditctrlbase--setshowalltags.md)