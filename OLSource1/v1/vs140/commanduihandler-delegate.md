---
title: "CommandUIHandler Delegate"
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
  - "CommandUIHandler"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CommandUIHandler delegate"
ms.assetid: 2da11ecc-20d6-4a53-97fc-08b48f06d71a
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CommandUIHandler Delegate
Registers callback methods with a user interface update command message.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The command ID.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The command message ID.  
  
## Remarks  
 This delegate registers callback methods with a user interface update command message. <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is similar to [CommandHandler](../vs140/commandhandler-delegate.md) except that this delegate is used with user interface object update commands. User interface update commands should be mapped one-to-one with message handler methods.  
  
 For more information on using Windows Forms, see [Using Windows Forms in MFC](../vs140/using-a-windows-form-user-control-in-mfc.md).  
  
## Requirements  
 **Header:** afxwinforms.h (defined in assembly atlmfc\lib\mfcmifc80.dll)  
  
## See Also  
 [How To: Add Command Routing to the Windows Forms Control](../vs140/how-to--add-command-routing-to-the-windows-forms-control.md)   
 [CommandHandler Delegate](../vs140/commandhandler-delegate.md)