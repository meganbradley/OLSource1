---
title: "__RTDynamicCast"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
apiname: 
  - "__RTDynamicCast"
apilocation: 
  - "msvcr90.dll"
  - "msvcr110.dll"
  - "msvcr120.dll"
  - "msvcrt.dll"
  - "msvcr100.dll"
  - "msvcr80.dll"
  - "msvcr110_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "__RTDynamicCast"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "__RTDynamicCast"
ms.assetid: 56aa2d7a-aa47-46ef-830d-e37175611239
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# __RTDynamicCast
Runtime implementation of the [dynamic_cast](../vs140/dynamic_cast-operator.md) operator.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to a polymorphic object.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Offset of virtual function pointer in object.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Static type of object pointed to by the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> parameter.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Intended result of cast.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> if input is a reference; <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> if input is a pointer.  
  
## Return Value  
 Pointer to the appropriate sub-object, if successful; otherwise, NULL.  
  
## Exceptions  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> if the input to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is a reference and the cast fails.  
  
## Remarks  
 Converts <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> to an object of type <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. The type of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> must be a pointer if <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is a pointer, or an l-value if <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is a reference. <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> must be a pointer or a reference to a previously defined class type, or a pointer to void.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|__RTDynamicCast|rtti.h|