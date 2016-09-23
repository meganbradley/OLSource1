---
title: "CRichEditCtrl::StreamIn"
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
  - SFF_SELECTION
  - CRichEditCtrl::StreamIn
  - StreamIn
  - CRichEditCtrl.StreamIn
  - SF_TEXT
  - SF_RTF
dev_langs: 
  - C++
helpviewer_keywords: 
  - StreamIn method
  - SFF_SELECTION
  - SF_TEXT
  - SF_RTF
ms.assetid: baf64564-584d-43f4-9796-347880257244
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CRichEditCtrl::StreamIn
Replaces text in this `CRichEditCtrl` object with text from the specified input stream.  
  
## Syntax  
  
```  
  
      long StreamIn(  
   int nFormat,  
   EDITSTREAM& es   
);  
```  
  
#### Parameters  
 `nFormat`  
 Flags specifying the input data formats. See the Remarks section for more information.  
  
 `es`  
 [EDITSTREAM](http://msdn.microsoft.com/library/windows/desktop/bb787891) structure specifying the input stream. See the Remarks section for more information.  
  
## Return Value  
 Number of characters read from the input stream.  
  
## Remarks  
 The value of `nFormat` must be one of the following:  
  
-   `SF_TEXT` Indicates reading text only.  
  
-   `SF_RTF` Indicates reading text and formatting.  
  
 Either of these values can be combined with `SFF_SELECTION`. If `SFF_SELECTION` is specified, `StreamIn` replaces the current selection with the contents of the input stream. If it is not specified, `StreamIn` replaces the entire contents of this `CRichEditCtrl` object.  
  
 In the **EDITSTREAM** parameter `es`, you specify a callback function that fills a buffer with text. This callback function is called repeatedly, until the input stream is exhausted.  
  
 For more information, see [EM_STREAMIN](http://msdn.microsoft.com/library/windows/desktop/bb774302) message and [EDITSTREAM](http://msdn.microsoft.com/library/windows/desktop/bb787891) structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CRichEditCtrl#34](../vs140/codesnippet/CPP/cricheditctrl--streamin_1.cpp)]
  
  
 [!code[NVC_MFC_CRichEditCtrl#35](../vs140/codesnippet/CPP/cricheditctrl--streamin_2.cpp)]
  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CRichEditCtrl Class](../vs140/cricheditctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditCtrl::StreamOut](../vs140/cricheditctrl--streamout.md)