---
title: "InvokeHelper Structure"
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
  - "event/Microsoft::WRL::Details::InvokeHelper"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "InvokeHelper structure"
ms.assetid: 555ad2bc-4dd6-4e65-a2e2-1242c395f0e5
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# InvokeHelper Structure
Supports the WRL infrastructure and is not intended to be used directly from your code.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The type of the event handler function.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The number of arguments in an InvokeHelper specialization.  
  
## Remarks  
 Provides an implementation of the Invoke() method based on the specified number and type of arguments.  
  
## Members  
  
### Public Typedefs  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|A synonym for the class that defines the type of each event handler argument.|  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[InvokeHelper::InvokeHelper Constructor](../vs140/invokehelper--invokehelper-constructor.md)|Initializes a new instance of the InvokeHelper class.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[InvokeHelper::Invoke Method](../vs140/invokehelper--invoke-method.md)|Calls the event handler whose signature contains the specified number of arguments.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[InvokeHelper::callback_ Data Member](../vs140/invokehelper--callback_-data-member.md)|Represents the event handler to call when an event occurs.|  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** event.h  
  
 **Namespace:** Microsoft::WRL::Details  
  
## See Also  
 [Microsoft::WRL::Details Namespace](../vs140/microsoft--wrl--details-namespace.md)