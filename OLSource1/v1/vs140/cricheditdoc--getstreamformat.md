---
title: "CRichEditDoc::GetStreamFormat"
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
  - CRichEditDoc::GetStreamFormat
  - GetStreamFormat
  - SF_TEXT
  - CRichEditDoc.GetStreamFormat
  - SF_RTF
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetStreamFormat method
  - SF_TEXT
  - SF_RTF
ms.assetid: 0c3c3c3e-f41c-416d-9041-ee6cc1873566
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CRichEditDoc::GetStreamFormat
Call this function to determine the text format for streaming the contents of the rich edit.  
  
## Syntax  
  
```  
  
int GetStreamFormat( ) const;  
  
```  
  
## Return Value  
 One of the following flags:  
  
-   `SF_TEXT` Indicates that the rich edit control does not maintain formatting information.  
  
-   `SF_RTF` Indicates that the rich edit control does maintain formatting information.  
  
## Remarks  
 The return value is based on the [m_bRTF](../vs140/cricheditdoc--m_brtf.md) data member. This function returns `SF_RTF` if `m_bRTF` is **TRUE**; otherwise, `SF_TEXT`.  
  
## Requirements  
 **Header:** afxrich.h  
  
## See Also  
 [CRichEditDoc Class](../vs140/cricheditdoc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditDoc::m_bRTF](../vs140/cricheditdoc--m_brtf.md)   
 [CRichEditCtrl::StreamIn](../vs140/cricheditctrl--streamin.md)   
 [CRichEditCtrl::StreamOut](../vs140/cricheditctrl--streamout.md)