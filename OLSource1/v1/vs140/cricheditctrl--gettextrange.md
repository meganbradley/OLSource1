---
title: "CRichEditCtrl::GetTextRange"
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
  - "CRichEditCtrl.GetTextRange"
  - "GetTextRange"
  - "CRichEditCtrl::GetTextRange"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetTextRange method"
ms.assetid: eca22cbe-da17-49ab-b7bb-45dbca44bef5
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditCtrl::GetTextRange
Gets the specified range of characters.  
  
## Syntax  
  
```  
  
      int GetTextRange(  
   int nFirst,  
   int nLast,  
   CString& refString   
) const;  
```  
  
#### Parameters  
 `nFirst`  
 The character position index immediately preceding the first character in the range.  
  
 `nLast`  
 The character position immediately following the last character in the range.  
  
 `refString`  
 A reference to a [CString](../vs140/cstringt-class.md) object that will receive the text.  
  
## Return Value  
 The number of characters copied, not including the terminating null character.  
  
## Remarks  
 For more information, see [EM_GETTEXTRANGE](http://msdn.microsoft.com/library/windows/desktop/bb774199) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 `GetTextRange` supports the Rich Edit 2.0 functionality. See [About Rich Edit Controls](http://msdn.microsoft.com/library/windows/desktop/bb787873) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]for more information.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CRichEditCtrl Class](../vs140/cricheditctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditCtrl::GetTextLength](../vs140/cricheditctrl--gettextlength.md)   
 [CRichEditCtrl::GetTextLengthEx](../vs140/cricheditctrl--gettextlengthex.md)