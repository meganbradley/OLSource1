---
title: "RuntimeClass Class"
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
  - "implements/Microsoft::WRL::RuntimeClass"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RuntimeClass class"
ms.assetid: d52f9d1a-98e5-41f2-a143-8fb629dd0727
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# RuntimeClass Class
Represents an instantiated class that inherits the specified number of interfaces, and provides the specified [!INCLUDE[wrt](../vs140/includes/wrt_md.md)], classic COM, and weak reference support.  
  
 You typically derive your WRL types from <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> because this class implements <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, and helps manage the overall reference count of the module.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The zeroth interface ID. (Mandatory)  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The first interface ID. (Optional)  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The second interface ID. (Optional)  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The third interface ID. (Optional)  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The fourth interface ID. (Optional)  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 The fifth interface ID. (Optional)  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 The sixth interface ID. (Optional)  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 The seventh interface ID. (Optional)  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 The eigth interface ID. (Optional)  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 The ninth interface ID. (Optional)  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 A combination of one or more [RuntimeClassType](../vs140/runtimeclasstype-enumeration.md) enumeration values.  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[RuntimeClass::RuntimeClass Constructor](../vs140/runtimeclass--runtimeclass-constructor.md)|Initializes the current instance of the RuntimeClass class.|  
|[RuntimeClass::~RuntimeClass Destructor](../vs140/runtimeclass--~runtimeclass-destructor.md)|Deinitializes the current instance of the RuntimeClass class.|  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** implements.h  
  
 **Namespace:** Microsoft::WRL  
  
## See Also  
 [WRL Namespace](../vs140/microsoft--wrl-namespace.md)