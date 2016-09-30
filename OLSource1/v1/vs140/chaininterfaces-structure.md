---
title: "ChainInterfaces Structure"
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
  - "implements/Microsoft::WRL::ChainInterfaces"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ChainInterfaces structure"
ms.assetid: d7415b59-5468-4bef-a3fd-8d82b12f0e9c
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ChainInterfaces Structure
Specifies verification and initialization functions that can be applied to a set of interface IDs.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 (Required) Interface ID 0.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 (Required) Interface ID 1.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 (Optional) Interface ID 2.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 (Optional) Interface ID 3.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 (Optional) Interface ID 4.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 (Optional) Interface ID 5.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 (Optional) Interface ID 6.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 (Optional) Interface ID 7.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 (Optional) Interface ID 8.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 (Optional) Interface ID 9.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 A derived type.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 The base type of a derived type.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 A Boolean value that if <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, means you can't use a [MixIn](../vs140/mixin-structure.md) structure with a class that does not derive from the [Implements](../vs140/implements-structure.md) stucture.  
  
## Members  
  
### Protected Methods  
  
|Name|Description|  
|----------|-----------------|  
|[ChainInterfaces::CanCastTo Method](../vs140/chaininterfaces--cancastto-method.md)|Indicates whether the specified interface ID can be cast to each of the specializations defined by the ChainInterface template parameters.|  
|[ChainInterfaces::CastToUnknown Method](../vs140/chaininterfaces--casttounknown-method.md)|Casts the interface pointer of the type defined by the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> template parameter to a pointer to IUnknown.|  
|[ChainInterfaces::FillArrayWithIid Method](../vs140/chaininterfaces--fillarraywithiid-method.md)|Stores the interface ID defined by the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> template parameter into a specified location in a specified array of interface IDs.|  
|[ChainInterfaces::Verify Method](../vs140/chaininterfaces--verify-method.md)|Verifies that each interface defined by template parameters <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> through <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> inherits from IUnknown and/or IInspectable, and that <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> inherits from <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> through <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.|  
  
### Protected Constants  
  
|Name|Description|  
|----------|-----------------|  
|[ChainInterfaces::IidCount Constant](../vs140/chaininterfaces--iidcount-constant.md)|The total number of interface IDs contained in the interfaces specified by template parameters <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> through <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.|  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** implements.h  
  
 **Namespace:** Microsoft::WRL  
  
## See Also  
 [WRL Namespace](../vs140/microsoft--wrl-namespace.md)