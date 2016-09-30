---
title: "ComPtrRef::operator!= Operator"
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
  - "client/Microsoft::WRL::Details::ComPtrRef::operator!="
dev_langs: 
  - "C++"
ms.assetid: ab3093cc-6fbd-4039-890a-6df1cde992b6
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ComPtrRef::operator!= Operator
Supports the WRL infrastructure and is not intended to be used directly from your code.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A reference to a ComPtrRef object.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A reference to another ComPtrRef object, or a pointer to an anonymous object (<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>).  
  
## Return Value  
 The first operator yields <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if object <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is not equal to object <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>; otherwise, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
 The second and third operators yield <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> if object <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is not equal to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>; otherwise, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
 The fourth and fifth operators yield <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> if object <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is not equal to object <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>; otherwise, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
## Remarks  
 Indicates whether two ComPtrRef objects are not equal.  
  
## Requirements  
 **Header:** client.h  
  
 **Namespace:** Microsoft::WRL  
  
## See Also  
 [Microsoft::WRL::Details Namespace](../vs140/microsoft--wrl--details-namespace.md)   
 [ComPtrRef Class](../vs140/comptrref-class.md)