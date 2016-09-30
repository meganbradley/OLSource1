---
title: "Type-Safe Access to Controls Without Code Wizards"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "dialog boxes, accessing controls"
  - "dialog box controls, accessing"
ms.assetid: 325b4927-d49b-42b4-8e0b-fc84f31fb059
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Type-Safe Access to Controls Without Code Wizards
The first approach to creating type-safe access to controls uses an inline member function to cast the return type of class <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>'s <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> member function to the appropriate C++ control type, as in this example:  
  
 [!code[NVC_MFCControlLadenDialog#50](../vs140/codesnippet/CPP/type-safe-access-to-controls-without-code-wizards_1.cpp)]  
  
 You can then use this member function to access the control in a type-safe manner with code similar to the following:  
  
 [!code[NVC_MFCControlLadenDialog#51](../vs140/codesnippet/CPP/type-safe-access-to-controls-without-code-wizards_2.cpp)]  
  
## See Also  
 [Type-Safe Access to Controls in a Dialog Box](../vs140/type-safe-access-to-controls-in-a-dialog-box.md)   
 [Type-Safe Access to Controls With Code Wizards](../vs140/type-safe-access-to-controls-with-code-wizards.md)