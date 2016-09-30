---
title: "ArgTraits Structure"
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
  - "event/Microsoft::WRL::Details::ArgTraits"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ArgTraits structure"
ms.assetid: 58ae4115-c1bc-48c8-b01b-e60554841c30
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ArgTraits Structure
Supports the WRL infrastructure and is not intended to be used directly from your code.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Typename parameter for an ArgTraits structure that cannot match any Invoke method signature.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A delegate interface.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The type of the first argument of the Invoke method.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The type of the second argument of the Invoke method.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The type of the third argument of the Invoke method.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The type of the fourth argument of the Invoke method.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The type of the fifth argument of the Invoke method.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The type of the sixth argument of the Invoke method.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The type of the seventh argument of the Invoke method.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 The type of the eigth argument of the Invoke method.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 The type of the ninth argument of the Invoke method.  
  
## Remarks  
 The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> structure declares a specified delegate interface and an anonymous member function that has a specified number of parameters.  
  
## Members  
  
### Public Typedefs  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|The typedef for TArg1.|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|The typedef for TArg2.|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|The typedef for TArg3.|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|The typedef for TArg4.|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|The typedef for TArg5.|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|The typedef for TArg6.|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|The typedef for TArg7.|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|The typedef for TArg8.|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|The typedef for TArg9.|  
  
### Public Constants  
  
|Name|Description|  
|----------|-----------------|  
|[ArgTraits::args Constant](../vs140/argtraits--args-constant.md)|Keeps count of the number of parameters on the Invoke method of a delegate interface.|  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** event.h  
  
 **Namespace:** Microsoft::WRL::Details  
  
## See Also  
 [Microsoft::WRL::Details Namespace](../vs140/microsoft--wrl--details-namespace.md)