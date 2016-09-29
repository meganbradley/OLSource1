---
title: "EventTargetArray::EventTargetArray Constructor"
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
  - "event/Microsoft::WRL::Details::EventTargetArray::EventTargetArray"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EventTargetArray, constructor"
ms.assetid: 6c6d3737-3cd3-4515-a8f6-d27901bb8ed2
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# EventTargetArray::EventTargetArray Constructor
Supports the WRL infrastructure and is not intended to be used directly from your code.  
  
## Syntax  
  
```  
EventTargetArray(  
   _Out_ HRESULT* hr,  
   size_t items  
);  
```  
  
#### Parameters  
 `hr`  
 After this constructor operations, parameter `hr` indicates whether allocation of the array succeeded or failed. The following table lists the possible values for `hr`.  
  
 S_OK  
 The operation succeeded.  
  
 E_OUTOFMEMORY  
 Memory couldn't be allocated for the array.  
  
 S_FALSE  
 Parameter `items` is less than or equal to zero.  
  
 `items`  
 The number of array elements to allocate.  
  
## Remarks  
 Initializes a new instance of the EventTargetArray class.  
  
 EventTargetArray is used to keep an array of event handlers in an EventSource object.  
  
## Requirements  
 **Header:** event.h  
  
 **Namespace:** Microsoft::WRL::Details  
  
## See Also  
 [EventTargetArray Class](../VS_csharp/eventtargetarray-class.md)   
 [Microsoft::WRL::Details Namespace](../VS_csharp/microsoft--wrl--details-namespace.md)