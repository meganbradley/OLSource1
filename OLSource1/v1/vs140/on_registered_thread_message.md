---
title: "ON_REGISTERED_THREAD_MESSAGE"
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
  - "ON_REGISTERED_THREAD_MESSAGE"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ON_REGISTERED_THREAD_MESSAGE macro"
ms.assetid: 3f598bc2-b2f0-410f-8ba0-7714502170f3
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ON_REGISTERED_THREAD_MESSAGE
Indicates which function will handle the message registered by the Windows **RegisterWindowMessage** function.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The registered window-message ID variable.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The name of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>-message-handler function to which the message is mapped.  
  
## Remarks  
 **RegisterWindowMessage** is used to define a new window message that is guaranteed to be unique throughout the system. <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> must be used instead of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> when you have a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> class.  
  
## Requirements  
 **Header:** afxmsg_.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [ON_REGISTERED_MESSAGE](../vs140/on_registered_message.md)   
 [ON_THREAD_MESSAGE](../vs140/on_thread_message.md)   
 [RegisterWindowMessage](http://msdn.microsoft.com/library/windows/desktop/ms644947)   
 [CWinThread Class](../vs140/cwinthread-class.md)