---
title: "CRichEditCtrl::StreamIn"
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
  - "SFF_SELECTION"
  - "CRichEditCtrl::StreamIn"
  - "StreamIn"
  - "CRichEditCtrl.StreamIn"
  - "SF_TEXT"
  - "SF_RTF"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "StreamIn method"
  - "SFF_SELECTION"
  - "SF_TEXT"
  - "SF_RTF"
ms.assetid: baf64564-584d-43f4-9796-347880257244
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditCtrl::StreamIn
Replaces text in this <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object with text from the specified input stream.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Flags specifying the input data formats. See the Remarks section for more information.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [EDITSTREAM](http://msdn.microsoft.com/library/windows/desktop/bb787891) structure specifying the input stream. See the Remarks section for more information.  
  
## Return Value  
 Number of characters read from the input stream.  
  
## Remarks  
 The value of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> must be one of the following:  
  
-   <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> Indicates reading text only.  
  
-   <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> Indicates reading text and formatting.  
  
 Either of these values can be combined with <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is specified, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> replaces the current selection with the contents of the input stream. If it is not specified, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> replaces the entire contents of this <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object.  
  
 In the **EDITSTREAM** parameter <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, you specify a callback function that fills a buffer with text. This callback function is called repeatedly, until the input stream is exhausted.  
  
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