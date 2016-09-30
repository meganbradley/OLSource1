---
title: "WM_FORWARDMSG"
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
  - "WM_FORWARDMSG"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "WM_FORWARDMSG macro"
ms.assetid: 50ffb097-f451-426b-bece-135ee1ad39c8
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# WM_FORWARDMSG
This macro forwards a message received by a window to another window for processing.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Nonzero if the message was processed, zero if not.  
  
## Remarks  
 Use <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> to forward a message received by a window to another window for processing. The LPARAM and WPARAM parameters are used as follows:  
  
|Parameter|Usage|  
|---------------|-----------|  
|WPARAM|Data defined by user|  
|LPARAM|A pointer to a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> structure that contains information about a message|  
  
## Example  
 In the following example, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> represents the other window that receives this message.  
  
 [!code[NVC_ATL_Windowing#137](../vs140/codesnippet/CPP/wm_forwardmsg_1.cpp)]  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [Windows Messages Macros](../vs140/windows-messages-macros.md)   
 [Macros](../vs140/atl-macros.md)