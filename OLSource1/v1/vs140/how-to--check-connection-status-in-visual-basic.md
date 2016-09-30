---
title: "How to: Check Connection Status in Visual Basic"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "Web connections"
  - "IsAvailable property, about IsAvailable"
  - "connections, checking status"
  - "connection status"
ms.assetid: 4d9ee8ab-9a6f-4279-ace4-b75afc976a74
caps.latest.revision: 30
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Check Connection Status in Visual Basic
The \<xref:Microsoft.VisualBasic.Devices.Network.IsAvailable*> property can be used to determine whether the computer has a working network or Internet connection.  
  
 [!INCLUDE[note_settings_general](../vs140/includes/note_settings_general_md.md)]  
  
### To check whether a computer has a working connection  
  
-   Determine whether the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> property is <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. The following code checks the property's status and reports it:  
  
     [!code[VbResourceTasks#3](../vs140/codesnippet/VisualBasic/how-to--check-connection-status-in-visual-basic_1.vb)]  
  
     This code example is also available as an IntelliSense code snippet. In the code snippet picker, it is located in **Connectivity and Networking**. For more information, see [Code Snippets](../vs140/code-snippets.md).  
  
## See Also  
 \<xref:Microsoft.VisualBasic.Devices.Network*?displayProperty=fullName>   
 \<xref:Microsoft.VisualBasic.Devices.Network.IsAvailable*>