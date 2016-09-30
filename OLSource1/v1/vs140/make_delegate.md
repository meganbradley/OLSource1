---
title: "MAKE_DELEGATE"
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
  - "MAKE_DELEGATE"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MAKE_DELEGATE macro"
ms.assetid: acc07fd2-4ea7-4c56-8d2c-73175524caeb
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MAKE_DELEGATE
Attaches an event handler to a managed control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The type of the managed event handler delegate, such as \<xref:System.EventHandler*>.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The name of the event handler method to be attached to the control.  
  
## Remarks  
 This macro creates a managed event handler delegate of type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and of the name <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. The managed event handler delegate allows a native class to handle managed events.  
  
## Example  
 The following code example shows how to call <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to attach an <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> event handler to an MFC control <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. For a broader explanation of how this macro works in an MFC application, see [How To: Sink Windows Forms Events from Native C++ Classes](../vs140/how-to--sink-windows-forms-events-from-native-c---classes.md).  
  
 [!code[NVC_MFC_Managed#6](../vs140/codesnippet/CPP/make_delegate_1.cpp)]  
  
## Requirements  
 **Header:** msclr\event.h  
  
## See Also  
 [BEGIN_DELEGATE_MAP](../vs140/begin_delegate_map.md)   
 [END_DELEGATE_MAP](../vs140/end_delegate_map.md)   
 [EVENT_DELEGATE_ENTRY](../vs140/event_delegate_entry.md)