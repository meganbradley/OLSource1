---
title: "CRichEditCtrl::GetLine"
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
  - "CRichEditCtrl.GetLine"
  - "CRichEditCtrl::GetLine"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetLine method"
ms.assetid: b033c987-e263-43f4-8bd7-cbac60d90796
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditCtrl::GetLine
Retrieves a line of text from this <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Zero-based index of the line to retrieve.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Points to the buffer to receive the text. The first word of the buffer must specify the maximum number of bytes that can be copied into the buffer.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Maximum number of characters that can be copied into <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. The second form of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> places this value into the first word of the buffer specified by <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Return Value  
 The number of characters copied into <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Remarks  
 The copied line does not contain a terminating null character.  
  
> [!NOTE]
>  Because the first word of the buffer stores the number of characters to be copied, make sure that your buffer is at least 4 bytes long.  
  
 For more information, see [EM_GETLINE](http://msdn.microsoft.com/library/windows/desktop/bb761584) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 See the example for [GetLineCount](../vs140/cricheditctrl--getlinecount.md).  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CRichEditCtrl Class](../vs140/cricheditctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditCtrl::LineLength](../vs140/cricheditctrl--linelength.md)