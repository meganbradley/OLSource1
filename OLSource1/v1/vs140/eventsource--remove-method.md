---
title: "EventSource::Remove Method"
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
  - "event/Microsoft::WRL::EventSource::Remove"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Remove method"
ms.assetid: afafedf5-3665-4408-a639-fb6884f7c5f9
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# EventSource::Remove Method
Deletes the event handler represented by the specified event registration token from the set of event handlers associated with the current EventSource object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A handle that represents an event handler. This token was returned when the event handler was registered by the [Add()](../vs140/eventsource--add-method.md) method.  
  
## Return Value  
 S_OK if successful; otherwise, an HRESULT that indicates the error.  
  
## Remarks  
 For more information about the EventRegistrationToken structure, see the Windows::Foundation::EventRegistrationToken Structure topic in the Windows Runtime reference documentation.  
  
## Requirements  
 **Header:** event.h  
  
 **Namespace:** Microsoft::WRL  
  
## See Also  
 [EventSource Class](../vs140/eventsource-class.md)