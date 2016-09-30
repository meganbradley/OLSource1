---
title: "Implements Structure"
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
  - "implements/Microsoft::WRL::Implements"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Implements structure"
ms.assetid: 29b13e90-34d4-4a0b-babd-5187c9eb0c36
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Implements Structure
Implements QueryInterface and GetIid for the specified interfaces.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The zeroth interface ID. (Mandatory)  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The first interface ID. (Optional)  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The second interface ID. (Optional)  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The third interface ID. (Optional)  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The fourth interface ID. (Optional)  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The fifth interface ID. (Optional)  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The sixth interface ID. (Optional)  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The seventh interface ID. (Optional)  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The eigth interface ID. (Optional)  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 The ninth interface ID. (Optional)  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 Configuration flags for the class. One or more [RuntimeClassType](../vs140/runtimeclasstype-enumeration.md) enumerations that are specified in a [RuntimeClassFlags](../vs140/runtimeclassflags-structure.md) structure.  
  
## Remarks  
 Derives from the list of specified interfaces and implements helper templates for QueryInterface and GetIid.  
  
 Each <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> through <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> interface parameter must derive from either IUnknown, IInspectable, or the [ChainInterfaces](../vs140/chaininterfaces-structure.md) template. The <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> parameter determines whether support is generated for IUnknown or IInspectable.  
  
## Members  
  
### Public Typedefs  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|A synonym for <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.|  
  
### Protected Methods  
  
|Name|Description|  
|----------|-----------------|  
|[Implements::CanCastTo Method](../vs140/implements--cancastto-method.md)|Gets a pointer to the specified interface.|  
|[Implements::CastToUnknown Method](../vs140/implements--casttounknown-method.md)|Gets a pointer to the underlying IUnknown interface.|  
|[Implements::FillArrayWithIid Method](../vs140/implements--fillarraywithiid-method.md)|Inserts the interface ID specified by the current zeroth template parameter into the specified array element.|  
  
### Protected Constants  
  
|Name|Description|  
|----------|-----------------|  
|[Implements::IidCount Constant](../vs140/implements--iidcount-constant.md)|Holds the number of implemented interface IDs.|  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** implements.h  
  
 **Namespace:** Microsoft::WRL  
  
## See Also  
 [WRL Namespace](../vs140/microsoft--wrl-namespace.md)