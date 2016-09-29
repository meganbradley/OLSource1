---
title: "CHtmlEditCtrlBase::GetShowMiscTags"
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
  - "CHtmlEditCtrlBase<T>::GetShowMiscTags"
  - "GetShowMiscTags"
  - "CHtmlEditCtrlBase<T>.GetShowMiscTags"
  - "CHtmlEditCtrlBase::GetShowMiscTags"
  - "CHtmlEditCtrlBase.GetShowMiscTags"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetShowMiscTags method"
ms.assetid: e898d3d3-82cb-4263-b31b-47968133d610
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlEditCtrlBase::GetShowMiscTags
Retrieves whether the WebBrowser displays all the tags shown in Microsoft Internet Explorer 4.0.  
  
## Syntax  
  
```  
  
      HRESULT GetShowMiscTags(  
   bool& bCurValue   
) const;  
```  
  
#### Parameters  
 `bCurValue`  
 True if the WebBrowser displays all the tags shown in Microsoft Internet Explorer 4.0, false if it does not.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 For more information, see [IDM_SHOWMISCTAGS Command ID](https://msdn.microsoft.com/en-us/library/aa769952.aspx).  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlEditCtrlBase Class](../vs140/chtmleditctrlbase-class.md)   
 [CHtmlEditCtrlBase::SetShowMiscTags](../vs140/chtmleditctrlbase--setshowmisctags.md)