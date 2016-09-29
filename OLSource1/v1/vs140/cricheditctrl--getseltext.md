---
title: "CRichEditCtrl::GetSelText"
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
  - "GetSelText"
  - "CRichEditCtrl.GetSelText"
  - "CRichEditCtrl::GetSelText"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetSelText method"
ms.assetid: e9468b9f-b80c-4ffd-a1cf-c54f31b100c1
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditCtrl::GetSelText
Retrieves the text from the current selection in this `CRichEditCtrl` object.  
  
## Syntax  
  
```  
  
      long GetSelText(  
   LPSTR lpBuf   
) const;  
CString GetSelText( ) const;  
```  
  
#### Parameters  
 `lpBuf`  
 Pointer to the buffer to receive the text in the current selection.  
  
## Return Value  
 Depends on the form:  
  
-   **GetSelText(**  `lpBuf`  **)** The number of characters copied into `lpBuf`, not including the null termination.  
  
-   **GetSelText( )** The string containing the current selection.  
  
## Remarks  
 If you use the first form, **GetSelText(** `lpBuf` **)**, you must ensure that the buffer is large enough for the text it will receive. Call [GetSel](../vs140/cricheditctrl--getsel.md) to determine the number of characters in the current selection.  
  
 For more information, see [EM_GETSELTEXT](http://msdn.microsoft.com/library/windows/desktop/bb774190) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 See the example for [CRichEditCtrl::GetSelectionType](../vs140/cricheditctrl--getselectiontype.md).  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CRichEditCtrl Class](../vs140/cricheditctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditCtrl::GetSel](../vs140/cricheditctrl--getsel.md)   
 [CRichEditCtrl::GetSelectionType](../vs140/cricheditctrl--getselectiontype.md)