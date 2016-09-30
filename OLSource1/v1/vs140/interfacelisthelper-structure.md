---
title: "InterfaceListHelper Structure"
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
  - "implements/Microsoft::WRL::Details::InterfaceListHelper"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "InterfaceListHelper structure"
ms.assetid: 4297e419-c96b-45df-8a00-7568062125ba
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# InterfaceListHelper Structure
Supports the WRL infrastructure and is not intended to be used directly from your code.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Template parameter 0, which is required.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Template parameter 1, which by default is unspecified.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Template parameter 2, which by default is unspecified.The third template parameter.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Template parameter 3, which by default is unspecified.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Template parameter 4, which by default is unspecified.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Template parameter 5, which by default is unspecified.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Template parameter 6, which by default is unspecified.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Template parameter 7, which by default is unspecified.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Template parameter 8, which by default is unspecified.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Template parameter 9, which by default is unspecified.  
  
## Remarks  
 Builds an InterfaceList type by recursively applying the specified template parameter arguments.  
  
 The InterfaceListHelper template uses template parameter <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> to define the first data member in an InterfaceList structure, and then recursively applies the InterfaceListHelper template to any remaining template parameters. InterfaceListHelper stops when there are no remaining template parameters.  
  
## Members  
  
### Public Typedefs  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|A synonym for the InterfaceList type.|  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** implements.h  
  
 **Namespace:** Microsoft::WRL::Details  
  
## See Also  
 [Microsoft::WRL::Details Namespace](../vs140/microsoft--wrl--details-namespace.md)