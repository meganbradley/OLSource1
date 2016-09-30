---
title: "Callback Function (Windows Runtime C++ Template Library)"
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
  - "event/Microsoft::WRL::Callback"
dev_langs: 
  - "C++"
ms.assetid: afb15d25-3230-44f7-b321-e17c54872943
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Callback Function (Windows Runtime C++ Template Library)
Creates an object whose member function is a callback method.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A template parameter that specifies the interface of the delegate to call when an event occurs.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A template parameter that specifies the type of an object that represents an object and its callback member function.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A template parameter that specifies the object whose member function is the method to call when an event occurs.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A template parameter that specifies the type of the first callback method argument.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A template parameter that specifies the type of the second callback method argument.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A template parameter that specifies the type of the third callback method argument.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 A template parameter that specifies the type of the fourth callback method argument.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 A template parameter that specifies the type of the fifth callback method argument.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 A template parameter that specifies the type of the sixth callback method argument.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 A template parameter that specifies the type of the seventh callback method argument.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 A template parameter that specifies the type of the eigth callback method argument.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 A template parameter that specifies the type of the ninth callback method argument.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 An object that represents the callback object and its member function.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 The object whose member function is called when an event occurs.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 The member function to call when an event occurs.  
  
## Return Value  
 An object whose member function is the specified callback method.  
  
## Remarks  
 The base of a delegate object must be IUnknown, not IInspectable.  
  
## Requirements  
 **Header:** event.h  
  
 **Namespace:** Microsoft::WRL  
  
## See Also  
 [WRL Namespace](../vs140/microsoft--wrl-namespace.md)