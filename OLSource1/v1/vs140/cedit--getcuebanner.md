---
title: "CEdit::GetCueBanner"
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
  - "GetCueBanner"
  - "CEdit.GetCueBanner"
  - "CEdit::GetCueBanner"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CEdit class, general operations"
  - "GetCueBanner method"
ms.assetid: 56984658-049c-4a8f-baa6-e7114d9ce1b9
caps.latest.revision: 21
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CEdit::GetCueBanner
Retrieves the text that is displayed as the text cue, or tip, in an edit control when the control is empty.  
  
## Syntax  
  
```  
BOOL GetCueBanner(  
     LPWSTR lpszText,  
     int cchText  
) const;  
  
CString GetCueBanner() const;  
```  
  
#### Parameters  
 [out] `lpszText`  
 A pointer to a string that contains the cue text.  
  
 [in] `cchText`  
 The number of characters that can be received. This number includes the terminating `NULL` character.  
  
## Return Value  
 For the first overload, `true` if the method is successful; otherwise `false`.  
  
 For the second overload, a [CString](../vs140/using-cstring.md) that contains the cue text if the method is successful; otherwise, the empty string ("").  
  
## Remarks  
 This method sends the [EM_GETCUEBANNER](http://msdn.microsoft.com/library/windows/desktop/bb761572) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. For more information, see the [Edit_GetCueBannerText](http://msdn.microsoft.com/library/windows/desktop/bb761695) macro.  
  
## Requirements  
 **Header:** afxwin.h  
  
 This control is supported in Windows XP and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## See Also  
 [CEdit Class](../vs140/cedit-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CEdit::SetCueBanner](../vs140/cedit--setcuebanner.md)   
 [EM_GETCUEBANNER](http://msdn.microsoft.com/library/windows/desktop/bb761572)   
 [Edit_GetCueBannerText](http://msdn.microsoft.com/library/windows/desktop/bb761695)