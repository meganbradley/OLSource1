---
title: "CommandHandler Delegate"
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
  - "CommandHandler"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CommandHandler delegate"
ms.assetid: 22096734-e074-4aca-8523-4b15590109f9
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CommandHandler Delegate
Registers callback methods with a command source.  
  
## Syntax  
  
```  
delegate void CommandHandler(  
   UINT^ cmdID  
);  
```  
  
#### Parameters  
 `cmdID`  
 The command ID.  
  
## Remarks  
 This delegate registers callback methods with a command source. When you add a delegate to the command source object, the callback method becomes a handler for commands coming from the specified source.  
  
 For more information, see [How To: Add Command Routing to the Windows Forms Control](../vs140/how-to--add-command-routing-to-the-windows-forms-control.md).  
  
 For more information on using Windows Forms, see [Using Windows Forms in MFC](../vs140/using-a-windows-form-user-control-in-mfc.md).  
  
## Requirements  
 **Header:** afxwinforms.h (defined in assembly atlmfc\lib\mfcmifc80.dll)  
  
## See Also  
 [How To: Add Command Routing to the Windows Forms Control](../vs140/how-to--add-command-routing-to-the-windows-forms-control.md)