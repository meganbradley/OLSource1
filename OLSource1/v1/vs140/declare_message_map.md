---
title: "DECLARE_MESSAGE_MAP"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "DECLARE_MESSAGE_MAP"
  - "AFXWIN/DECLARE_MESSAGE_MAP"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "message map macros"
  - "DECLARE_MESSAGE_MAP macro"
ms.assetid: c225e7e0-a81b-495c-97f9-3e0aa1f65036
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DECLARE_MESSAGE_MAP
Declares that the class defines a message map. Each <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>-derived class in your program must provide a message map to handle messages.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 Use the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> macro at the end of your class declaration. Then, in the .cpp file that defines the member functions for the class, use the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> macro, macro entries for each of your message-handler functions, and the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> macro.  
  
> [!NOTE]
>  If you declare any member after <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, you must specify a new access type (**public**, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>) for them.  
  
 For more information on message maps and the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> macro, see [Message Handling and Mapping Topics](../vs140/message-handling-and-mapping.md).  
  
## Example  
 [!code[NVC_MFCWindowing#136](../vs140/codesnippet/CPP/declare_message_map_1.h)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [BEGIN_MESSAGE_MAP](../vs140/begin_message_map.md)   
 [END_MESSAGE_MAP](../vs140/end_message_map.md)