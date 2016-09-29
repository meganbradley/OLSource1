---
title: "EVENT_DELEGATE_ENTRY"
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
  - "EVENT_DELEGATE_ENTRY"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EVENT_DELEGATE_ENTRY macro"
ms.assetid: 17539da5-bad7-43ff-8a54-6ea3dc564965
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# EVENT_DELEGATE_ENTRY
Creates an entry in the delegate map.  
  
## Syntax  
  
```  
EVENT_DELEGATE_ENTRY(  
   MEMBER,  
   ARG0,  
   ARG1  
);  
```  
  
#### Parameters  
 `MEMBER`  
 The event handler method to be attached to the control.  
  
 `ARG0`  
 The first argument of the managed event handler method, such as **Object^**.  
  
 `ARG1`  
 The second argument of the managed event handler method, such as **EventArgs^**.  
  
## Remarks  
 Each entry in the delegate map corresponds to a managed event handler delegate created by [MAKE_DELEGATE](../VS_csharp/make_delegate.md).  
  
## Example  
 The following code example shows how to use `EVENT_DELEGATE_ENTRY` to create an entry in the delegate map for the `OnClick` event handler; also see the code example in `MAKE_DELEGATE`. For more information, see [How To: Sink Windows Forms Events from Native C++ Classes](../VS_csharp/how-to--sink-windows-forms-events-from-native-c---classes.md).  
  
 [!code[NVC_MFC_Managed#5](../VS_csharp/codesnippet/CPP/event_delegate_entry_1.h)]  
  
## Requirements  
 **Header:** msclr\event.h  
  
## See Also  
 [MAKE_DELEGATE](../VS_csharp/make_delegate.md)   
 [BEGIN_DELEGATE_MAP](../VS_csharp/begin_delegate_map.md)   
 [END_DELEGATE_MAP](../VS_csharp/end_delegate_map.md)