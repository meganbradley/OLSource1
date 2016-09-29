---
title: "CRichEditCtrl::GetLineCount"
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
  - "CRichEditCtrl::GetLineCount"
  - "CRichEditCtrl.GetLineCount"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetLineCount method"
ms.assetid: 8bdb0797-885e-4796-8adf-fb0a57b73d39
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditCtrl::GetLineCount
Retrieves the number of lines in the `CRichEditCtrl` object.  
  
## Syntax  
  
```  
  
int GetLineCount( ) const;  
  
```  
  
## Return Value  
 The number of lines in this `CRichEditCtrl` object.  
  
## Remarks  
 For more information, see [EM_GETLINECOUNT](http://msdn.microsoft.com/library/windows/desktop/bb761586) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CRichEditCtrl#13](../vs140/codesnippet/CPP/cricheditctrl--getlinecount_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CRichEditCtrl Class](../vs140/cricheditctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditCtrl::GetLine](../vs140/cricheditctrl--getline.md)