---
title: "CDC::GetFontLanguageInfo"
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
  - "CDC.GetFontLanguageInfo"
  - "CDC::GetFontLanguageInfo"
  - "GetFontLanguageInfo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetFontLanguageInfo method"
ms.assetid: d55d7e89-7616-4eaf-9a76-1ee7ba4f440d
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::GetFontLanguageInfo
Returns information about the currently selected font for the specified display context.  
  
## Syntax  
  
```  
  
DWORD GetFontLanguageInfo( ) const;  
  
```  
  
## Return Value  
 The return value identifies characteristics of the currently selected font. For a complete listing of possible values, see [GetFontLanguageInfo](http://msdn.microsoft.com/library/windows/desktop/dd144886).  
  
## Remarks  
 This member function emulates the functionality of the function [GetFontLanguageInfo](http://msdn.microsoft.com/library/windows/desktop/dd144886), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)